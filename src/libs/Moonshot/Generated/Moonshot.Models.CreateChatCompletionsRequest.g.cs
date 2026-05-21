#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateChatCompletionsRequest : global::System.IEquatable<CreateChatCompletionsRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? Model { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK26ChatRequest? KimiK26 { get; init; }
#else
        public global::Moonshot.KimiK26ChatRequest? KimiK26 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK26))]
#endif
        public bool IsKimiK26 => KimiK26 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKimiK26(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK26ChatRequest? value)
        {
            value = KimiK26;
            return IsKimiK26;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK26ChatRequest PickKimiK26() => IsKimiK26
            ? KimiK26!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK26' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK25ChatRequest? KimiK25 { get; init; }
#else
        public global::Moonshot.KimiK25ChatRequest? KimiK25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK25))]
#endif
        public bool IsKimiK25 => KimiK25 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKimiK25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK25ChatRequest? value)
        {
            value = KimiK25;
            return IsKimiK25;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK25ChatRequest PickKimiK25() => IsKimiK25
            ? KimiK25!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK25' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK2ChatRequest? KimiK20905Preview { get; init; }
#else
        public global::Moonshot.KimiK2ChatRequest? KimiK20905Preview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK20905Preview))]
#endif
        public bool IsKimiK20905Preview => KimiK20905Preview != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKimiK20905Preview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK2ChatRequest? value)
        {
            value = KimiK20905Preview;
            return IsKimiK20905Preview;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK2ChatRequest PickKimiK20905Preview() => IsKimiK20905Preview
            ? KimiK20905Preview!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK20905Preview' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK2ThinkingChatRequest? KimiK2Thinking { get; init; }
#else
        public global::Moonshot.KimiK2ThinkingChatRequest? KimiK2Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK2Thinking))]
#endif
        public bool IsKimiK2Thinking => KimiK2Thinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKimiK2Thinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK2ThinkingChatRequest? value)
        {
            value = KimiK2Thinking;
            return IsKimiK2Thinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK2ThinkingChatRequest PickKimiK2Thinking() => IsKimiK2Thinking
            ? KimiK2Thinking!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK2Thinking' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MoonshotV1ChatRequest? MoonshotV18k { get; init; }
#else
        public global::Moonshot.MoonshotV1ChatRequest? MoonshotV18k { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MoonshotV18k))]
