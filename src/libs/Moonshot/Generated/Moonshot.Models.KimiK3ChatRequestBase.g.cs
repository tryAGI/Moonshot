#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct KimiK3ChatRequestBase : global::System.IEquatable<KimiK3ChatRequestBase>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ChatRequestCommon? Common { get; init; }
#else
        public global::Moonshot.ChatRequestCommon? Common { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Common))]
#endif
        public bool IsCommon => Common != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ChatRequestCommon? value)
        {
            value = Common;
            return IsCommon;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ChatRequestCommon PickCommon() => Common is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Common' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK3ChatRequestBaseVariant2? KimiK3ChatRequestBaseVariant2 { get; init; }
#else
        public global::Moonshot.KimiK3ChatRequestBaseVariant2? KimiK3ChatRequestBaseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK3ChatRequestBaseVariant2))]
#endif
        public bool IsKimiK3ChatRequestBaseVariant2 => KimiK3ChatRequestBaseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKimiK3ChatRequestBaseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK3ChatRequestBaseVariant2? value)
        {
            value = KimiK3ChatRequestBaseVariant2;
            return IsKimiK3ChatRequestBaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.KimiK3ChatRequestBaseVariant2 PickKimiK3ChatRequestBaseVariant2() => KimiK3ChatRequestBaseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK3ChatRequestBaseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator KimiK3ChatRequestBase(global::Moonshot.ChatRequestCommon value) => new KimiK3ChatRequestBase((global::Moonshot.ChatRequestCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestCommon?(KimiK3ChatRequestBase @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public KimiK3ChatRequestBase(global::Moonshot.ChatRequestCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KimiK3ChatRequestBase FromCommon(global::Moonshot.ChatRequestCommon? value) => new KimiK3ChatRequestBase(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KimiK3ChatRequestBase(global::Moonshot.KimiK3ChatRequestBaseVariant2 value) => new KimiK3ChatRequestBase((global::Moonshot.KimiK3ChatRequestBaseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.KimiK3ChatRequestBaseVariant2?(KimiK3ChatRequestBase @this) => @this.KimiK3ChatRequestBaseVariant2;

        /// <summary>
        ///
        /// </summary>
        public KimiK3ChatRequestBase(global::Moonshot.KimiK3ChatRequestBaseVariant2? value)
        {
            KimiK3ChatRequestBaseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KimiK3ChatRequestBase FromKimiK3ChatRequestBaseVariant2(global::Moonshot.KimiK3ChatRequestBaseVariant2? value) => new KimiK3ChatRequestBase(value);

        /// <summary>
        ///
        /// </summary>
        public KimiK3ChatRequestBase(
            global::Moonshot.ChatRequestCommon? common,
            global::Moonshot.KimiK3ChatRequestBaseVariant2? kimiK3ChatRequestBaseVariant2
            )
        {
            Common = common;
            KimiK3ChatRequestBaseVariant2 = kimiK3ChatRequestBaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            KimiK3ChatRequestBaseVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            KimiK3ChatRequestBaseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsKimiK3ChatRequestBaseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestCommon, TResult>? common = null,
            global::System.Func<global::Moonshot.KimiK3ChatRequestBaseVariant2, TResult>? kimiK3ChatRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0 && common != null)
            {
                return common(__value0);
            }
            else if (KimiK3ChatRequestBaseVariant2 is { } __value1 && kimiK3ChatRequestBaseVariant2 != null)
            {
                return kimiK3ChatRequestBaseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestCommon>? common = null,

            global::System.Action<global::Moonshot.KimiK3ChatRequestBaseVariant2>? kimiK3ChatRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0)
            {
                common?.Invoke(__value0);
            }
            else if (KimiK3ChatRequestBaseVariant2 is { } __value1)
            {
                kimiK3ChatRequestBaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ChatRequestCommon>? common = null,
            global::System.Action<global::Moonshot.KimiK3ChatRequestBaseVariant2>? kimiK3ChatRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0)
            {
                common?.Invoke(__value0);
            }
            else if (KimiK3ChatRequestBaseVariant2 is { } __value1)
            {
                kimiK3ChatRequestBaseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Common,
                typeof(global::Moonshot.ChatRequestCommon),
                KimiK3ChatRequestBaseVariant2,
                typeof(global::Moonshot.KimiK3ChatRequestBaseVariant2),
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
        public bool Equals(KimiK3ChatRequestBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK3ChatRequestBaseVariant2?>.Default.Equals(KimiK3ChatRequestBaseVariant2, other.KimiK3ChatRequestBaseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(KimiK3ChatRequestBase obj1, KimiK3ChatRequestBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK3ChatRequestBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KimiK3ChatRequestBase obj1, KimiK3ChatRequestBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK3ChatRequestBase o && Equals(o);
        }
    }
}
