using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
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
                var request = new GetPagesRequest("one-page.docx");

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
