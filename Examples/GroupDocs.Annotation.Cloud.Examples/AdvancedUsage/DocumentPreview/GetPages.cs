using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Get document pages as images
    internal class GetPages
	{
		public static void Run()
		{
            var apiInstance = new PreviewApi(Constants.GetConfig());

			try
			{
                var fileInfo = new FileInfo { FilePath = "one-page.docx" };
                var options = new PreviewOptions {FileInfo = fileInfo};

                var request = new GetPagesRequest(options);

				var response = apiInstance.GetPages(request);
				Console.WriteLine("GetPages: pages count = " + response.TotalCount);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation PreviewApi: " + e.Message);
			}
		}
	}
}
