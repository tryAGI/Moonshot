
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Current status: validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
    /// </summary>
    public enum BatchObjectStatus
    {
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Cancelled,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Cancelling,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Completed,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Expired,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Failed,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Finalizing,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        InProgress,
        /// <summary>
        /// validating, failed, in_progress, finalizing, completed, expired, cancelling, cancelled
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectStatus value)
        {
            return value switch
            {
                BatchObjectStatus.Cancelled => "cancelled",
                BatchObjectStatus.Cancelling => "cancelling",
                BatchObjectStatus.Completed => "completed",
                BatchObjectStatus.Expired => "expired",
                BatchObjectStatus.Failed => "failed",
                BatchObjectStatus.Finalizing => "finalizing",
                BatchObjectStatus.InProgress => "in_progress",
                BatchObjectStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchObjectStatus.Cancelled,
                "cancelling" => BatchObjectStatus.Cancelling,
                "completed" => BatchObjectStatus.Completed,
                "expired" => BatchObjectStatus.Expired,
                "failed" => BatchObjectStatus.Failed,
                "finalizing" => BatchObjectStatus.Finalizing,
                "in_progress" => BatchObjectStatus.InProgress,
                "validating" => BatchObjectStatus.Validating,
                _ => null,
            };
        }
    }
}