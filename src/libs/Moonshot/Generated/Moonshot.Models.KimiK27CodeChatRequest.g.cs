#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct KimiK27CodeChatRequest : global::System.IEquatable<KimiK27CodeChatRequest>
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
        public global::Moonshot.KimiK27CodeChatRequestVariant2? KimiK27CodeChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.KimiK27CodeChatRequestVariant2? KimiK27CodeChatRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KimiK27CodeChatRequestVariant2))]
#endif
        public bool IsKimiK27CodeChatRequestVariant2 => KimiK27CodeChatRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKimiK27CodeChatRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK27CodeChatRequestVariant2? value)
        {
            value = KimiK27CodeChatRequestVariant2;
            return IsKimiK27CodeChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK27CodeChatRequestVariant2 PickKimiK27CodeChatRequestVariant2() => IsKimiK27CodeChatRequestVariant2
            ? KimiK27CodeChatRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KimiK27CodeChatRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK27CodeChatRequest(global::Moonshot.ChatRequestBase value) => new KimiK27CodeChatRequest((global::Moonshot.ChatRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestBase?(KimiK27CodeChatRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public KimiK27CodeChatRequest(global::Moonshot.ChatRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK27CodeChatRequest FromBase(global::Moonshot.ChatRequestBase? value) => new KimiK27CodeChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK27CodeChatRequest(global::Moonshot.KimiK27CodeChatRequestVariant2 value) => new KimiK27CodeChatRequest((global::Moonshot.KimiK27CodeChatRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK27CodeChatRequestVariant2?(KimiK27CodeChatRequest @this) => @this.KimiK27CodeChatRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public KimiK27CodeChatRequest(global::Moonshot.KimiK27CodeChatRequestVariant2? value)
        {
            KimiK27CodeChatRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK27CodeChatRequest FromKimiK27CodeChatRequestVariant2(global::Moonshot.KimiK27CodeChatRequestVariant2? value) => new KimiK27CodeChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public KimiK27CodeChatRequest(
            global::Moonshot.ChatRequestBase? @base,
            global::Moonshot.KimiK27CodeChatRequestVariant2? kimiK27CodeChatRequestVariant2
            )
        {
            Base = @base;
            KimiK27CodeChatRequestVariant2 = kimiK27CodeChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KimiK27CodeChatRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            KimiK27CodeChatRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsKimiK27CodeChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestBase, TResult>? @base = null,
            global::System.Func<global::Moonshot.KimiK27CodeChatRequestVariant2, TResult>? kimiK27CodeChatRequestVariant2 = null,
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
            else if (IsKimiK27CodeChatRequestVariant2 && kimiK27CodeChatRequestVariant2 != null)
            {
                return kimiK27CodeChatRequestVariant2(KimiK27CodeChatRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestBase>? @base = null,

            global::System.Action<global::Moonshot.KimiK27CodeChatRequestVariant2>? kimiK27CodeChatRequestVariant2 = null,
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
            else if (IsKimiK27CodeChatRequestVariant2)
            {
                kimiK27CodeChatRequestVariant2?.Invoke(KimiK27CodeChatRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ChatRequestBase>? @base = null,
            global::System.Action<global::Moonshot.KimiK27CodeChatRequestVariant2>? kimiK27CodeChatRequestVariant2 = null,
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
            else if (IsKimiK27CodeChatRequestVariant2)
            {
                kimiK27CodeChatRequestVariant2?.Invoke(KimiK27CodeChatRequestVariant2!);
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
                KimiK27CodeChatRequestVariant2,
                typeof(global::Moonshot.KimiK27CodeChatRequestVariant2),
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
        public bool Equals(KimiK27CodeChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK27CodeChatRequestVariant2?>.Default.Equals(KimiK27CodeChatRequestVariant2, other.KimiK27CodeChatRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KimiK27CodeChatRequest obj1, KimiK27CodeChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK27CodeChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KimiK27CodeChatRequest obj1, KimiK27CodeChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK27CodeChatRequest o && Equals(o);
        }
    }
}
