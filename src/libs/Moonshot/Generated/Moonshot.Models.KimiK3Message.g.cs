#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A Kimi K3 conversation message. Supports both standard messages and system messages that omit content and declare dynamically loaded tools through tools.
    /// </summary>
    public readonly partial struct KimiK3Message : global::System.IEquatable<KimiK3Message>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.Message? StandardMessage { get; init; }
#else
        public global::Moonshot.Message? StandardMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StandardMessage))]
#endif
        public bool IsStandardMessage => StandardMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStandardMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.Message? value)
        {
            value = StandardMessage;
            return IsStandardMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.Message PickStandardMessage() => IsStandardMessage
            ? StandardMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StandardMessage' but the value was {ToString()}.");

        /// <summary>
        /// A Kimi K3 dynamic tool loading message. This message must use the system role, declares tools available to subsequent conversation turns from its position, and does not include a content field.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.KimiK3DynamicToolMessage? DynamicToolMessage { get; init; }
#else
        public global::Moonshot.KimiK3DynamicToolMessage? DynamicToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicToolMessage))]
#endif
        public bool IsDynamicToolMessage => DynamicToolMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicToolMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.KimiK3DynamicToolMessage? value)
        {
            value = DynamicToolMessage;
            return IsDynamicToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Moonshot.KimiK3DynamicToolMessage PickDynamicToolMessage() => IsDynamicToolMessage
            ? DynamicToolMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicToolMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK3Message(global::Moonshot.Message value) => new KimiK3Message((global::Moonshot.Message?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.Message?(KimiK3Message @this) => @this.StandardMessage;

        /// <summary>
        /// 
        /// </summary>
        public KimiK3Message(global::Moonshot.Message? value)
        {
            StandardMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK3Message FromStandardMessage(global::Moonshot.Message? value) => new KimiK3Message(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KimiK3Message(global::Moonshot.KimiK3DynamicToolMessage value) => new KimiK3Message((global::Moonshot.KimiK3DynamicToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Moonshot.KimiK3DynamicToolMessage?(KimiK3Message @this) => @this.DynamicToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public KimiK3Message(global::Moonshot.KimiK3DynamicToolMessage? value)
        {
            DynamicToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static KimiK3Message FromDynamicToolMessage(global::Moonshot.KimiK3DynamicToolMessage? value) => new KimiK3Message(value);

        /// <summary>
        /// 
        /// </summary>
        public KimiK3Message(
            global::Moonshot.Message? standardMessage,
            global::Moonshot.KimiK3DynamicToolMessage? dynamicToolMessage
            )
        {
            StandardMessage = standardMessage;
            DynamicToolMessage = dynamicToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicToolMessage as object ??
            StandardMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StandardMessage?.ToString() ??
            DynamicToolMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStandardMessage && !IsDynamicToolMessage || !IsStandardMessage && IsDynamicToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.Message, TResult>? standardMessage = null,
            global::System.Func<global::Moonshot.KimiK3DynamicToolMessage, TResult>? dynamicToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardMessage && standardMessage != null)
            {
                return standardMessage(StandardMessage!);
            }
            else if (IsDynamicToolMessage && dynamicToolMessage != null)
            {
                return dynamicToolMessage(DynamicToolMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.Message>? standardMessage = null,

            global::System.Action<global::Moonshot.KimiK3DynamicToolMessage>? dynamicToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardMessage)
            {
                standardMessage?.Invoke(StandardMessage!);
            }
            else if (IsDynamicToolMessage)
            {
                dynamicToolMessage?.Invoke(DynamicToolMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.Message>? standardMessage = null,
            global::System.Action<global::Moonshot.KimiK3DynamicToolMessage>? dynamicToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardMessage)
            {
                standardMessage?.Invoke(StandardMessage!);
            }
            else if (IsDynamicToolMessage)
            {
                dynamicToolMessage?.Invoke(DynamicToolMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StandardMessage,
                typeof(global::Moonshot.Message),
                DynamicToolMessage,
                typeof(global::Moonshot.KimiK3DynamicToolMessage),
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
        public bool Equals(KimiK3Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.Message?>.Default.Equals(StandardMessage, other.StandardMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.KimiK3DynamicToolMessage?>.Default.Equals(DynamicToolMessage, other.DynamicToolMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KimiK3Message obj1, KimiK3Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KimiK3Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KimiK3Message obj1, KimiK3Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KimiK3Message o && Equals(o);
        }
    }
}
