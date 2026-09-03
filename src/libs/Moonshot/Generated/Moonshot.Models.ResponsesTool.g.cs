#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A tool definition, discriminated by `type`. Supported types are `function`, `custom` (only `apply_patch`), `namespace`, and `web_search`; other tool types are not supported.
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
        /// A custom tool that takes free-form text input. Only the custom tool named `apply_patch` is supported, and it must define a `grammar` + `lark` format; when the model calls it, a `custom_tool_call` item is returned in the output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesCustomTool? Custom { get; init; }
#else
        public global::Moonshot.ResponsesCustomTool? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesCustomTool? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesCustomTool PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        /// Groups a set of function or custom tools under one namespace.
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
        /// A web search tool executed on the server side. When present, the server first decides from the input whether a search is needed; if so, it runs the search, injects the results into the model context, and returns a `web_search_call` item in the output. At most one `web_search` tool is allowed per request. `search_context_size`, `blocked_domains`, and `filters.blocked_domains` are not supported and return `invalid_request_error`; `user_location`, `external_web_access`, and `indexed_web_access` are ignored.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesWebSearchTool? WebSearch { get; init; }
#else
        public global::Moonshot.ResponsesWebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesWebSearchTool? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesWebSearchTool PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
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
        public static implicit operator ResponsesTool(global::Moonshot.ResponsesCustomTool value) => new ResponsesTool((global::Moonshot.ResponsesCustomTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesCustomTool?(ResponsesTool @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public ResponsesTool(global::Moonshot.ResponsesCustomTool? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesTool FromCustom(global::Moonshot.ResponsesCustomTool? value) => new ResponsesTool(value);

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
        public static implicit operator ResponsesTool(global::Moonshot.ResponsesWebSearchTool value) => new ResponsesTool((global::Moonshot.ResponsesWebSearchTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesWebSearchTool?(ResponsesTool @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public ResponsesTool(global::Moonshot.ResponsesWebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesTool FromWebSearch(global::Moonshot.ResponsesWebSearchTool? value) => new ResponsesTool(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesTool(
            global::Moonshot.ResponsesToolDiscriminatorType? type,
            global::Moonshot.ResponsesFunctionTool? function,
            global::Moonshot.ResponsesCustomTool? custom,
            global::Moonshot.ResponsesNamespaceTool? @namespace,
            global::Moonshot.ResponsesWebSearchTool? webSearch
            )
        {
            Type = type;

            Function = function;
            Custom = custom;
            Namespace = @namespace;
            WebSearch = webSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Namespace as object ??
            Custom as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Custom?.ToString() ??
            Namespace?.ToString() ??
            WebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsCustom && !IsNamespace && !IsWebSearch || !IsFunction && IsCustom && !IsNamespace && !IsWebSearch || !IsFunction && !IsCustom && IsNamespace && !IsWebSearch || !IsFunction && !IsCustom && !IsNamespace && IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesFunctionTool, TResult>? function = null,
            global::System.Func<global::Moonshot.ResponsesCustomTool, TResult>? custom = null,
            global::System.Func<global::Moonshot.ResponsesNamespaceTool, TResult>? @namespace = null,
            global::System.Func<global::Moonshot.ResponsesWebSearchTool, TResult>? webSearch = null,
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
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsNamespace && @namespace != null)
            {
                return @namespace(Namespace!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ResponsesFunctionTool>? function = null,

            global::System.Action<global::Moonshot.ResponsesCustomTool>? custom = null,

            global::System.Action<global::Moonshot.ResponsesNamespaceTool>? @namespace = null,

            global::System.Action<global::Moonshot.ResponsesWebSearchTool>? webSearch = null,
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
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsNamespace)
            {
                @namespace?.Invoke(Namespace!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ResponsesFunctionTool>? function = null,
            global::System.Action<global::Moonshot.ResponsesCustomTool>? custom = null,
            global::System.Action<global::Moonshot.ResponsesNamespaceTool>? @namespace = null,
            global::System.Action<global::Moonshot.ResponsesWebSearchTool>? webSearch = null,
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
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsNamespace)
            {
                @namespace?.Invoke(Namespace!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
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
                Custom,
                typeof(global::Moonshot.ResponsesCustomTool),
                Namespace,
                typeof(global::Moonshot.ResponsesNamespaceTool),
                WebSearch,
                typeof(global::Moonshot.ResponsesWebSearchTool),
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
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesCustomTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesNamespaceTool?>.Default.Equals(Namespace, other.Namespace) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesWebSearchTool?>.Default.Equals(WebSearch, other.WebSearch)
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
