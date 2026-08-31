
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesStreamEventType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        ResponseCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
        /// <summary>
        ///
        /// </summary>
        ResponseFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        ///
        /// </summary>
        ResponseInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseIncomplete,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesStreamEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesStreamEventType value)
        {
            return value switch
            {
                ResponsesStreamEventType.Error => "error",
                ResponsesStreamEventType.ResponseCompleted => "response.completed",
                ResponsesStreamEventType.ResponseContentPartAdded => "response.content_part.added",
                ResponsesStreamEventType.ResponseContentPartDone => "response.content_part.done",
                ResponsesStreamEventType.ResponseCreated => "response.created",
                ResponsesStreamEventType.ResponseFailed => "response.failed",
                ResponsesStreamEventType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                ResponsesStreamEventType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ResponsesStreamEventType.ResponseInProgress => "response.in_progress",
                ResponsesStreamEventType.ResponseIncomplete => "response.incomplete",
                ResponsesStreamEventType.ResponseOutputItemAdded => "response.output_item.added",
                ResponsesStreamEventType.ResponseOutputItemDone => "response.output_item.done",
                ResponsesStreamEventType.ResponseOutputTextDelta => "response.output_text.delta",
                ResponsesStreamEventType.ResponseOutputTextDone => "response.output_text.done",
                ResponsesStreamEventType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                ResponsesStreamEventType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                ResponsesStreamEventType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                ResponsesStreamEventType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesStreamEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ResponsesStreamEventType.Error,
                "response.completed" => ResponsesStreamEventType.ResponseCompleted,
                "response.content_part.added" => ResponsesStreamEventType.ResponseContentPartAdded,
                "response.content_part.done" => ResponsesStreamEventType.ResponseContentPartDone,
                "response.created" => ResponsesStreamEventType.ResponseCreated,
                "response.failed" => ResponsesStreamEventType.ResponseFailed,
                "response.function_call_arguments.delta" => ResponsesStreamEventType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => ResponsesStreamEventType.ResponseFunctionCallArgumentsDone,
                "response.in_progress" => ResponsesStreamEventType.ResponseInProgress,
                "response.incomplete" => ResponsesStreamEventType.ResponseIncomplete,
                "response.output_item.added" => ResponsesStreamEventType.ResponseOutputItemAdded,
                "response.output_item.done" => ResponsesStreamEventType.ResponseOutputItemDone,
                "response.output_text.delta" => ResponsesStreamEventType.ResponseOutputTextDelta,
                "response.output_text.done" => ResponsesStreamEventType.ResponseOutputTextDone,
                "response.reasoning_summary_part.added" => ResponsesStreamEventType.ResponseReasoningSummaryPartAdded,
                "response.reasoning_summary_part.done" => ResponsesStreamEventType.ResponseReasoningSummaryPartDone,
                "response.reasoning_summary_text.delta" => ResponsesStreamEventType.ResponseReasoningSummaryTextDelta,
                "response.reasoning_summary_text.done" => ResponsesStreamEventType.ResponseReasoningSummaryTextDone,
                _ => null,
            };
        }
    }
}