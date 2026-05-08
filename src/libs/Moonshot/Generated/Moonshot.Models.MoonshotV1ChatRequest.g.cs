#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MoonshotV1ChatRequest : global::System.IEquatable<MoonshotV1ChatRequest>
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
#if NET6_0_OR_GREATER
        public global::Moonshot.MoonshotV1ChatRequestVariant2? MoonshotV1ChatRequestVariant2 { get; init; }
#else
        public global::Moonshot.MoonshotV1ChatRequestVariant2? MoonshotV1ChatRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MoonshotV1ChatRequestVariant2))]
#endif
        public bool IsMoonshotV1ChatRequestVariant2 => MoonshotV1ChatRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMoonshotV1ChatRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MoonshotV1ChatRequestVariant2? value)
        {
            value = MoonshotV1ChatRequestVariant2;
            return IsMoonshotV1ChatRequestVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MoonshotV1ChatRequest(global::Moonshot.ChatRequestBase value) => new MoonshotV1ChatRequest((global::Moonshot.ChatRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.ChatRequestBase?(MoonshotV1ChatRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public MoonshotV1ChatRequest(global::Moonshot.ChatRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MoonshotV1ChatRequest(global::Moonshot.MoonshotV1ChatRequestVariant2 value) => new MoonshotV1ChatRequest((global::Moonshot.MoonshotV1ChatRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.MoonshotV1ChatRequestVariant2?(MoonshotV1ChatRequest @this) => @this.MoonshotV1ChatRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MoonshotV1ChatRequest(global::Moonshot.MoonshotV1ChatRequestVariant2? value)
        {
            MoonshotV1ChatRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MoonshotV1ChatRequest(
            global::Moonshot.ChatRequestBase? @base,
            global::Moonshot.MoonshotV1ChatRequestVariant2? moonshotV1ChatRequestVariant2
            )
        {
            Base = @base;
            MoonshotV1ChatRequestVariant2 = moonshotV1ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MoonshotV1ChatRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            MoonshotV1ChatRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMoonshotV1ChatRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ChatRequestBase, TResult>? @base = null,
            global::System.Func<global::Moonshot.MoonshotV1ChatRequestVariant2, TResult>? moonshotV1ChatRequestVariant2 = null,
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
            else if (IsMoonshotV1ChatRequestVariant2 && moonshotV1ChatRequestVariant2 != null)
            {
                return moonshotV1ChatRequestVariant2(MoonshotV1ChatRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ChatRequestBase>? @base = null,

            global::System.Action<global::Moonshot.MoonshotV1ChatRequestVariant2>? moonshotV1ChatRequestVariant2 = null,
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
            else if (IsMoonshotV1ChatRequestVariant2)
            {
                moonshotV1ChatRequestVariant2?.Invoke(MoonshotV1ChatRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ChatRequestBase>? @base = null,
            global::System.Action<global::Moonshot.MoonshotV1ChatRequestVariant2>? moonshotV1ChatRequestVariant2 = null,
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
            else if (IsMoonshotV1ChatRequestVariant2)
            {
                moonshotV1ChatRequestVariant2?.Invoke(MoonshotV1ChatRequestVariant2!);
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
                MoonshotV1ChatRequestVariant2,
                typeof(global::Moonshot.MoonshotV1ChatRequestVariant2),
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
        public bool Equals(MoonshotV1ChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ChatRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MoonshotV1ChatRequestVariant2?>.Default.Equals(MoonshotV1ChatRequestVariant2, other.MoonshotV1ChatRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MoonshotV1ChatRequest obj1, MoonshotV1ChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MoonshotV1ChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MoonshotV1ChatRequest obj1, MoonshotV1ChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MoonshotV1ChatRequest o && Equals(o);
        }
    }
}
