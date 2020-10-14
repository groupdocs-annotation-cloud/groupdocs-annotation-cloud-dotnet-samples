using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Delete document pages created as images
    internal class DeletePages
	{
		public static void Run()
		{
            var apiInstance = new PreviewApi(Constants.GetConfig());

			try
			{
                var request = new DeletePagesRequest("one-page.docx");

                apiInstance.DeletePages(request);
				Console.WriteLine("DeletePages: pages deleted.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation PreviewApi: " + e.Message);
			}
		}
	}
}