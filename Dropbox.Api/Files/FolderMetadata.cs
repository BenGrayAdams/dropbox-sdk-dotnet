// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The folder metadata object</para>
    /// </summary>
    /// <seealso cref="Metadata" />
    public sealed class FolderMetadata : Metadata, enc.IEncodable<FolderMetadata>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        /// <param name="name">The last component of the path (including extension). This never
        /// contains a slash.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash.</param>
        /// <param name="id">A unique identifier for the folder.</param>
        public FolderMetadata(string name,
                              string pathLower,
                              string id = null)
            : base(name, pathLower)
        {
            if (id != null && (id.Length < 1))
            {
                throw new sys.ArgumentOutOfRangeException("id");
            }

            this.Id = id;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FolderMetadata()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the folder.</para>
        /// </summary>
        public string Id { get; private set; }

        #region IEncodable<FolderMetadata> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<FolderMetadata>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>(".tag", "folder");
                obj.AddField<string>("name", this.Name);
                obj.AddField<string>("path_lower", this.PathLower);
                if (this.Id != null)
                {
                    obj.AddField<string>("id", this.Id);
                }
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        FolderMetadata enc.IEncodable<FolderMetadata>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Name = obj.GetField<string>("name");
                this.PathLower = obj.GetField<string>("path_lower");
                if (obj.HasField("id"))
                {
                    this.Id = obj.GetField<string>("id");
                }
            }

            return this;
        }

        #endregion
    }
}