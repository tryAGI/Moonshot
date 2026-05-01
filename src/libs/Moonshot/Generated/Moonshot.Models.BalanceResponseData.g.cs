
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BalanceResponseData
    {
        /// <summary>
        /// The available balance (unit: USD), including cash balance and voucher balance. When it is less than or equal to 0, the user cannot call the inference API<br/>
        /// Example: 49.58894F
        /// </summary>
        /// <example>49.58894F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float AvailableBalance { get; set; }

        /// <summary>
        /// The voucher balance (unit: USD), which cannot be negative<br/>
        /// Example: 46.58893F
        /// </summary>
        /// <example>46.58893F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voucher_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float VoucherBalance { get; set; }

        /// <summary>
        /// The cash balance (unit: USD), which can be negative, indicating that the user owes money. When it is negative, available_balance is equal to the value of voucher_balance<br/>
        /// Example: 3.00001F
        /// </summary>
        /// <example>3.00001F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cash_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float CashBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseData" /> class.
        /// </summary>
        /// <param name="availableBalance">
        /// The available balance (unit: USD), including cash balance and voucher balance. When it is less than or equal to 0, the user cannot call the inference API<br/>
        /// Example: 49.58894F
        /// </param>
        /// <param name="voucherBalance">
        /// The voucher balance (unit: USD), which cannot be negative<br/>
        /// Example: 46.58893F
        /// </param>
        /// <param name="cashBalance">
        /// The cash balance (unit: USD), which can be negative, indicating that the user owes money. When it is negative, available_balance is equal to the value of voucher_balance<br/>
        /// Example: 3.00001F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceResponseData(
            float availableBalance,
            float voucherBalance,
            float cashBalance)
        {
            this.AvailableBalance = availableBalance;
            this.VoucherBalance = voucherBalance;
            this.CashBalance = cashBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseData" /> class.
        /// </summary>
        public BalanceResponseData()
        {
        }
    }
}