using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFolder
{
	// Get Files List
    internal class GetFilesList
	{
		public static void Run()
		{
			var apiInstance = new FolderApi(Constants.GetConfig());

			try
			{
				var request = new GetFilesListRequest("Annotationdocs", Constants.MyStorage);

				var response = apiInstance.GetFilesList(request);
				Console.WriteLine("Expected response type is FilesList: " + response.Value.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}