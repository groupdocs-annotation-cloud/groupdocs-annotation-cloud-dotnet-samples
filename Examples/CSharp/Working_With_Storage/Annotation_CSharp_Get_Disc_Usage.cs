using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Get Get Disc Usage
	class Get_Disc_Usage
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new StorageApi(configuration);

			try
			{
				var request = new GetDiscUsageRequest(Common.MyStorage);

				var response = apiInstance.GetDiscUsage(request);
				Console.WriteLine("Expected response type is DiscUsage: " + response.UsedSize.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling StorageApi: " + e.Message);
			}
		}
	}
}