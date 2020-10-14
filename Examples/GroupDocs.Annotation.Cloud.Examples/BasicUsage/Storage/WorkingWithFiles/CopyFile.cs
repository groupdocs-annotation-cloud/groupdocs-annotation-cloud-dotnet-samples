using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFiles
{
	// Copy File
    internal class CopyFile
	{
		public static void Run()
		{
			var apiInstance = new FileApi(Constants.GetConfig());

			try
			{
				var request = new CopyFileRequest("one-page.docx", "one-page-copied.docx", Constants.MyStorage, Constants.MyStorage);

				apiInstance.CopyFile(request);
				Console.WriteLine("Expected response type is Void: 'one-page.docx' file copied as 'one-page-copied.docx'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}
