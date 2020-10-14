using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFiles
{
	// Delete File
    internal class DeleteFile
	{
		public static void Run()
		{
			var apiInstance = new FileApi(Constants.GetConfig());

			try
			{
				var request = new DeleteFileRequest("one-page1.docx", Constants.MyStorage);

				apiInstance.DeleteFile(request);
				Console.WriteLine("Expected response type is Void: 'one-page1.docx' deleted.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}
