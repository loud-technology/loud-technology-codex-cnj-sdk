#!/usr/bin/env python3
"""Apply deterministic generation fixes to the Codex CNJ Swagger document."""

from __future__ import annotations

import json
import re
import sys
from pathlib import Path
from typing import Any


EXPECTED_HOST = "api-processo.data-lake.pdpj.jus.br"
EXPECTED_BASE_PATH = "/processo-api"
HTTP_METHODS = {"get", "post", "put", "patch", "delete", "head", "options"}


def normalize_operation_id(operation_id: str) -> str:
    """Convert Springfox operation IDs into stable, idiomatic .NET method names."""
    normalized = re.sub(r"Using(?:GET|POST|PUT|PATCH|DELETE|HEAD|OPTIONS)(?:_(\d+))?$", r"\1", operation_id)
    normalized = normalized[:1].upper() + normalized[1:]
    return normalized


def apply_overrides(spec: dict[str, Any]) -> None:
    if spec.get("swagger") != "2.0":
        raise RuntimeError("Codex CNJ input is expected to be a Swagger 2.0 document")
    if spec.get("host") != EXPECTED_HOST or spec.get("basePath") != EXPECTED_BASE_PATH:
        raise RuntimeError("Codex CNJ host or basePath changed; review the generated SDK base URL")

    jwt = spec.get("securityDefinitions", {}).get("JWT")
    expected_security = {"type": "apiKey", "name": "Authorization", "in": "header"}
    if not isinstance(jwt, dict) or any(jwt.get(key) != value for key, value in expected_security.items()):
        raise RuntimeError("Codex CNJ Swagger no longer defines JWT in the Authorization header")

    spec["schemes"] = ["https"]
    spec["security"] = [{"JWT": []}]

    operation_ids: set[str] = set()
    for path_item in spec.get("paths", {}).values():
        for method, operation in path_item.items():
            if method.lower() not in HTTP_METHODS or not isinstance(operation, dict):
                continue
            operation_id = operation.get("operationId")
            if not isinstance(operation_id, str) or not operation_id:
                raise RuntimeError("Every Codex CNJ operation must define an operationId")
            normalized = normalize_operation_id(operation_id)
            if normalized in operation_ids:
                raise RuntimeError(f"Normalized operationId is duplicated: {normalized}")
            operation_ids.add(normalized)
            operation["operationId"] = normalized


def main() -> None:
    if len(sys.argv) != 2:
        raise SystemExit(f"usage: {Path(sys.argv[0]).name} OPENAPI_FILE")

    path = Path(sys.argv[1])
    with path.open(encoding="utf-8") as stream:
        spec = json.load(stream)

    apply_overrides(spec)

    with path.open("w", encoding="utf-8") as stream:
        json.dump(spec, stream, ensure_ascii=False, indent=2)
        stream.write("\n")


if __name__ == "__main__":
    main()
