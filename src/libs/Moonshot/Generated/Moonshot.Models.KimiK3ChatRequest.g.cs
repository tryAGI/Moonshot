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
        public global::Moonshot.ChatRequestCommon PickCommon() => IsCommon
            ? Common!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Common' but the value was {ToString()}.");

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
        public global::Moonshot.KimiK3ChatRequestVariant2 PickKimiK3ChatRequestVariant2() => IsKimiK3ChatRequestVariant2
            ? KimiK3ChatRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK3ChatRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK3ChatRequest(global::Moonshot.ChatRequestCommon value) => new KimiK3ChatRequest((global::Moonshot.ChatRequestCommon?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestCommon?(KimiK3ChatRequest @this) => @this.Common;

        /// <summary>
        /// 
        /// </summary>
        public KimiK3ChatRequest(global::Moonshot.ChatRequestCommon? value)
        {
            Common = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK3ChatRequest FromCommon(global::Moonshot.ChatRequestCommon? value) => new KimiK3ChatRequest(value);

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
            global::Moonshot.ChatRequestCommon? common,
            global::Moonshot.KimiK3ChatRequestVariant2? kimiK3ChatRequestVariant2
            )
        {
            Common = common;
            KimiK3ChatRequestVariant2 = kimiK3ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KimiK3ChatRequestVariant2 as object ??
            Common as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            KimiK3ChatRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsKimiK3ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestCommon, TResult>? common = null,
            global::System.Func<global::Moonshot.KimiK3ChatRequestVariant2, TResult>? kimiK3ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommon && common != null)
            {
                return common(Common!);
            }
            else if (IsKimiK3ChatRequestVariant2 && kimiK3ChatRequestVariant2 != null)
            {
                return kimiK3ChatRequestVariant2(KimiK3ChatRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestCommon>? common = null,

            global::System.Action<global::Moonshot.KimiK3ChatRequestVariant2>? kimiK3ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommon)
            {
                common?.Invoke(Common!);
            }
            else if (IsKimiK3ChatRequestVariant2)
            {
                kimiK3ChatRequestVariant2?.Invoke(KimiK3ChatRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ChatRequestCommon>? common = null,
            global::System.Action<global::Moonshot.KimiK3ChatRequestVariant2>? kimiK3ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommon)
            {
                common?.Invoke(Common!);
            }
            else if (IsKimiK3ChatRequestVariant2)
            {
                kimiK3ChatRequestVariant2?.Invoke(KimiK3ChatRequestVariant2!);
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
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestCommon?>.Default.Equals(Common, other.Common) &&
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
