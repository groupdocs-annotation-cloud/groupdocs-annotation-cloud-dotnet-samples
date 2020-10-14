using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFiles
{
	// Move File
    internal class MoveFile
	{
		public static void Run()
		{
			var apiInstance = new FileApi(Constants.GetConfig());

			try
			{
				var request = new MoveFileRequest("one-page1.docx", "Annotationdocs1/one-page1.docx", Constants.MyStorage, Constants.MyStorage);

				apiInstance.MoveFile(request);
				Console.WriteLine("Expected response type is Void: 'one-page1.docx' file moved to 'Annotationdocs1/one-page1.docx'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}