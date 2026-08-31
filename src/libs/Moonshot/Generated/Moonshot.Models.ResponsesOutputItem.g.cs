#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// An element of the output array, discriminated by `type`.
    /// </summary>
    public readonly partial struct ResponsesOutputItem : global::System.IEquatable<ResponsesOutputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Reasoning content produced by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesOutputReasoningItem? Reasoning { get; init; }
#else
        public global::Moonshot.ResponsesOutputReasoningItem? Reasoning { get; }
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
            out global::Moonshot.ResponsesOutputReasoningItem? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputReasoningItem PickReasoning() => IsReasoning
            ? Reasoning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// Text reply produced by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesOutputMessageItem? Message { get; init; }
#else
        public global::Moonshot.ResponsesOutputMessageItem? Message { get; }
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
            out global::Moonshot.ResponsesOutputMessageItem? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputMessageItem PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// A function call initiated by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesOutputFunctionCallItem? FunctionCall { get; init; }
#else
        public global::Moonshot.ResponsesOutputFunctionCallItem? FunctionCall { get; }
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
            out global::Moonshot.ResponsesOutputFunctionCallItem? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputFunctionCallItem PickFunctionCall() => IsFunctionCall
            ? FunctionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Moonshot.ResponsesOutputReasoningItem value) => new ResponsesOutputItem((global::Moonshot.ResponsesOutputReasoningItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesOutputReasoningItem?(ResponsesOutputItem @this) => @this.Reasoning;

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(global::Moonshot.ResponsesOutputReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesOutputItem FromReasoning(global::Moonshot.ResponsesOutputReasoningItem? value) => new ResponsesOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Moonshot.ResponsesOutputMessageItem value) => new ResponsesOutputItem((global::Moonshot.ResponsesOutputMessageItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesOutputMessageItem?(ResponsesOutputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(global::Moonshot.ResponsesOutputMessageItem? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesOutputItem FromMessage(global::Moonshot.ResponsesOutputMessageItem? value) => new ResponsesOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Moonshot.ResponsesOutputFunctionCallItem value) => new ResponsesOutputItem((global::Moonshot.ResponsesOutputFunctionCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesOutputFunctionCallItem?(ResponsesOutputItem @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(global::Moonshot.ResponsesOutputFunctionCallItem? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesOutputItem FromFunctionCall(global::Moonshot.ResponsesOutputFunctionCallItem? value) => new ResponsesOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(
            global::Moonshot.ResponsesOutputItemDiscriminatorType? type,
            global::Moonshot.ResponsesOutputReasoningItem? reasoning,
            global::Moonshot.ResponsesOutputMessageItem? message,
            global::Moonshot.ResponsesOutputFunctionCallItem? functionCall
            )
        {
            Type = type;

            Reasoning = reasoning;
            Message = message;
            FunctionCall = functionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCall as object ??
            Message as object ??
            Reasoning as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Reasoning?.ToString() ??
            Message?.ToString() ??
            FunctionCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsReasoning && !IsMessage && !IsFunctionCall || !IsReasoning && IsMessage && !IsFunctionCall || !IsReasoning && !IsMessage && IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesOutputReasoningItem, TResult>? reasoning = null,
            global::System.Func<global::Moonshot.ResponsesOutputMessageItem, TResult>? message = null,
            global::System.Func<global::Moonshot.ResponsesOutputFunctionCallItem, TResult>? functionCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ResponsesOutputReasoningItem>? reasoning = null,

            global::System.Action<global::Moonshot.ResponsesOutputMessageItem>? message = null,

            global::System.Action<global::Moonshot.ResponsesOutputFunctionCallItem>? functionCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ResponsesOutputReasoningItem>? reasoning = null,
            global::System.Action<global::Moonshot.ResponsesOutputMessageItem>? message = null,
            global::System.Action<global::Moonshot.ResponsesOutputFunctionCallItem>? functionCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Reasoning,
                typeof(global::Moonshot.ResponsesOutputReasoningItem),
                Message,
                typeof(global::Moonshot.ResponsesOutputMessageItem),
                FunctionCall,
                typeof(global::Moonshot.ResponsesOutputFunctionCallItem),
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
        public bool Equals(ResponsesOutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesOutputReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesOutputMessageItem?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesOutputFunctionCallItem?>.Default.Equals(FunctionCall, other.FunctionCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponsesOutputItem obj1, ResponsesOutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesOutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesOutputItem obj1, ResponsesOutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesOutputItem o && Equals(o);
        }
    }
}
