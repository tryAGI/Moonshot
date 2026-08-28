#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Streaming events. Each SSE frame's `event` matches `data.type`; the order is message_start → (content_block_start → content_block_delta… → content_block_stop)… → message_delta → message_stop.
    /// </summary>
    public readonly partial struct MessagesStreamEvent : global::System.IEquatable<MessagesStreamEvent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MessagesStreamEventMessageStart? MessageStart { get; init; }
#else
        public global::Moonshot.MessagesStreamEventMessageStart? MessageStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStart))]
#endif
        public bool IsMessageStart => MessageStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessageStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MessagesStreamEventMessageStart? value)
        {
            value = MessageStart;
            return IsMessageStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStart PickMessageStart() => IsMessageStart
            ? MessageStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessageStart' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MessagesStreamEventContentBlockStart? ContentBlockStart { get; init; }
#else
        public global::Moonshot.MessagesStreamEventContentBlockStart? ContentBlockStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStart))]
#endif
        public bool IsContentBlockStart => ContentBlockStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MessagesStreamEventContentBlockStart? value)
        {
            value = ContentBlockStart;
            return IsContentBlockStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStart PickContentBlockStart() => IsContentBlockStart
            ? ContentBlockStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockStart' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MessagesStreamEventContentBlockDelta? ContentBlockDelta { get; init; }
#else
        public global::Moonshot.MessagesStreamEventContentBlockDelta? ContentBlockDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockDelta))]
#endif
        public bool IsContentBlockDelta => ContentBlockDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MessagesStreamEventContentBlockDelta? value)
        {
            value = ContentBlockDelta;
            return IsContentBlockDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockDelta PickContentBlockDelta() => IsContentBlockDelta
            ? ContentBlockDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MessagesStreamEventContentBlockStop? ContentBlockStop { get; init; }
#else
        public global::Moonshot.MessagesStreamEventContentBlockStop? ContentBlockStop { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStop))]
#endif
        public bool IsContentBlockStop => ContentBlockStop != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MessagesStreamEventContentBlockStop? value)
        {
            value = ContentBlockStop;
            return IsContentBlockStop;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventContentBlockStop PickContentBlockStop() => IsContentBlockStop
            ? ContentBlockStop!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockStop' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MessagesStreamEventMessageDelta? MessageDelta { get; init; }
#else
        public global::Moonshot.MessagesStreamEventMessageDelta? MessageDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDelta))]
#endif
        public bool IsMessageDelta => MessageDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessageDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MessagesStreamEventMessageDelta? value)
        {
            value = MessageDelta;
            return IsMessageDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageDelta PickMessageDelta() => IsMessageDelta
            ? MessageDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessageDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.MessagesStreamEventMessageStop? MessageStop { get; init; }
#else
        public global::Moonshot.MessagesStreamEventMessageStop? MessageStop { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStop))]
