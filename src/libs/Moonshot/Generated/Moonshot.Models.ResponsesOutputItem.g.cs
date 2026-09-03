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
        /// A custom tool call initiated by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesOutputCustomToolCallItem? CustomToolCall { get; init; }
#else
        public global::Moonshot.ResponsesOutputCustomToolCallItem? CustomToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesOutputCustomToolCallItem? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputCustomToolCallItem PickCustomToolCall() => IsCustomToolCall
            ? CustomToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        /// A web search call executed on the server side. Returned only when the request includes the `web_search` tool and the server decides a search is needed. It appears first in the output array.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesOutputWebSearchCallItem? WebSearchCall { get; init; }
#else
        public global::Moonshot.ResponsesOutputWebSearchCallItem? WebSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesOutputWebSearchCallItem? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesOutputWebSearchCallItem PickWebSearchCall() => IsWebSearchCall
            ? WebSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");
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
        public static implicit operator ResponsesOutputItem(global::Moonshot.ResponsesOutputCustomToolCallItem value) => new ResponsesOutputItem((global::Moonshot.ResponsesOutputCustomToolCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesOutputCustomToolCallItem?(ResponsesOutputItem @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(global::Moonshot.ResponsesOutputCustomToolCallItem? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesOutputItem FromCustomToolCall(global::Moonshot.ResponsesOutputCustomToolCallItem? value) => new ResponsesOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Moonshot.ResponsesOutputWebSearchCallItem value) => new ResponsesOutputItem((global::Moonshot.ResponsesOutputWebSearchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesOutputWebSearchCallItem?(ResponsesOutputItem @this) => @this.WebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(global::Moonshot.ResponsesOutputWebSearchCallItem? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesOutputItem FromWebSearchCall(global::Moonshot.ResponsesOutputWebSearchCallItem? value) => new ResponsesOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesOutputItem(
            global::Moonshot.ResponsesOutputItemDiscriminatorType? type,
            global::Moonshot.ResponsesOutputReasoningItem? reasoning,
            global::Moonshot.ResponsesOutputMessageItem? message,
            global::Moonshot.ResponsesOutputFunctionCallItem? functionCall,
            global::Moonshot.ResponsesOutputCustomToolCallItem? customToolCall,
            global::Moonshot.ResponsesOutputWebSearchCallItem? webSearchCall
            )
        {
            Type = type;

            Reasoning = reasoning;
            Message = message;
            FunctionCall = functionCall;
            CustomToolCall = customToolCall;
            WebSearchCall = webSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearchCall as object ??
            CustomToolCall as object ??
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
            FunctionCall?.ToString() ??
            CustomToolCall?.ToString() ??
            WebSearchCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsReasoning && !IsMessage && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall || !IsReasoning && IsMessage && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall || !IsReasoning && !IsMessage && IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall || !IsReasoning && !IsMessage && !IsFunctionCall && IsCustomToolCall && !IsWebSearchCall || !IsReasoning && !IsMessage && !IsFunctionCall && !IsCustomToolCall && IsWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesOutputReasoningItem, TResult>? reasoning = null,
            global::System.Func<global::Moonshot.ResponsesOutputMessageItem, TResult>? message = null,
            global::System.Func<global::Moonshot.ResponsesOutputFunctionCallItem, TResult>? functionCall = null,
            global::System.Func<global::Moonshot.ResponsesOutputCustomToolCallItem, TResult>? customToolCall = null,
            global::System.Func<global::Moonshot.ResponsesOutputWebSearchCallItem, TResult>? webSearchCall = null,
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
            else if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
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

            global::System.Action<global::Moonshot.ResponsesOutputCustomToolCallItem>? customToolCall = null,

            global::System.Action<global::Moonshot.ResponsesOutputWebSearchCallItem>? webSearchCall = null,
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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ResponsesOutputReasoningItem>? reasoning = null,
            global::System.Action<global::Moonshot.ResponsesOutputMessageItem>? message = null,
            global::System.Action<global::Moonshot.ResponsesOutputFunctionCallItem>? functionCall = null,
            global::System.Action<global::Moonshot.ResponsesOutputCustomToolCallItem>? customToolCall = null,
            global::System.Action<global::Moonshot.ResponsesOutputWebSearchCallItem>? webSearchCall = null,
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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
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
                CustomToolCall,
                typeof(global::Moonshot.ResponsesOutputCustomToolCallItem),
                WebSearchCall,
                typeof(global::Moonshot.ResponsesOutputWebSearchCallItem),
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
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesOutputFunctionCallItem?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesOutputCustomToolCallItem?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesOutputWebSearchCallItem?>.Default.Equals(WebSearchCall, other.WebSearchCall)
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
