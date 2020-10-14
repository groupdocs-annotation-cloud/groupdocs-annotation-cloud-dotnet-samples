using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage
{
	// Get All Supported Formats
    internal class GetSupportedFormats
	{
		public static void Run()
		{
            var apiInstance = new InfoApi(Constants.GetConfig());

    		// Get supported file formats
			var response = apiInstance.GetSupportedFileFormats();

            Console.WriteLine("GetSupportedFormats: formats count = " + response.Formats.Count);
		}
	}
}
