#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct KimiK2ThinkingChatRequest : global::System.IEquatable<KimiK2ThinkingChatRequest>
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
        public global::Moonshot.KimiK2ThinkingChatRequestVariant2? KimiK2ThinkingChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.KimiK2ThinkingChatRequestVariant2? KimiK2ThinkingChatRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK2ThinkingChatRequestVariant2))]
#endif
        public bool IsKimiK2ThinkingChatRequestVariant2 => KimiK2ThinkingChatRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK2ThinkingChatRequest(global::Moonshot.ChatRequestBase value) => new KimiK2ThinkingChatRequest((global::Moonshot.ChatRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestBase?(KimiK2ThinkingChatRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public KimiK2ThinkingChatRequest(global::Moonshot.ChatRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK2ThinkingChatRequest(global::Moonshot.KimiK2ThinkingChatRequestVariant2 value) => new KimiK2ThinkingChatRequest((global::Moonshot.KimiK2ThinkingChatRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK2ThinkingChatRequestVariant2?(KimiK2ThinkingChatRequest @this) => @this.KimiK2ThinkingChatRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public KimiK2ThinkingChatRequest(global::Moonshot.KimiK2ThinkingChatRequestVariant2? value)
        {
            KimiK2ThinkingChatRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public KimiK2ThinkingChatRequest(
            global::Moonshot.ChatRequestBase? @base,
            global::Moonshot.KimiK2ThinkingChatRequestVariant2? kimiK2ThinkingChatRequestVariant2
            )
        {
            Base = @base;
            KimiK2ThinkingChatRequestVariant2 = kimiK2ThinkingChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KimiK2ThinkingChatRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            KimiK2ThinkingChatRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsKimiK2ThinkingChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestBase?, TResult>? @base = null,
            global::System.Func<global::Moonshot.KimiK2ThinkingChatRequestVariant2?, TResult>? kimiK2ThinkingChatRequestVariant2 = null,
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
            else if (IsKimiK2ThinkingChatRequestVariant2 && kimiK2ThinkingChatRequestVariant2 != null)
            {
                return kimiK2ThinkingChatRequestVariant2(KimiK2ThinkingChatRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestBase?>? @base = null,
            global::System.Action<global::Moonshot.KimiK2ThinkingChatRequestVariant2?>? kimiK2ThinkingChatRequestVariant2 = null,
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
            else if (IsKimiK2ThinkingChatRequestVariant2)
            {
                kimiK2ThinkingChatRequestVariant2?.Invoke(KimiK2ThinkingChatRequestVariant2!);
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
                KimiK2ThinkingChatRequestVariant2,
                typeof(global::Moonshot.KimiK2ThinkingChatRequestVariant2),
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
        public bool Equals(KimiK2ThinkingChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK2ThinkingChatRequestVariant2?>.Default.Equals(KimiK2ThinkingChatRequestVariant2, other.KimiK2ThinkingChatRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KimiK2ThinkingChatRequest obj1, KimiK2ThinkingChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK2ThinkingChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KimiK2ThinkingChatRequest obj1, KimiK2ThinkingChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK2ThinkingChatRequest o && Equals(o);
        }
    }
}
