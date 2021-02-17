using System;
using System.Collections.Generic;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
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
                var fileInfo = new FileInfo { FilePath = "one-page.docx" };
				var options = new RemoveOptions();
                options.FileInfo = fileInfo;
				options.AnnotationIds = new List<int?> {1, 2, 3};
                options.OutputPath = "Output/output.docx";
				var request = new RemoveAnnotationsRequest(options);

				var link = apiInstance.RemoveAnnotations(request);
				Console.WriteLine("DeleteAnnotations: Annotations deleted: " + link.Title);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}
