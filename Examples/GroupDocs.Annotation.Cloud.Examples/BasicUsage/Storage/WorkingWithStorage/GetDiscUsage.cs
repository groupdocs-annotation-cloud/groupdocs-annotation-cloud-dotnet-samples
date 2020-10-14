using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithStorage
{
	// Get Get Disc Usage
    internal class GetDiscUsage
	{
		public static void Run()
		{
			var apiInstance = new StorageApi(Constants.GetConfig());

			try
			{
				var request = new GetDiscUsageRequest(Constants.MyStorage);

				var response = apiInstance.GetDiscUsage(request);
				Console.WriteLine("Expected response type is DiscUsage: " + response.UsedSize);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling StorageApi: " + e.Message);
			}
		}
	}
}