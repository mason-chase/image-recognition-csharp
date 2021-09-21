# Image Recognition NetStandard 2.0

This project aims to combine power multiple API into uniform data,

Usage:

```C#

```

## Supported platforms

Current supported platform are:

- [Google's Vision](https://cloud.google.com/vision)
- [Amazon's Textract](https://aws.amazon.com/textract/)
- [Azure's Form Recognizer](https://azure.microsoft.com/en-us/services/form-recognizer/)

### Google Vision

Follow [this guide](https://cloud.google.com/vision/docs/setup) to setup your API Key, you will need below settings in environment variables:

```bash
GOOGLE_VISION_TYPE=service_account
GOOGLE_VISION_CLIENT_ID=
GOOGLE_VISION_CLIENT_EMAIL=
GOOGLE_VISION_PRIVATE_KEY=-----BEGIN PRIVATE KEY-----\n BASE64 IN ONE LINE \n-----END PRIVATE KEY-----\n
GOOGLE_VISION_PRIVATE_KEY_ID=
```