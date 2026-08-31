#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// An element of the input array, discriminated by `type`. When `type` is omitted the item is treated as `message`.
    /// </summary>
    public readonly partial struct ResponsesInputItem : global::System.IEquatable<ResponsesInputItem>
    {
        /// <summary>
        /// A conversation message. `type` may be omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesMessageItem? Message { get; init; }
#else
        public global::Moonshot.ResponsesMessageItem? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesMessageItem? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesMessageItem PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// Replays reasoning content from a previous turn. `content` takes precedence over `summary`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesReasoningItem? Reasoning { get; init; }
#else
        public global::Moonshot.ResponsesReasoningItem? Reasoning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesReasoningItem? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesReasoningItem PickReasoning() => IsReasoning
            ? Reasoning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// Replays a function call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesFunctionCallItem? FunctionCall { get; init; }
#else
        public global::Moonshot.ResponsesFunctionCallItem? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesFunctionCallItem? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallItem PickFunctionCall() => IsFunctionCall
            ? FunctionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// Result of executing a function call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesFunctionCallOutputItem? FunctionCallOutput { get; init; }
#else
        public global::Moonshot.ResponsesFunctionCallOutputItem? FunctionCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesFunctionCallOutputItem? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionCallOutputItem PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Adds callable tools partway through a conversation, effective from the position of this item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesAdditionalToolsItem? AdditionalTools { get; init; }
#else
        public global::Moonshot.ResponsesAdditionalToolsItem? AdditionalTools { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdditionalTools))]
#endif
        public bool IsAdditionalTools => AdditionalTools != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAdditionalTools(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesAdditionalToolsItem? value)
        {
            value = AdditionalTools;
            return IsAdditionalTools;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesAdditionalToolsItem PickAdditionalTools() => IsAdditionalTools
            ? AdditionalTools!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdditionalTools' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesMessageItem value) => new ResponsesInputItem((global::Moonshot.ResponsesMessageItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesMessageItem?(ResponsesInputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesMessageItem? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromMessage(global::Moonshot.ResponsesMessageItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesReasoningItem value) => new ResponsesInputItem((global::Moonshot.ResponsesReasoningItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesReasoningItem?(ResponsesInputItem @this) => @this.Reasoning;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromReasoning(global::Moonshot.ResponsesReasoningItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesFunctionCallItem value) => new ResponsesInputItem((global::Moonshot.ResponsesFunctionCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesFunctionCallItem?(ResponsesInputItem @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesFunctionCallItem? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromFunctionCall(global::Moonshot.ResponsesFunctionCallItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesFunctionCallOutputItem value) => new ResponsesInputItem((global::Moonshot.ResponsesFunctionCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesFunctionCallOutputItem?(ResponsesInputItem @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesFunctionCallOutputItem? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromFunctionCallOutput(global::Moonshot.ResponsesFunctionCallOutputItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesAdditionalToolsItem value) => new ResponsesInputItem((global::Moonshot.ResponsesAdditionalToolsItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesAdditionalToolsItem?(ResponsesInputItem @this) => @this.AdditionalTools;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesAdditionalToolsItem? value)
        {
            AdditionalTools = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromAdditionalTools(global::Moonshot.ResponsesAdditionalToolsItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(
            global::Moonshot.ResponsesMessageItem? message,
            global::Moonshot.ResponsesReasoningItem? reasoning,
            global::Moonshot.ResponsesFunctionCallItem? functionCall,
            global::Moonshot.ResponsesFunctionCallOutputItem? functionCallOutput,
            global::Moonshot.ResponsesAdditionalToolsItem? additionalTools
            )
        {
            Message = message;
            Reasoning = reasoning;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            AdditionalTools = additionalTools;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AdditionalTools as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            Reasoning as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Reasoning?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            AdditionalTools?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAdditionalTools || !IsMessage && IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAdditionalTools || !IsMessage && !IsReasoning && IsFunctionCall && !IsFunctionCallOutput && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && IsFunctionCallOutput && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && IsAdditionalTools;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesMessageItem, TResult>? message = null,
            global::System.Func<global::Moonshot.ResponsesReasoningItem, TResult>? reasoning = null,
            global::System.Func<global::Moonshot.ResponsesFunctionCallItem, TResult>? functionCall = null,
            global::System.Func<global::Moonshot.ResponsesFunctionCallOutputItem, TResult>? functionCallOutput = null,
            global::System.Func<global::Moonshot.ResponsesAdditionalToolsItem, TResult>? additionalTools = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsAdditionalTools && additionalTools != null)
            {
                return additionalTools(AdditionalTools!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ResponsesMessageItem>? message = null,

            global::System.Action<global::Moonshot.ResponsesReasoningItem>? reasoning = null,

            global::System.Action<global::Moonshot.ResponsesFunctionCallItem>? functionCall = null,

            global::System.Action<global::Moonshot.ResponsesFunctionCallOutputItem>? functionCallOutput = null,

            global::System.Action<global::Moonshot.ResponsesAdditionalToolsItem>? additionalTools = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsAdditionalTools)
            {
                additionalTools?.Invoke(AdditionalTools!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ResponsesMessageItem>? message = null,
            global::System.Action<global::Moonshot.ResponsesReasoningItem>? reasoning = null,
            global::System.Action<global::Moonshot.ResponsesFunctionCallItem>? functionCall = null,
            global::System.Action<global::Moonshot.ResponsesFunctionCallOutputItem>? functionCallOutput = null,
            global::System.Action<global::Moonshot.ResponsesAdditionalToolsItem>? additionalTools = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsAdditionalTools)
            {
                additionalTools?.Invoke(AdditionalTools!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::Moonshot.ResponsesMessageItem),
                Reasoning,
                typeof(global::Moonshot.ResponsesReasoningItem),
                FunctionCall,
                typeof(global::Moonshot.ResponsesFunctionCallItem),
                FunctionCallOutput,
                typeof(global::Moonshot.ResponsesFunctionCallOutputItem),
                AdditionalTools,
                typeof(global::Moonshot.ResponsesAdditionalToolsItem),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponsesInputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesMessageItem?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesFunctionCallItem?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesFunctionCallOutputItem?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesAdditionalToolsItem?>.Default.Equals(AdditionalTools, other.AdditionalTools)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponsesInputItem obj1, ResponsesInputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesInputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesInputItem obj1, ResponsesInputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesInputItem o && Equals(o);
        }
    }
}
