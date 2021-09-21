using Azihub.Utilities.Base.Extensions.ByteArray;
using Mc2.Image.Recognition.NetStandard.Interfaces;
using System;

namespace Mc2.Image.Recognition.NetStandard.DocumentModels
{
    public class Document : IDocument
    {
        /// <summary>
        /// Serialize existing data
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="sha256"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="byteArray"></param>
        public Document(Guid guid, string sha256, string name, FileType type, byte[] byteArray)
        {
            Guid = guid;
            Sha256 = sha256;
            Name = name;
            FileType = type;
            ByteArray = byteArray;
        }
        
        /// <summary>
        /// Create a new Document object and generate Guid with Sha256
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="byteArray"></param>
        public Document(string name, FileType type, byte[] byteArray)
        {
            Guid = Guid.NewGuid();
            Sha256 = byteArray.GetSha256();
            Name = name;
            FileType = type;
            ByteArray = byteArray;
        }
        
        public Guid Guid { get; }

        public string Sha256 { get; }
        
        public string Name { get; }

        public FileType FileType { get; }

        public byte[] ByteArray { get; }

        public bool Equals(IDocument other)
        {
            return Sha256 == other?.Sha256;
        }

    }
}
