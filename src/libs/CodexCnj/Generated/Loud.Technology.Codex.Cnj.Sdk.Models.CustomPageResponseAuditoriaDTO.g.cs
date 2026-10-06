
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomPageResponseAuditoriaDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.AuditoriaDTO>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        public bool? First { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last")]
        public bool? Last { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPageSizeElements")]
        public int? MaxPageSizeElements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageNumber")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalElements")]
        public long? TotalElements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPageResponseAuditoriaDTO" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="maxPageSizeElements"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <param name="totalElements"></param>
        /// <param name="totalPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomPageResponseAuditoriaDTO(
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.AuditoriaDTO>? content,
            bool? first,
            bool? last,
            int? maxPageSizeElements,
            int? pageNumber,
            int? pageSize,
            long? total,
            long? totalElements,
            int? totalPages)
        {
            this.Content = content;
            this.First = first;
            this.Last = last;
            this.MaxPageSizeElements = maxPageSizeElements;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Total = total;
            this.TotalElements = totalElements;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPageResponseAuditoriaDTO" /> class.
        /// </summary>
        public CustomPageResponseAuditoriaDTO()
        {
        }

    }
}