#endif
        public bool IsMoonshotV18k => MoonshotV18k != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMoonshotV18k(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MoonshotV1ChatRequest? value)
        {
            value = MoonshotV18k;
            return IsMoonshotV18k;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.MoonshotV1ChatRequest PickMoonshotV18k() => IsMoonshotV18k
            ? MoonshotV18k!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MoonshotV18k' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK26ChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK26ChatRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK26ChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK26;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK26ChatRequest? value)
        {
            KimiK26 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK26(global::Moonshot.KimiK26ChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK25ChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK25ChatRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK25ChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK25;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK25ChatRequest? value)
        {
            KimiK25 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK25(global::Moonshot.KimiK25ChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK2ChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK2ChatRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK2ChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK20905Preview;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK2ChatRequest? value)
        {
            KimiK20905Preview = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK20905Preview(global::Moonshot.KimiK2ChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK2ThinkingChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK2ThinkingChatRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK2ThinkingChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK2Thinking;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK2ThinkingChatRequest? value)
        {
            KimiK2Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK2Thinking(global::Moonshot.KimiK2ThinkingChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.MoonshotV1ChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.MoonshotV1ChatRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.MoonshotV1ChatRequest?(CreateChatCompletionsRequest @this) => @this.MoonshotV18k;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.MoonshotV1ChatRequest? value)
        {
            MoonshotV18k = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionsRequest FromMoonshotV18k(global::Moonshot.MoonshotV1ChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionsRequest(
            global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? model,
            global::Moonshot.KimiK26ChatRequest? kimiK26,
            global::Moonshot.KimiK25ChatRequest? kimiK25,
            global::Moonshot.KimiK2ChatRequest? kimiK20905Preview,
            global::Moonshot.KimiK2ThinkingChatRequest? kimiK2Thinking,
            global::Moonshot.MoonshotV1ChatRequest? moonshotV18k
            )
        {
            Model = model;

            KimiK26 = kimiK26;
            KimiK25 = kimiK25;
            KimiK20905Preview = kimiK20905Preview;
            KimiK2Thinking = kimiK2Thinking;
            MoonshotV18k = moonshotV18k;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MoonshotV18k as object ??
            KimiK2Thinking as object ??
            KimiK20905Preview as object ??
            KimiK25 as object ??
            KimiK26 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            KimiK26?.ToString() ??
            KimiK25?.ToString() ??
            KimiK20905Preview?.ToString() ??
            KimiK2Thinking?.ToString() ??
            MoonshotV18k?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsKimiK26 && !IsKimiK25 && !IsKimiK20905Preview && !IsKimiK2Thinking && !IsMoonshotV18k || !IsKimiK26 && IsKimiK25 && !IsKimiK20905Preview && !IsKimiK2Thinking && !IsMoonshotV18k || !IsKimiK26 && !IsKimiK25 && IsKimiK20905Preview && !IsKimiK2Thinking && !IsMoonshotV18k || !IsKimiK26 && !IsKimiK25 && !IsKimiK20905Preview && IsKimiK2Thinking && !IsMoonshotV18k || !IsKimiK26 && !IsKimiK25 && !IsKimiK20905Preview && !IsKimiK2Thinking && IsMoonshotV18k;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.KimiK26ChatRequest?, TResult>? kimiK26 = null,
            global::System.Func<global::Moonshot.KimiK25ChatRequest?, TResult>? kimiK25 = null,
            global::System.Func<global::Moonshot.KimiK2ChatRequest?, TResult>? kimiK20905Preview = null,
            global::System.Func<global::Moonshot.KimiK2ThinkingChatRequest?, TResult>? kimiK2Thinking = null,
            global::System.Func<global::Moonshot.MoonshotV1ChatRequest?, TResult>? moonshotV18k = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKimiK26 && kimiK26 != null)
            {
                return kimiK26(KimiK26!);
            }
            else if (IsKimiK25 && kimiK25 != null)
            {
                return kimiK25(KimiK25!);
            }
            else if (IsKimiK20905Preview && kimiK20905Preview != null)
            {
                return kimiK20905Preview(KimiK20905Preview!);
            }
            else if (IsKimiK2Thinking && kimiK2Thinking != null)
            {
                return kimiK2Thinking(KimiK2Thinking!);
            }
            else if (IsMoonshotV18k && moonshotV18k != null)
            {
                return moonshotV18k(MoonshotV18k!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.KimiK26ChatRequest?>? kimiK26 = null,

            global::System.Action<global::Moonshot.KimiK25ChatRequest?>? kimiK25 = null,

            global::System.Action<global::Moonshot.KimiK2ChatRequest?>? kimiK20905Preview = null,

            global::System.Action<global::Moonshot.KimiK2ThinkingChatRequest?>? kimiK2Thinking = null,

            global::System.Action<global::Moonshot.MoonshotV1ChatRequest?>? moonshotV18k = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKimiK26)
            {
                kimiK26?.Invoke(KimiK26!);
            }
            else if (IsKimiK25)
            {
                kimiK25?.Invoke(KimiK25!);
            }
            else if (IsKimiK20905Preview)
            {
                kimiK20905Preview?.Invoke(KimiK20905Preview!);
            }
            else if (IsKimiK2Thinking)
            {
                kimiK2Thinking?.Invoke(KimiK2Thinking!);
            }
            else if (IsMoonshotV18k)
            {
                moonshotV18k?.Invoke(MoonshotV18k!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.KimiK26ChatRequest?>? kimiK26 = null,
            global::System.Action<global::Moonshot.KimiK25ChatRequest?>? kimiK25 = null,
            global::System.Action<global::Moonshot.KimiK2ChatRequest?>? kimiK20905Preview = null,
            global::System.Action<global::Moonshot.KimiK2ThinkingChatRequest?>? kimiK2Thinking = null,
            global::System.Action<global::Moonshot.MoonshotV1ChatRequest?>? moonshotV18k = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKimiK26)
            {
                kimiK26?.Invoke(KimiK26!);
            }
            else if (IsKimiK25)
            {
                kimiK25?.Invoke(KimiK25!);
            }
            else if (IsKimiK20905Preview)
            {
                kimiK20905Preview?.Invoke(KimiK20905Preview!);
            }
            else if (IsKimiK2Thinking)
            {
                kimiK2Thinking?.Invoke(KimiK2Thinking!);
            }
            else if (IsMoonshotV18k)
            {
                moonshotV18k?.Invoke(MoonshotV18k!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KimiK26,
                typeof(global::Moonshot.KimiK26ChatRequest),
                KimiK25,
                typeof(global::Moonshot.KimiK25ChatRequest),
                KimiK20905Preview,
                typeof(global::Moonshot.KimiK2ChatRequest),
                KimiK2Thinking,
                typeof(global::Moonshot.KimiK2ThinkingChatRequest),
                MoonshotV18k,
                typeof(global::Moonshot.MoonshotV1ChatRequest),
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
        public bool Equals(CreateChatCompletionsRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK26ChatRequest?>.Default.Equals(KimiK26, other.KimiK26) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK25ChatRequest?>.Default.Equals(KimiK25, other.KimiK25) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK2ChatRequest?>.Default.Equals(KimiK20905Preview, other.KimiK20905Preview) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK2ThinkingChatRequest?>.Default.Equals(KimiK2Thinking, other.KimiK2Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MoonshotV1ChatRequest?>.Default.Equals(MoonshotV18k, other.MoonshotV18k) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateChatCompletionsRequest obj1, CreateChatCompletionsRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateChatCompletionsRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateChatCompletionsRequest obj1, CreateChatCompletionsRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateChatCompletionsRequest o && Equals(o);
        }
    }
}
