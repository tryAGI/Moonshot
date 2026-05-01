
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BalanceResponse
    {
        /// <summary>
        /// Response code. 0 indicates success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.BalanceResponseData Data { get; set; }

        /// <summary>
        /// Status code<br/>
        /// Example: 0x0
        /// </summary>
        /// <example>0x0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scode { get; set; }

        /// <summary>
        /// Request status<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// Response code. 0 indicates success.
        /// </param>
        /// <param name="data"></param>
        /// <param name="scode">
        /// Status code<br/>
        /// Example: 0x0
        /// </param>
        /// <param name="status">
        /// Request status<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceResponse(
            int code,
            global::Moonshot.BalanceResponseData data,
            string scode,
            bool status)
        {
            this.Code = code;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Scode = scode ?? throw new global::System.ArgumentNullException(nameof(scode));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        public BalanceResponse()
        {
        }
    }
}