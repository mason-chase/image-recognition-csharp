using Mc2.Image.Recognition.NetStandard.DocumentModels;
using Mc2.Image.Recognition.NetStandard.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mc2.Image.Recognition.NetStandard.Google
{
    public class GoogleDriver : IDocumentOcrProcessor
    {
        private readonly GoogleVisionCredentials _credential;
        private readonly ILogger<GoogleDriver> _logger;

        public GoogleDriver(GoogleVisionCredentials credentials, ILogger<GoogleDriver> logger) 
        {
            _credential = credentials;
            _logger = logger;
#if DEBUG
            _logger.LogDebug("Loaded Google Driver with credentials:\n"+ credentials);
#endif
        }

        public GeneralDocumentData ProcessImage(IDocument document)
        {
#if DEBUG
            _logger.LogDebug("Processing image {0} ({1})", document.Name, document.Sha256);
#endif
            return new GeneralDocumentData();
        }
    }
}
