using Azihub.Utilities.Base.Tests;
using Mc2.Image.Recognition.NetStandard.Google;
using Xunit;
using Xunit.Abstractions;

namespace Mc2.Image.Recognition.NetStandard.Tests.Google
{
    public class GoogleVisionTests : TestBase
    {
        public GoogleVisionTests(ITestOutputHelper outputHelper) : base(outputHelper) { }

        [Fact]
        public void GetGoogleVisionData()
        {
            GoogleVisionCredentials test = TestSettings.GoogleVisionCredentials;

        }    
    }
}
