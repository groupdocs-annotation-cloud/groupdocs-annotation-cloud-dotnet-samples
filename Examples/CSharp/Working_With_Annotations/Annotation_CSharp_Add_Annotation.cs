using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Post/Add annotations
	class Add_Annotation
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new AnnotateApi(configuration);

			try
			{
				// Set request.
				var request = new PostAnnotationsRequest()
				{
					filePath = "Annotationdocs\\ten-pages.docx",
					annotations = new System.Collections.Generic.List<AnnotationInfo>() {
						new AnnotationInfo
						{
							AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
							Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
							PageNumber = 0,
							PenColor = 1201033,
							PenStyle = 0,
							PenWidth = 1,
							Type = AnnotationInfo.TypeEnum.Area,
							CreatorName = "Anonym A."
						}
					}
				};
				apiInstance.PostAnnotations(request);
				Console.WriteLine("Expected response type is void: Annotation added.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation AnnotateApi: " + e.Message);
			}
		}
	}
}