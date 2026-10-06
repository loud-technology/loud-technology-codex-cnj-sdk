
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICodexCnjClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}