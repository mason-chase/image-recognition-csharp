using Azihub.Utilities.Base.Extensions.ByteArray;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mc2.Image.Recognition.NetStandard.Interfaces
{
    public interface IDocument : IEquatable<IDocument>
    {
        Guid Guid { get; }
        string Sha256 { get; }
        string Name { get; }
        FileType FileType { get; }
        byte[] ByteArray { get; }
    }

    public enum FileType
    {
        Pdf,
        Jpg,
        Jpeg,
        Png,
        Gif
    }
}
