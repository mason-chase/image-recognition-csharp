using Azihub.Utilities.Base.Tools.Annotations;

namespace Mc2.Image.Recognition.NetStandard.Google
{
    public class GoogleVisionCredentials
    {
        [EnvName("GOOGLE_VISION_TYPE")]
        public string GoogleVisionType { get; set; }

        [EnvName("GOOGLE_VISION_CLIENT_ID")]
        public string ClientId { get; set; }

        [EnvName("GOOGLE_VISION_CLIENT_EMAIL")]
        public string ClientEmail { get; set; }

        [EnvName("GOOGLE_VISION_PRIVATE_KEY")]
        public string PrivateKey { get; set; }

        [EnvName("GOOGLE_VISION_PRIVATE_KEY_ID")]
        public string PrivateKeyId { get; set; }
    }
}