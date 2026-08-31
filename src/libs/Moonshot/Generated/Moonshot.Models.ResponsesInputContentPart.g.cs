#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Moonshot
{
    /// <summary>
    /// An element of a content array, discriminated by `type`.
    /// </summary>
    public readonly partial struct ResponsesInputContentPart : global::System.IEquatable<ResponsesInputContentPart>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesInputContentPartInputText? InputText { get; init; }
#else
        public global::Moonshot.ResponsesInputContentPartInputText? InputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesInputContentPartInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputText PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesInputContentPartInputImage? InputImage { get; init; }
#else
        public global::Moonshot.ResponsesInputContentPartInputImage? InputImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesInputContentPartInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartInputImage PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// Used when replaying assistant text from history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Moonshot.ResponsesInputContentPartOutputText? OutputText { get; init; }
#else
        public global::Moonshot.ResponsesInputContentPartOutputText? OutputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Moonshot.ResponsesInputContentPartOutputText? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Moonshot.ResponsesInputContentPartOutputText PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputContentPart(global::Moonshot.ResponsesInputContentPartInputText value) => new ResponsesInputContentPart((global::Moonshot.ResponsesInputContentPartInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesInputContentPartInputText?(ResponsesInputContentPart @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputContentPart(global::Moonshot.ResponsesInputContentPartInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputContentPart FromInputText(global::Moonshot.ResponsesInputContentPartInputText? value) => new ResponsesInputContentPart(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputContentPart(global::Moonshot.ResponsesInputContentPartInputImage value) => new ResponsesInputContentPart((global::Moonshot.ResponsesInputContentPartInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesInputContentPartInputImage?(ResponsesInputContentPart @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputContentPart(global::Moonshot.ResponsesInputContentPartInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputContentPart FromInputImage(global::Moonshot.ResponsesInputContentPartInputImage? value) => new ResponsesInputContentPart(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesInputContentPart(global::Moonshot.ResponsesInputContentPartOutputText value) => new ResponsesInputContentPart((global::Moonshot.ResponsesInputContentPartOutputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Moonshot.ResponsesInputContentPartOutputText?(ResponsesInputContentPart @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputContentPart(global::Moonshot.ResponsesInputContentPartOutputText? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesInputContentPart FromOutputText(global::Moonshot.ResponsesInputContentPartOutputText? value) => new ResponsesInputContentPart(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesInputContentPart(
            global::Moonshot.ResponsesInputContentPartInputText? inputText,
            global::Moonshot.ResponsesInputContentPartInputImage? inputImage,
            global::Moonshot.ResponsesInputContentPartOutputText? outputText
            )
        {
            InputText = inputText;
            InputImage = inputImage;
            OutputText = outputText;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputText as object ??
            InputImage as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            OutputText?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsOutputText || !IsInputText && IsInputImage && !IsOutputText || !IsInputText && !IsInputImage && IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Moonshot.ResponsesInputContentPartInputText, TResult>? inputText = null,
            global::System.Func<global::Moonshot.ResponsesInputContentPartInputImage, TResult>? inputImage = null,
            global::System.Func<global::Moonshot.ResponsesInputContentPartOutputText, TResult>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Moonshot.ResponsesInputContentPartInputText>? inputText = null,

            global::System.Action<global::Moonshot.ResponsesInputContentPartInputImage>? inputImage = null,

            global::System.Action<global::Moonshot.ResponsesInputContentPartOutputText>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Moonshot.ResponsesInputContentPartInputText>? inputText = null,
            global::System.Action<global::Moonshot.ResponsesInputContentPartInputImage>? inputImage = null,
            global::System.Action<global::Moonshot.ResponsesInputContentPartOutputText>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::Moonshot.ResponsesInputContentPartInputText),
                InputImage,
                typeof(global::Moonshot.ResponsesInputContentPartInputImage),
                OutputText,
                typeof(global::Moonshot.ResponsesInputContentPartOutputText),
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
        public bool Equals(ResponsesInputContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesInputContentPartInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesInputContentPartInputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Moonshot.ResponsesInputContentPartOutputText?>.Default.Equals(OutputText, other.OutputText)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponsesInputContentPart obj1, ResponsesInputContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesInputContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesInputContentPart obj1, ResponsesInputContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesInputContentPart o && Equals(o);
        }
    }
}
