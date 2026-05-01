#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct KimiK26ChatRequest : global::System.IEquatable<KimiK26ChatRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ChatRequestBase? Base { get; init; }
#else
        public global::Moonshot.ChatRequestBase? Base { get; }
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
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK26ChatRequestVariant2? KimiK26ChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.KimiK26ChatRequestVariant2? KimiK26ChatRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK26ChatRequestVariant2))]
#endif
        public bool IsKimiK26ChatRequestVariant2 => KimiK26ChatRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK26ChatRequest(global::Moonshot.ChatRequestBase value) => new KimiK26ChatRequest((global::Moonshot.ChatRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestBase?(KimiK26ChatRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public KimiK26ChatRequest(global::Moonshot.ChatRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK26ChatRequest(global::Moonshot.KimiK26ChatRequestVariant2 value) => new KimiK26ChatRequest((global::Moonshot.KimiK26ChatRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK26ChatRequestVariant2?(KimiK26ChatRequest @this) => @this.KimiK26ChatRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public KimiK26ChatRequest(global::Moonshot.KimiK26ChatRequestVariant2? value)
        {
            KimiK26ChatRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public KimiK26ChatRequest(
            global::Moonshot.ChatRequestBase? @base,
            global::Moonshot.KimiK26ChatRequestVariant2? kimiK26ChatRequestVariant2
            )
        {
            Base = @base;
            KimiK26ChatRequestVariant2 = kimiK26ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KimiK26ChatRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            KimiK26ChatRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsKimiK26ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestBase?, TResult>? @base = null,
            global::System.Func<global::Moonshot.KimiK26ChatRequestVariant2?, TResult>? kimiK26ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsKimiK26ChatRequestVariant2 && kimiK26ChatRequestVariant2 != null)
            {
                return kimiK26ChatRequestVariant2(KimiK26ChatRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestBase?>? @base = null,
            global::System.Action<global::Moonshot.KimiK26ChatRequestVariant2?>? kimiK26ChatRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsKimiK26ChatRequestVariant2)
            {
                kimiK26ChatRequestVariant2?.Invoke(KimiK26ChatRequestVariant2!);
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
                typeof(global::Moonshot.ChatRequestBase),
                KimiK26ChatRequestVariant2,
                typeof(global::Moonshot.KimiK26ChatRequestVariant2),
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
        public bool Equals(KimiK26ChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK26ChatRequestVariant2?>.Default.Equals(KimiK26ChatRequestVariant2, other.KimiK26ChatRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KimiK26ChatRequest obj1, KimiK26ChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK26ChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KimiK26ChatRequest obj1, KimiK26ChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK26ChatRequest o && Equals(o);
        }
    }
}
