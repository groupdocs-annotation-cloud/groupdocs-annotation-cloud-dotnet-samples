using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Delete document annotations
    internal class DeleteAnnotations
	{
		public static void Run()
		{
            var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
				// Set request.
                var request = new DeleteAnnotationsRequest("one-page.docx");

				apiInstance.DeleteAnnotations(request);
				Console.WriteLine("DeleteAnnotations: Annotations deleted.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}