#endif
        public bool IsMessageStop => MessageStop != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessageStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.MessagesStreamEventMessageStop? value)
        {
            value = MessageStop;
            return IsMessageStop;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.MessagesStreamEventMessageStop PickMessageStop() => IsMessageStop
            ? MessageStop!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessageStop' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvent(global::Moonshot.MessagesStreamEventMessageStart value) => new MessagesStreamEvent((global::Moonshot.MessagesStreamEventMessageStart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.MessagesStreamEventMessageStart?(MessagesStreamEvent @this) => @this.MessageStart;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(global::Moonshot.MessagesStreamEventMessageStart? value)
        {
            MessageStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvent FromMessageStart(global::Moonshot.MessagesStreamEventMessageStart? value) => new MessagesStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvent(global::Moonshot.MessagesStreamEventContentBlockStart value) => new MessagesStreamEvent((global::Moonshot.MessagesStreamEventContentBlockStart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.MessagesStreamEventContentBlockStart?(MessagesStreamEvent @this) => @this.ContentBlockStart;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(global::Moonshot.MessagesStreamEventContentBlockStart? value)
        {
            ContentBlockStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvent FromContentBlockStart(global::Moonshot.MessagesStreamEventContentBlockStart? value) => new MessagesStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvent(global::Moonshot.MessagesStreamEventContentBlockDelta value) => new MessagesStreamEvent((global::Moonshot.MessagesStreamEventContentBlockDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.MessagesStreamEventContentBlockDelta?(MessagesStreamEvent @this) => @this.ContentBlockDelta;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(global::Moonshot.MessagesStreamEventContentBlockDelta? value)
        {
            ContentBlockDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvent FromContentBlockDelta(global::Moonshot.MessagesStreamEventContentBlockDelta? value) => new MessagesStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvent(global::Moonshot.MessagesStreamEventContentBlockStop value) => new MessagesStreamEvent((global::Moonshot.MessagesStreamEventContentBlockStop?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.MessagesStreamEventContentBlockStop?(MessagesStreamEvent @this) => @this.ContentBlockStop;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(global::Moonshot.MessagesStreamEventContentBlockStop? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvent FromContentBlockStop(global::Moonshot.MessagesStreamEventContentBlockStop? value) => new MessagesStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvent(global::Moonshot.MessagesStreamEventMessageDelta value) => new MessagesStreamEvent((global::Moonshot.MessagesStreamEventMessageDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.MessagesStreamEventMessageDelta?(MessagesStreamEvent @this) => @this.MessageDelta;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(global::Moonshot.MessagesStreamEventMessageDelta? value)
        {
            MessageDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvent FromMessageDelta(global::Moonshot.MessagesStreamEventMessageDelta? value) => new MessagesStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvent(global::Moonshot.MessagesStreamEventMessageStop value) => new MessagesStreamEvent((global::Moonshot.MessagesStreamEventMessageStop?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.MessagesStreamEventMessageStop?(MessagesStreamEvent @this) => @this.MessageStop;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(global::Moonshot.MessagesStreamEventMessageStop? value)
        {
            MessageStop = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvent FromMessageStop(global::Moonshot.MessagesStreamEventMessageStop? value) => new MessagesStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvent(
            global::Moonshot.MessagesStreamEventMessageStart? messageStart,
            global::Moonshot.MessagesStreamEventContentBlockStart? contentBlockStart,
            global::Moonshot.MessagesStreamEventContentBlockDelta? contentBlockDelta,
            global::Moonshot.MessagesStreamEventContentBlockStop? contentBlockStop,
            global::Moonshot.MessagesStreamEventMessageDelta? messageDelta,
            global::Moonshot.MessagesStreamEventMessageStop? messageStop
            )
        {
            MessageStart = messageStart;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
            MessageDelta = messageDelta;
            MessageStop = messageStop;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MessageStop as object ??
            MessageDelta as object ??
            ContentBlockStop as object ??
            ContentBlockDelta as object ??
            ContentBlockStart as object ??
            MessageStart as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MessageStart?.ToString() ??
            ContentBlockStart?.ToString() ??
            ContentBlockDelta?.ToString() ??
            ContentBlockStop?.ToString() ??
            MessageDelta?.ToString() ??
            MessageStop?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsMessageDelta && !IsMessageStop || !IsMessageStart && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsMessageDelta && !IsMessageStop || !IsMessageStart && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsMessageDelta && !IsMessageStop || !IsMessageStart && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsMessageDelta && !IsMessageStop || !IsMessageStart && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsMessageDelta && !IsMessageStop || !IsMessageStart && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsMessageDelta && IsMessageStop;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.MessagesStreamEventMessageStart, TResult>? messageStart = null,
            global::System.Func<global::Moonshot.MessagesStreamEventContentBlockStart, TResult>? contentBlockStart = null,
            global::System.Func<global::Moonshot.MessagesStreamEventContentBlockDelta, TResult>? contentBlockDelta = null,
            global::System.Func<global::Moonshot.MessagesStreamEventContentBlockStop, TResult>? contentBlockStop = null,
            global::System.Func<global::Moonshot.MessagesStreamEventMessageDelta, TResult>? messageDelta = null,
            global::System.Func<global::Moonshot.MessagesStreamEventMessageStop, TResult>? messageStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart && messageStart != null)
            {
                return messageStart(MessageStart!);
            }
            else if (IsContentBlockStart && contentBlockStart != null)
            {
                return contentBlockStart(ContentBlockStart!);
            }
            else if (IsContentBlockDelta && contentBlockDelta != null)
            {
                return contentBlockDelta(ContentBlockDelta!);
            }
            else if (IsContentBlockStop && contentBlockStop != null)
            {
                return contentBlockStop(ContentBlockStop!);
            }
            else if (IsMessageDelta && messageDelta != null)
            {
                return messageDelta(MessageDelta!);
            }
            else if (IsMessageStop && messageStop != null)
            {
                return messageStop(MessageStop!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.MessagesStreamEventMessageStart>? messageStart = null,

            global::System.Action<global::Moonshot.MessagesStreamEventContentBlockStart>? contentBlockStart = null,

            global::System.Action<global::Moonshot.MessagesStreamEventContentBlockDelta>? contentBlockDelta = null,

            global::System.Action<global::Moonshot.MessagesStreamEventContentBlockStop>? contentBlockStop = null,

            global::System.Action<global::Moonshot.MessagesStreamEventMessageDelta>? messageDelta = null,

            global::System.Action<global::Moonshot.MessagesStreamEventMessageStop>? messageStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart)
            {
                messageStart?.Invoke(MessageStart!);
            }
            else if (IsContentBlockStart)
            {
                contentBlockStart?.Invoke(ContentBlockStart!);
            }
            else if (IsContentBlockDelta)
            {
                contentBlockDelta?.Invoke(ContentBlockDelta!);
            }
            else if (IsContentBlockStop)
            {
                contentBlockStop?.Invoke(ContentBlockStop!);
            }
            else if (IsMessageDelta)
            {
                messageDelta?.Invoke(MessageDelta!);
            }
            else if (IsMessageStop)
            {
                messageStop?.Invoke(MessageStop!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.MessagesStreamEventMessageStart>? messageStart = null,
            global::System.Action<global::Moonshot.MessagesStreamEventContentBlockStart>? contentBlockStart = null,
            global::System.Action<global::Moonshot.MessagesStreamEventContentBlockDelta>? contentBlockDelta = null,
            global::System.Action<global::Moonshot.MessagesStreamEventContentBlockStop>? contentBlockStop = null,
            global::System.Action<global::Moonshot.MessagesStreamEventMessageDelta>? messageDelta = null,
            global::System.Action<global::Moonshot.MessagesStreamEventMessageStop>? messageStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart)
            {
                messageStart?.Invoke(MessageStart!);
            }
            else if (IsContentBlockStart)
            {
                contentBlockStart?.Invoke(ContentBlockStart!);
            }
            else if (IsContentBlockDelta)
            {
                contentBlockDelta?.Invoke(ContentBlockDelta!);
            }
            else if (IsContentBlockStop)
            {
                contentBlockStop?.Invoke(ContentBlockStop!);
            }
            else if (IsMessageDelta)
            {
                messageDelta?.Invoke(MessageDelta!);
            }
            else if (IsMessageStop)
            {
                messageStop?.Invoke(MessageStop!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStart,
                typeof(global::Moonshot.MessagesStreamEventMessageStart),
                ContentBlockStart,
                typeof(global::Moonshot.MessagesStreamEventContentBlockStart),
                ContentBlockDelta,
                typeof(global::Moonshot.MessagesStreamEventContentBlockDelta),
                ContentBlockStop,
                typeof(global::Moonshot.MessagesStreamEventContentBlockStop),
                MessageDelta,
                typeof(global::Moonshot.MessagesStreamEventMessageDelta),
                MessageStop,
                typeof(global::Moonshot.MessagesStreamEventMessageStop),
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
        public bool Equals(MessagesStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MessagesStreamEventMessageStart?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MessagesStreamEventContentBlockStart?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MessagesStreamEventContentBlockDelta?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MessagesStreamEventContentBlockStop?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MessagesStreamEventMessageDelta?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.MessagesStreamEventMessageStop?>.Default.Equals(MessageStop, other.MessageStop)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MessagesStreamEvent obj1, MessagesStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesStreamEvent obj1, MessagesStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesStreamEvent o && Equals(o);
        }
    }
}
