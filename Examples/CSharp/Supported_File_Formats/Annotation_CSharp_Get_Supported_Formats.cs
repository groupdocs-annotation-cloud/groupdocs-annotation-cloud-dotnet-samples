using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Get All Supported Formats
	class Get_All_Supported_Formats
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new InfoApi(configuration);

			try
			{
				// Get supported file formats
				var response = apiInstance.GetSupportedFileFormats();

				foreach (var entry in response.Formats)
				{
					Console.WriteLine(string.Format("{0}: {1}", entry.FileFormat, string.Join(",", entry.Extension)));
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation InfoApi: " + e.Message);
			}
		}
	}
}