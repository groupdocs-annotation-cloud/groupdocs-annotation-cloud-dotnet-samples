using System;
using System.IO;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;

namespace GroupDocs.Annotation.Cloud.Examples
{
    internal class Constants
	{
		public static string MyClientId;
		public static string MyClientSecret;
		public static string MyStorage;

        public static Configuration GetConfig()
        {
            var config = new Configuration(MyClientId, MyClientSecret);
            config.ApiBaseUrl = "https://api.groupdocs.cloud";
            return config;
        }

        public static void UploadSampleTestFiles()
		{
			var configuration = GetConfig();
            var storageApi = new StorageApi(configuration);
			var folderApi = new FolderApi(configuration);
			var fileApi = new FileApi(configuration);

			var path = "..\\..\\..\\..\\..\\Resources";

			Console.WriteLine("File Upload Processing...");

			var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
			foreach (var dir in dirs)
			{
				var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);
				var response = storageApi.ObjectExists(new Sdk.Model.Requests.ObjectExistsRequest(relativeDirPath, MyStorage));
				if (response.Exists != null && !response.Exists.Value)
				{
					folderApi.CreateFolder(new Sdk.Model.Requests.CreateFolderRequest(relativeDirPath, MyStorage));
				}
			}

			var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

				var response = storageApi.ObjectExists(new Sdk.Model.Requests.ObjectExistsRequest(relativeFilePath, MyStorage));
				if (response.Exists != null && !response.Exists.Value)
				{
                    var fileStream = File.Open(file, FileMode.Open);

					fileApi.UploadFile(new Sdk.Model.Requests.UploadFileRequest(relativeFilePath, fileStream, MyStorage));
					fileStream.Close();
				}
			}

			Console.WriteLine("File Upload Process Completed.");
		}
	}
}
