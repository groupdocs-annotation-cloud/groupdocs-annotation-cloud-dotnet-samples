using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithStorage
{
	// Is Object Exists
    internal class ObjectExists
	{
		public static void Run()
		{
			var apiInstance = new StorageApi(Constants.GetConfig());

			try
			{
				var request = new ObjectExistsRequest("one-page.docx", Constants.MyStorage);

				var response = apiInstance.ObjectExists(request);
				Console.WriteLine("Expected response type is ObjectExist: " + response.Exists);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling StorageApi: " + e.Message);
			}
		}
	}
}