// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileProperties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The remove properties arg object</para>
    /// </summary>
    public class RemovePropertiesArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemovePropertiesArg> Encoder = new RemovePropertiesArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemovePropertiesArg> Decoder = new RemovePropertiesArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemovePropertiesArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">A unique identifier for the file or folder.</param>
        /// <param name="propertyTemplateIds">A list of identifiers for a template created by
        /// <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.TemplatesAddForUserAsync"
        /// /> or <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesTeamRoutes.TemplatesAddForTeamAsync"
        /// />.</param>
        public RemovePropertiesArg(string path,
                                   col.IEnumerable<string> propertyTemplateIds)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:/(.|[\r\n])*|id:.*|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:/(.|[\r\n])*|id:.*|(ns:[0-9]+(/.*)?))\z'");
            }

            var propertyTemplateIdsList = enc.Util.ToList(propertyTemplateIds);

            if (propertyTemplateIds == null)
            {
                throw new sys.ArgumentNullException("propertyTemplateIds");
            }

            this.Path = path;
            this.PropertyTemplateIds = propertyTemplateIdsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemovePropertiesArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RemovePropertiesArg()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the file or folder.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>A list of identifiers for a template created by <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.TemplatesAddForUserAsync"
        /// /> or <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesTeamRoutes.TemplatesAddForTeamAsync"
        /// />.</para>
        /// </summary>
        public col.IList<string> PropertyTemplateIds { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RemovePropertiesArg" />.</para>
        /// </summary>
        private class RemovePropertiesArgEncoder : enc.StructEncoder<RemovePropertiesArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemovePropertiesArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteListProperty("property_template_ids", value.PropertyTemplateIds, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RemovePropertiesArg" />.</para>
        /// </summary>
        private class RemovePropertiesArgDecoder : enc.StructDecoder<RemovePropertiesArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemovePropertiesArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemovePropertiesArg Create()
            {
                return new RemovePropertiesArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RemovePropertiesArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "property_template_ids":
                        value.PropertyTemplateIds = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}