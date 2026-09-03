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
        /// Replays a custom tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesCustomToolCallItem? CustomToolCall { get; init; }
#else
        public global::Moonshot.ResponsesCustomToolCallItem? CustomToolCall { get; }
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
            out global::Moonshot.ResponsesCustomToolCallItem? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallItem PickCustomToolCall() => IsCustomToolCall
            ? CustomToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        /// Result of executing a custom tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesCustomToolCallOutputItem? CustomToolCallOutput { get; init; }
#else
        public global::Moonshot.ResponsesCustomToolCallOutputItem? CustomToolCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutput))]
#endif
        public bool IsCustomToolCallOutput => CustomToolCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesCustomToolCallOutputItem? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomToolCallOutputItem PickCustomToolCallOutput() => IsCustomToolCallOutput
            ? CustomToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Replays a previous web search call. Kept for history only and ignored during conversion; the search results are already carried by the assistant message that follows.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesWebSearchCallItem? WebSearchCall { get; init; }
#else
        public global::Moonshot.ResponsesWebSearchCallItem? WebSearchCall { get; }
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
            out global::Moonshot.ResponsesWebSearchCallItem? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchCallItem PickWebSearchCall() => IsWebSearchCall
            ? WebSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");

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
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesCustomToolCallItem value) => new ResponsesInputItem((global::Moonshot.ResponsesCustomToolCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesCustomToolCallItem?(ResponsesInputItem @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesCustomToolCallItem? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromCustomToolCall(global::Moonshot.ResponsesCustomToolCallItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesCustomToolCallOutputItem value) => new ResponsesInputItem((global::Moonshot.ResponsesCustomToolCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesCustomToolCallOutputItem?(ResponsesInputItem @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesCustomToolCallOutputItem? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromCustomToolCallOutput(global::Moonshot.ResponsesCustomToolCallOutputItem? value) => new ResponsesInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputItem(global::Moonshot.ResponsesWebSearchCallItem value) => new ResponsesInputItem((global::Moonshot.ResponsesWebSearchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesWebSearchCallItem?(ResponsesInputItem @this) => @this.WebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputItem(global::Moonshot.ResponsesWebSearchCallItem? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputItem FromWebSearchCall(global::Moonshot.ResponsesWebSearchCallItem? value) => new ResponsesInputItem(value);

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
            global::Moonshot.ResponsesCustomToolCallItem? customToolCall,
            global::Moonshot.ResponsesCustomToolCallOutputItem? customToolCallOutput,
            global::Moonshot.ResponsesWebSearchCallItem? webSearchCall,
            global::Moonshot.ResponsesAdditionalToolsItem? additionalTools
            )
        {
            Message = message;
            Reasoning = reasoning;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            CustomToolCall = customToolCall;
            CustomToolCallOutput = customToolCallOutput;
            WebSearchCall = webSearchCall;
            AdditionalTools = additionalTools;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AdditionalTools as object ??
            WebSearchCall as object ??
            CustomToolCallOutput as object ??
            CustomToolCall as object ??
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
            CustomToolCall?.ToString() ??
            CustomToolCallOutput?.ToString() ??
            WebSearchCall?.ToString() ??
            AdditionalTools?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput && !IsWebSearchCall && !IsAdditionalTools || !IsMessage && IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput && !IsWebSearchCall && !IsAdditionalTools || !IsMessage && !IsReasoning && IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput && !IsWebSearchCall && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput && !IsWebSearchCall && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && IsCustomToolCall && !IsCustomToolCallOutput && !IsWebSearchCall && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && IsCustomToolCallOutput && !IsWebSearchCall && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput && IsWebSearchCall && !IsAdditionalTools || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput && !IsWebSearchCall && IsAdditionalTools;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesMessageItem, TResult>? message = null,
            global::System.Func<global::Moonshot.ResponsesReasoningItem, TResult>? reasoning = null,
            global::System.Func<global::Moonshot.ResponsesFunctionCallItem, TResult>? functionCall = null,
            global::System.Func<global::Moonshot.ResponsesFunctionCallOutputItem, TResult>? functionCallOutput = null,
            global::System.Func<global::Moonshot.ResponsesCustomToolCallItem, TResult>? customToolCall = null,
            global::System.Func<global::Moonshot.ResponsesCustomToolCallOutputItem, TResult>? customToolCallOutput = null,
            global::System.Func<global::Moonshot.ResponsesWebSearchCallItem, TResult>? webSearchCall = null,
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
            else if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsCustomToolCallOutput && customToolCallOutput != null)
            {
                return customToolCallOutput(CustomToolCallOutput!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
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

            global::System.Action<global::Moonshot.ResponsesCustomToolCallItem>? customToolCall = null,

            global::System.Action<global::Moonshot.ResponsesCustomToolCallOutputItem>? customToolCallOutput = null,

            global::System.Action<global::Moonshot.ResponsesWebSearchCallItem>? webSearchCall = null,

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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
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
            global::System.Action<global::Moonshot.ResponsesCustomToolCallItem>? customToolCall = null,
            global::System.Action<global::Moonshot.ResponsesCustomToolCallOutputItem>? customToolCallOutput = null,
            global::System.Action<global::Moonshot.ResponsesWebSearchCallItem>? webSearchCall = null,
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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
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
                CustomToolCall,
                typeof(global::Moonshot.ResponsesCustomToolCallItem),
                CustomToolCallOutput,
                typeof(global::Moonshot.ResponsesCustomToolCallOutputItem),
                WebSearchCall,
                typeof(global::Moonshot.ResponsesWebSearchCallItem),
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
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesCustomToolCallItem?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesCustomToolCallOutputItem?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesWebSearchCallItem?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
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
