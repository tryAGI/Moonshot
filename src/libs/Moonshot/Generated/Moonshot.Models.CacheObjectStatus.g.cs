
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Cache status: pending (being created), active (ready), expired (expired)
    /// </summary>
    public enum CacheObjectStatus
    {
        /// <summary>
        /// pending (being created), active (ready), expired (expired)
        /// </summary>
        Active,
        /// <summary>
        /// pending (being created), active (ready), expired (expired)
        /// </summary>
        Expired,
        /// <summary>
        /// pending (being created), active (ready), expired (expired)
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CacheObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CacheObjectStatus value)
        {
            return value switch
            {
                CacheObjectStatus.Active => "active",
                CacheObjectStatus.Expired => "expired",
                CacheObjectStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CacheObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CacheObjectStatus.Active,
                "expired" => CacheObjectStatus.Expired,
                "pending" => CacheObjectStatus.Pending,
                _ => null,
            };
        }
    }
}