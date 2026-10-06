#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.30.2-dev.152"
readonly AUTOSDK_TOOL_DIR=".tools/autosdk-${AUTOSDK_VERSION}"
readonly SOURCE_OPENAPI="../../../codex-cnj-swagger.json"
readonly DEFAULT_BASE_URL="https://api-processo.data-lake.pdpj.jus.br/processo-api"

if command -v autosdk >/dev/null 2>&1 && [[ "$(autosdk --version)" == "${AUTOSDK_VERSION}"* ]]; then
  AUTOSDK_COMMAND="$(command -v autosdk)"
else
  if [[ ! -x "${AUTOSDK_TOOL_DIR}/autosdk" ]] || [[ "$("${AUTOSDK_TOOL_DIR}/autosdk" --version)" != "${AUTOSDK_VERSION}"* ]]; then
    rm -rf "${AUTOSDK_TOOL_DIR}"
    dotnet tool install autosdk.cli --tool-path "${AUTOSDK_TOOL_DIR}" --version "${AUTOSDK_VERSION}"
  fi
  AUTOSDK_COMMAND="${AUTOSDK_TOOL_DIR}/autosdk"
fi

cp "${SOURCE_OPENAPI}" openapi.json
python3 apply-openapi-overrides.py openapi.json

rm -rf Generated

"${AUTOSDK_COMMAND}" generate openapi.json \
  --namespace Loud.Technology.Codex.Cnj.Sdk \
  --clientClassName CodexCnjClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env CODEX_CNJ_BASE_URL \
  --security-scheme ApiKey:Header:Authorization \
  --api-key-env CODEX_CNJ_ACCESS_TOKEN \
  --validation \
  --generate-http-exception-hierarchy \
  --exclude-deprecated-operations
