// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Common
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Root info when user is member of a team with a separate root namespace ID.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Common.RootInfo" />
    public class TeamRootInfo : RootInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamRootInfo> Encoder = new TeamRootInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamRootInfo> Decoder = new TeamRootInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamRootInfo" /> class.</para>
        /// </summary>
        /// <param name="rootNamespaceId">The namespace ID for user's root namespace. It will
        /// be the namespace ID of the shared team root if the user is member of a team with a
        /// separate team root. Otherwise it will be same as <see
        /// cref="Dropbox.Api.Common.RootInfo.HomeNamespaceId" />.</param>
        /// <param name="homeNamespaceId">The namespace ID for user's home namespace.</param>
        /// <param name="homePath">The path for user's home directory under the shared team
        /// root.</param>
        public TeamRootInfo(string rootNamespaceId,
                            string homeNamespaceId,
                            string homePath)
            : base(rootNamespaceId, homeNamespaceId)
        {
            if (homePath == null)
            {
                throw new sys.ArgumentNullException("homePath");
            }

            this.HomePath = homePath;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamRootInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamRootInfo()
        {
        }

        /// <summary>
        /// <para>The path for user's home directory under the shared team root.</para>
        /// </summary>
        public string HomePath { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamRootInfo" />.</para>
        /// </summary>
        private class TeamRootInfoEncoder : enc.StructEncoder<TeamRootInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamRootInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("root_namespace_id", value.RootNamespaceId, writer, enc.StringEncoder.Instance);
                WriteProperty("home_namespace_id", value.HomeNamespaceId, writer, enc.StringEncoder.Instance);
                WriteProperty("home_path", value.HomePath, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamRootInfo" />.</para>
        /// </summary>
        private class TeamRootInfoDecoder : enc.StructDecoder<TeamRootInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamRootInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamRootInfo Create()
            {
                return new TeamRootInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamRootInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "root_namespace_id":
                        value.RootNamespaceId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "home_namespace_id":
                        value.HomeNamespaceId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "home_path":
                        value.HomePath = enc.StringDecoder.Instance.Decode(reader);
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