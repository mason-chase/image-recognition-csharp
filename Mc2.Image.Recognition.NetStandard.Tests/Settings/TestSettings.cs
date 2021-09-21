using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azihub.Utilities.Base.Tools;
using Mc2.Image.Recognition.NetStandard.Google;
using Mc2.Image.Recognition.NetStandard.Tests.Google;

namespace Mc2.Image.Recognition.NetStandard.Tests
{
    public static class TestSettings
    {
        static TestSettings()
        {
            DotEnv.Load();
            GoogleVisionCredentials = DotEnv.Load<GoogleVisionCredentials>();
        }

        public static GoogleVisionCredentials GoogleVisionCredentials { get; }
    }
}
