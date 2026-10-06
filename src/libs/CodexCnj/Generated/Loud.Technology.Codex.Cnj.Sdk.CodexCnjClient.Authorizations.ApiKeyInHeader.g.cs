
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public sealed partial class CodexCnjClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "Authorization")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyAuthorization",
                Location = "Header",
                Name = "Authorization",
                Value = apiKey,
            });
        }
    }
}