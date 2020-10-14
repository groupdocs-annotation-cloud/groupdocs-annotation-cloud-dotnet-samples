using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithStorage
{
	// Get File Versions
    internal class GetFileVersions
	{
		public static void Run()
		{
			var apiInstance = new StorageApi(Constants.GetConfig());

			try
			{
				var request = new GetFileVersionsRequest("one-page.docx", Constants.MyStorage);

				var response = apiInstance.GetFileVersions(request);
				Console.WriteLine("Expected response type is FileVersions: " + response.Value.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling StorageApi: " + e.Message);
			}
		}
	}
}