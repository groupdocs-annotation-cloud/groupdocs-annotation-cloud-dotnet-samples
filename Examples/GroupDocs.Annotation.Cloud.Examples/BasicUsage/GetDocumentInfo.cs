using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage
{
	// Get document information
    internal class GetDocumentInfo
	{
		public static void Run()
		{
			var apiInstance = new InfoApi(Constants.GetConfig());

            var request = new GetInfoRequest(new FileInfo { FilePath = "one-page.docx" });

			var response = apiInstance.GetInfo(request);
			Console.WriteLine("GetDocumentInfo: pages count = " + response.Pages.Count);
        }
	}
}
