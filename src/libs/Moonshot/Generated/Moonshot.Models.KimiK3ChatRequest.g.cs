#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct KimiK3ChatRequest : global::System.IEquatable<KimiK3ChatRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK3ChatRequestBase? Base { get; init; }
#else
        public global::Moonshot.KimiK3ChatRequestBase? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK3ChatRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestBase PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK3ChatRequestVariant2? KimiK3ChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.KimiK3ChatRequestVariant2? KimiK3ChatRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK3ChatRequestVariant2))]
#endif
        public bool IsKimiK3ChatRequestVariant2 => KimiK3ChatRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKimiK3ChatRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK3ChatRequestVariant2? value)
        {
            value = KimiK3ChatRequestVariant2;
            return IsKimiK3ChatRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestVariant2 PickKimiK3ChatRequestVariant2() => KimiK3ChatRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK3ChatRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator KimiK3ChatRequest(global::Moonshot.KimiK3ChatRequestBase value) => new KimiK3ChatRequest((global::Moonshot.KimiK3ChatRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK3ChatRequestBase?(KimiK3ChatRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public KimiK3ChatRequest(global::Moonshot.KimiK3ChatRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KimiK3ChatRequest FromBase(global::Moonshot.KimiK3ChatRequestBase? value) => new KimiK3ChatRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KimiK3ChatRequest(global::Moonshot.KimiK3ChatRequestVariant2 value) => new KimiK3ChatRequest((global::Moonshot.KimiK3ChatRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK3ChatRequestVariant2?(KimiK3ChatRequest @this) => @this.KimiK3ChatRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public KimiK3ChatRequest(global::Moonshot.KimiK3ChatRequestVariant2? value)
        {
            KimiK3ChatRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KimiK3ChatRequest FromKimiK3ChatRequestVariant2(global::Moonshot.KimiK3ChatRequestVariant2? value) => new KimiK3ChatRequest(value);

        /// <summary>
        ///
        /// </summary>
        public KimiK3ChatRequest(
            global::Moonshot.KimiK3ChatRequestBase? @base,
            global::Moonshot.KimiK3ChatRequestVariant2? kimiK3ChatRequestVariant2
            )
        {
            Base = @base;
            KimiK3ChatRequestVariant2 = kimiK3ChatRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            KimiK3ChatRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            KimiK3ChatRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsKimiK3ChatRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.KimiK3ChatRequestBase?, TResult>? @base = null,
            global::System.Func<global::Moonshot.KimiK3ChatRequestVariant2, TResult>? kimiK3ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (KimiK3ChatRequestVariant2 is { } __value1 && kimiK3ChatRequestVariant2 != null)
            {
                return kimiK3ChatRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.KimiK3ChatRequestBase?>? @base = null,

            global::System.Action<global::Moonshot.KimiK3ChatRequestVariant2>? kimiK3ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (KimiK3ChatRequestVariant2 is { } __value1)
            {
                kimiK3ChatRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.KimiK3ChatRequestBase?>? @base = null,
            global::System.Action<global::Moonshot.KimiK3ChatRequestVariant2>? kimiK3ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (KimiK3ChatRequestVariant2 is { } __value1)
            {
                kimiK3ChatRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Moonshot.KimiK3ChatRequestBase),
                KimiK3ChatRequestVariant2,
                typeof(global::Moonshot.KimiK3ChatRequestVariant2),
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
        public bool Equals(KimiK3ChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK3ChatRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK3ChatRequestVariant2?>.Default.Equals(KimiK3ChatRequestVariant2, other.KimiK3ChatRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(KimiK3ChatRequest obj1, KimiK3ChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK3ChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KimiK3ChatRequest obj1, KimiK3ChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK3ChatRequest o && Equals(o);
        }
    }
}
