using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace Alloy.Models.Media
{
    [ContentType(GUID = "CF1576A1-478F-4B91-A0C6-99250ABA148F")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class VectorImageFile : ImageFile
    {
        public override Blob Thumbnail
        {
            get { return BinaryData; }
        }
    }
}
