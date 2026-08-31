#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A tool definition, discriminated by `type`.
    /// </summary>
    public readonly partial struct ResponsesTool : global::System.IEquatable<ResponsesTool>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A function tool whose arguments are described by a JSON Schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesFunctionTool? Function { get; init; }
#else
        public global::Moonshot.ResponsesFunctionTool? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesFunctionTool? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesFunctionTool PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// Groups a set of function tools under a single namespace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesNamespaceTool? Namespace { get; init; }
#else
        public global::Moonshot.ResponsesNamespaceTool? Namespace { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Namespace))]
#endif
        public bool IsNamespace => Namespace != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNamespace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesNamespaceTool? value)
        {
            value = Namespace;
            return IsNamespace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesNamespaceTool PickNamespace() => IsNamespace
            ? Namespace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Namespace' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesTool(global::Moonshot.ResponsesFunctionTool value) => new ResponsesTool((global::Moonshot.ResponsesFunctionTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesFunctionTool?(ResponsesTool @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ResponsesTool(global::Moonshot.ResponsesFunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesTool FromFunction(global::Moonshot.ResponsesFunctionTool? value) => new ResponsesTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesTool(global::Moonshot.ResponsesNamespaceTool value) => new ResponsesTool((global::Moonshot.ResponsesNamespaceTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesNamespaceTool?(ResponsesTool @this) => @this.Namespace;

        /// <summary>
        ///
        /// </summary>
        public ResponsesTool(global::Moonshot.ResponsesNamespaceTool? value)
        {
            Namespace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesTool FromNamespace(global::Moonshot.ResponsesNamespaceTool? value) => new ResponsesTool(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesTool(
            global::Moonshot.ResponsesToolDiscriminatorType? type,
            global::Moonshot.ResponsesFunctionTool? function,
            global::Moonshot.ResponsesNamespaceTool? @namespace
            )
        {
            Type = type;

            Function = function;
            Namespace = @namespace;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Namespace as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Namespace?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsNamespace || !IsFunction && IsNamespace;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesFunctionTool, TResult>? function = null,
            global::System.Func<global::Moonshot.ResponsesNamespaceTool, TResult>? @namespace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsNamespace && @namespace != null)
            {
                return @namespace(Namespace!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ResponsesFunctionTool>? function = null,

            global::System.Action<global::Moonshot.ResponsesNamespaceTool>? @namespace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsNamespace)
            {
                @namespace?.Invoke(Namespace!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ResponsesFunctionTool>? function = null,
            global::System.Action<global::Moonshot.ResponsesNamespaceTool>? @namespace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsNamespace)
            {
                @namespace?.Invoke(Namespace!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Moonshot.ResponsesFunctionTool),
                Namespace,
                typeof(global::Moonshot.ResponsesNamespaceTool),
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
        public bool Equals(ResponsesTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesFunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesNamespaceTool?>.Default.Equals(Namespace, other.Namespace)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponsesTool obj1, ResponsesTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesTool obj1, ResponsesTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesTool o && Equals(o);
        }
    }
}
