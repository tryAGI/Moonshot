#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct KimiK2ChatRequest : global::System.IEquatable<KimiK2ChatRequest>
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
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ChatRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.ChatRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK2ChatRequestVariant2? KimiK2ChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.KimiK2ChatRequestVariant2? KimiK2ChatRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK2ChatRequestVariant2))]
#endif
        public bool IsKimiK2ChatRequestVariant2 => KimiK2ChatRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKimiK2ChatRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK2ChatRequestVariant2? value)
        {
            value = KimiK2ChatRequestVariant2;
            return IsKimiK2ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK2ChatRequestVariant2 PickKimiK2ChatRequestVariant2() => IsKimiK2ChatRequestVariant2
            ? KimiK2ChatRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK2ChatRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK2ChatRequest(global::Moonshot.ChatRequestBase value) => new KimiK2ChatRequest((global::Moonshot.ChatRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestBase?(KimiK2ChatRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public KimiK2ChatRequest(global::Moonshot.ChatRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK2ChatRequest FromBase(global::Moonshot.ChatRequestBase? value) => new KimiK2ChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK2ChatRequest(global::Moonshot.KimiK2ChatRequestVariant2 value) => new KimiK2ChatRequest((global::Moonshot.KimiK2ChatRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK2ChatRequestVariant2?(KimiK2ChatRequest @this) => @this.KimiK2ChatRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public KimiK2ChatRequest(global::Moonshot.KimiK2ChatRequestVariant2? value)
        {
            KimiK2ChatRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK2ChatRequest FromKimiK2ChatRequestVariant2(global::Moonshot.KimiK2ChatRequestVariant2? value) => new KimiK2ChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public KimiK2ChatRequest(
            global::Moonshot.ChatRequestBase? @base,
            global::Moonshot.KimiK2ChatRequestVariant2? kimiK2ChatRequestVariant2
            )
        {
            Base = @base;
            KimiK2ChatRequestVariant2 = kimiK2ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KimiK2ChatRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            KimiK2ChatRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsKimiK2ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestBase, TResult>? @base = null,
            global::System.Func<global::Moonshot.KimiK2ChatRequestVariant2, TResult>? kimiK2ChatRequestVariant2 = null,
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
            else if (IsKimiK2ChatRequestVariant2 && kimiK2ChatRequestVariant2 != null)
            {
                return kimiK2ChatRequestVariant2(KimiK2ChatRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestBase>? @base = null,

            global::System.Action<global::Moonshot.KimiK2ChatRequestVariant2>? kimiK2ChatRequestVariant2 = null,
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
            else if (IsKimiK2ChatRequestVariant2)
            {
                kimiK2ChatRequestVariant2?.Invoke(KimiK2ChatRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ChatRequestBase>? @base = null,
            global::System.Action<global::Moonshot.KimiK2ChatRequestVariant2>? kimiK2ChatRequestVariant2 = null,
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
            else if (IsKimiK2ChatRequestVariant2)
            {
                kimiK2ChatRequestVariant2?.Invoke(KimiK2ChatRequestVariant2!);
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
                KimiK2ChatRequestVariant2,
                typeof(global::Moonshot.KimiK2ChatRequestVariant2),
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
        public bool Equals(KimiK2ChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK2ChatRequestVariant2?>.Default.Equals(KimiK2ChatRequestVariant2, other.KimiK2ChatRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KimiK2ChatRequest obj1, KimiK2ChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK2ChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KimiK2ChatRequest obj1, KimiK2ChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK2ChatRequest o && Equals(o);
        }
    }
}
