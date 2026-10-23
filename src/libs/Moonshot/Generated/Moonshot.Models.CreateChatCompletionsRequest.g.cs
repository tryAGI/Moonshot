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
        public global::Moonshot.KimiK31ProChatRequest? KimiK31Pro { get; init; }
#else
        public global::Moonshot.KimiK31ProChatRequest? KimiK31Pro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK31Pro))]
#endif
        public bool IsKimiK31Pro => KimiK31Pro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKimiK31Pro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK31ProChatRequest? value)
        {
            value = KimiK31Pro;
            return IsKimiK31Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK31ProChatRequest PickKimiK31Pro() => KimiK31Pro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK31Pro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK3ChatRequest? KimiK3 { get; init; }
#else
        public global::Moonshot.KimiK3ChatRequest? KimiK3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK3))]
#endif
        public bool IsKimiK3 => KimiK3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKimiK3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK3ChatRequest? value)
        {
            value = KimiK3;
            return IsKimiK3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequest PickKimiK3() => KimiK3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK27CodeChatRequest? KimiK27Code { get; init; }
#else
        public global::Moonshot.KimiK27CodeChatRequest? KimiK27Code { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK27Code))]
#endif
        public bool IsKimiK27Code => KimiK27Code != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKimiK27Code(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK27CodeChatRequest? value)
        {
            value = KimiK27Code;
            return IsKimiK27Code;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequest PickKimiK27Code() => KimiK27Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK27Code' but the value was {ToString()}.");

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
        public global::Moonshot.KimiK26ChatRequest PickKimiK26() => KimiK26 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK26' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK31ProChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK31ProChatRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK31ProChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK31Pro;

        /// <summary>
        ///
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK31ProChatRequest? value)
        {
            KimiK31Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK31Pro(global::Moonshot.KimiK31ProChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK3ChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK3ChatRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK3ChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK3;

        /// <summary>
        ///
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK3ChatRequest? value)
        {
            KimiK3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK3(global::Moonshot.KimiK3ChatRequest? value) => new CreateChatCompletionsRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateChatCompletionsRequest(global::Moonshot.KimiK27CodeChatRequest value) => new CreateChatCompletionsRequest((global::Moonshot.KimiK27CodeChatRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK27CodeChatRequest?(CreateChatCompletionsRequest @this) => @this.KimiK27Code;

        /// <summary>
        ///
        /// </summary>
        public CreateChatCompletionsRequest(global::Moonshot.KimiK27CodeChatRequest? value)
        {
            KimiK27Code = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateChatCompletionsRequest FromKimiK27Code(global::Moonshot.KimiK27CodeChatRequest? value) => new CreateChatCompletionsRequest(value);

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
        public CreateChatCompletionsRequest(
            global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? model,
            global::Moonshot.KimiK31ProChatRequest? kimiK31Pro,
            global::Moonshot.KimiK3ChatRequest? kimiK3,
            global::Moonshot.KimiK27CodeChatRequest? kimiK27Code,
            global::Moonshot.KimiK26ChatRequest? kimiK26
            )
        {
            Model = model;

            KimiK31Pro = kimiK31Pro;
            KimiK3 = kimiK3;
            KimiK27Code = kimiK27Code;
            KimiK26 = kimiK26;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            KimiK26 as object ??
            KimiK27Code as object ??
            KimiK3 as object ??
            KimiK31Pro as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            KimiK31Pro?.ToString() ??
            KimiK3?.ToString() ??
            KimiK27Code?.ToString() ??
            KimiK26?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsKimiK31Pro && !IsKimiK3 && !IsKimiK27Code && !IsKimiK26 || !IsKimiK31Pro && IsKimiK3 && !IsKimiK27Code && !IsKimiK26 || !IsKimiK31Pro && !IsKimiK3 && IsKimiK27Code && !IsKimiK26 || !IsKimiK31Pro && !IsKimiK3 && !IsKimiK27Code && IsKimiK26;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.KimiK31ProChatRequest?, TResult>? kimiK31Pro = null,
            global::System.Func<global::Moonshot.KimiK3ChatRequest?, TResult>? kimiK3 = null,
            global::System.Func<global::Moonshot.KimiK27CodeChatRequest?, TResult>? kimiK27Code = null,
            global::System.Func<global::Moonshot.KimiK26ChatRequest?, TResult>? kimiK26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (KimiK31Pro is { } __value0 && kimiK31Pro != null)
            {
                return kimiK31Pro(__value0);
            }
            else if (KimiK3 is { } __value1 && kimiK3 != null)
            {
                return kimiK3(__value1);
            }
            else if (KimiK27Code is { } __value2 && kimiK27Code != null)
            {
                return kimiK27Code(__value2);
            }
            else if (KimiK26 is { } __value3 && kimiK26 != null)
            {
                return kimiK26(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.KimiK31ProChatRequest?>? kimiK31Pro = null,

            global::System.Action<global::Moonshot.KimiK3ChatRequest?>? kimiK3 = null,

            global::System.Action<global::Moonshot.KimiK27CodeChatRequest?>? kimiK27Code = null,

            global::System.Action<global::Moonshot.KimiK26ChatRequest?>? kimiK26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (KimiK31Pro is { } __value0)
            {
                kimiK31Pro?.Invoke(__value0);
            }
            else if (KimiK3 is { } __value1)
            {
                kimiK3?.Invoke(__value1);
            }
            else if (KimiK27Code is { } __value2)
            {
                kimiK27Code?.Invoke(__value2);
            }
            else if (KimiK26 is { } __value3)
            {
                kimiK26?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.KimiK31ProChatRequest?>? kimiK31Pro = null,
            global::System.Action<global::Moonshot.KimiK3ChatRequest?>? kimiK3 = null,
            global::System.Action<global::Moonshot.KimiK27CodeChatRequest?>? kimiK27Code = null,
            global::System.Action<global::Moonshot.KimiK26ChatRequest?>? kimiK26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (KimiK31Pro is { } __value0)
            {
                kimiK31Pro?.Invoke(__value0);
            }
            else if (KimiK3 is { } __value1)
            {
                kimiK3?.Invoke(__value1);
            }
            else if (KimiK27Code is { } __value2)
            {
                kimiK27Code?.Invoke(__value2);
            }
            else if (KimiK26 is { } __value3)
            {
                kimiK26?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KimiK31Pro,
                typeof(global::Moonshot.KimiK31ProChatRequest),
                KimiK3,
                typeof(global::Moonshot.KimiK3ChatRequest),
                KimiK27Code,
                typeof(global::Moonshot.KimiK27CodeChatRequest),
                KimiK26,
                typeof(global::Moonshot.KimiK26ChatRequest),
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
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK31ProChatRequest?>.Default.Equals(KimiK31Pro, other.KimiK31Pro) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK3ChatRequest?>.Default.Equals(KimiK3, other.KimiK3) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK27CodeChatRequest?>.Default.Equals(KimiK27Code, other.KimiK27Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK26ChatRequest?>.Default.Equals(KimiK26, other.KimiK26)
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
