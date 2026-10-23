#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct KimiK31ProChatRequest : global::System.IEquatable<KimiK31ProChatRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK3ChatRequestBase? K3Base { get; init; }
#else
        public global::Moonshot.KimiK3ChatRequestBase? K3Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(K3Base))]
#endif
        public bool IsK3Base => K3Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickK3Base(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK3ChatRequestBase? value)
        {
            value = K3Base;
            return IsK3Base;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestBase PickK3Base() => K3Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'K3Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK31ProChatRequestVariant2? KimiK31ProChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.KimiK31ProChatRequestVariant2? KimiK31ProChatRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK31ProChatRequestVariant2))]
#endif
        public bool IsKimiK31ProChatRequestVariant2 => KimiK31ProChatRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKimiK31ProChatRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK31ProChatRequestVariant2? value)
        {
            value = KimiK31ProChatRequestVariant2;
            return IsKimiK31ProChatRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK31ProChatRequestVariant2 PickKimiK31ProChatRequestVariant2() => KimiK31ProChatRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK31ProChatRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator KimiK31ProChatRequest(global::Moonshot.KimiK3ChatRequestBase value) => new KimiK31ProChatRequest((global::Moonshot.KimiK3ChatRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK3ChatRequestBase?(KimiK31ProChatRequest @this) => @this.K3Base;

        /// <summary>
        ///
        /// </summary>
        public KimiK31ProChatRequest(global::Moonshot.KimiK3ChatRequestBase? value)
        {
            K3Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KimiK31ProChatRequest FromK3Base(global::Moonshot.KimiK3ChatRequestBase? value) => new KimiK31ProChatRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KimiK31ProChatRequest(global::Moonshot.KimiK31ProChatRequestVariant2 value) => new KimiK31ProChatRequest((global::Moonshot.KimiK31ProChatRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK31ProChatRequestVariant2?(KimiK31ProChatRequest @this) => @this.KimiK31ProChatRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public KimiK31ProChatRequest(global::Moonshot.KimiK31ProChatRequestVariant2? value)
        {
            KimiK31ProChatRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KimiK31ProChatRequest FromKimiK31ProChatRequestVariant2(global::Moonshot.KimiK31ProChatRequestVariant2? value) => new KimiK31ProChatRequest(value);

        /// <summary>
        ///
        /// </summary>
        public KimiK31ProChatRequest(
            global::Moonshot.KimiK3ChatRequestBase? k3Base,
            global::Moonshot.KimiK31ProChatRequestVariant2? kimiK31ProChatRequestVariant2
            )
        {
            K3Base = k3Base;
            KimiK31ProChatRequestVariant2 = kimiK31ProChatRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            KimiK31ProChatRequestVariant2 as object ??
            K3Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            K3Base?.ToString() ??
            KimiK31ProChatRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsK3Base && IsKimiK31ProChatRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.KimiK3ChatRequestBase?, TResult>? k3Base = null,
            global::System.Func<global::Moonshot.KimiK31ProChatRequestVariant2, TResult>? kimiK31ProChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (K3Base is { } __value0 && k3Base != null)
            {
                return k3Base(__value0);
            }
            else if (KimiK31ProChatRequestVariant2 is { } __value1 && kimiK31ProChatRequestVariant2 != null)
            {
                return kimiK31ProChatRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.KimiK3ChatRequestBase?>? k3Base = null,

            global::System.Action<global::Moonshot.KimiK31ProChatRequestVariant2>? kimiK31ProChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (K3Base is { } __value0)
            {
                k3Base?.Invoke(__value0);
            }
            else if (KimiK31ProChatRequestVariant2 is { } __value1)
            {
                kimiK31ProChatRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.KimiK3ChatRequestBase?>? k3Base = null,
            global::System.Action<global::Moonshot.KimiK31ProChatRequestVariant2>? kimiK31ProChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (K3Base is { } __value0)
            {
                k3Base?.Invoke(__value0);
            }
            else if (KimiK31ProChatRequestVariant2 is { } __value1)
            {
                kimiK31ProChatRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                K3Base,
                typeof(global::Moonshot.KimiK3ChatRequestBase),
                KimiK31ProChatRequestVariant2,
                typeof(global::Moonshot.KimiK31ProChatRequestVariant2),
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
        public bool Equals(KimiK31ProChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK3ChatRequestBase?>.Default.Equals(K3Base, other.K3Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK31ProChatRequestVariant2?>.Default.Equals(KimiK31ProChatRequestVariant2, other.KimiK31ProChatRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(KimiK31ProChatRequest obj1, KimiK31ProChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK31ProChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KimiK31ProChatRequest obj1, KimiK31ProChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK31ProChatRequest o && Equals(o);
        }
    }
}
