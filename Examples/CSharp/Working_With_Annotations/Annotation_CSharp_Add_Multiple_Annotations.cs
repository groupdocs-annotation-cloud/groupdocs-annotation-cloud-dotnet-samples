using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Post/Add multiple annotations
	class Add_Multiple_Annotations
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new AnnotateApi(configuration);

			try
			{
				// Set request.
				var request = new PostAnnotationsRequest();
				request.filePath = "Annotationdocs\\ten-pages.pdf";
				AnnotationInfo[] annotations = {
				new AnnotationInfo
				{
					AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
					Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
					PageNumber = 0,
					PenColor = 1201033,
					PenStyle = 0,
					PenWidth = 1,
					Type = AnnotationInfo.TypeEnum.Distance,
					CreatorName = "Anonym A.",
					CreatedOn = DateTime.Now
				},
				new AnnotationInfo
					{
					AnnotationPosition = new Point { X = 1, Y = 1 },
					Box = new Rectangle { X = 100, Y = 100, Width = 100, Height = 100 },
					PageNumber = 1,
					BackgroundColor=65535,
					PenColor = 65535,
					PenStyle = 1,
					PenWidth = 3,
					Opacity = 0.7,
					Type = AnnotationInfo.TypeEnum.Area,
					Text="This is area annotation",
					CreatorName = "Anonym A.",
					Replies = new List<AnnotationReplyInfo>
					{
						new AnnotationReplyInfo
						{
							Message = "First comment",
							RepliedOn = DateTime.Now
						},
						new AnnotationReplyInfo
						{
							Message = "Second comment",
							RepliedOn = DateTime.Now
						}
					} },
				new AnnotationInfo
				{
					AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
					Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
					PageNumber = 2,
					PenColor = 1201033,
					PenStyle = 0,
					PenWidth = 1,
					Type = AnnotationInfo.TypeEnum.Area,
					CreatorName = "Anonym A."
				},
				new AnnotationInfo
				{
					AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
					Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
					PageNumber = 4,
					Type = AnnotationInfo.TypeEnum.Point,
					CreatorName = "Anonym A."
				},
				new AnnotationInfo
				{
					AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
					Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
					PageNumber = 5,
					PenColor = 1201033,
					PenStyle = 0,
					PenWidth = 1,
					Type = AnnotationInfo.TypeEnum.Arrow,
					CreatorName = "Anonym A."
				}
			};
				request.annotations = annotations.ToList();
				apiInstance.PostAnnotations(request);
				Console.WriteLine("Expected response type is void: Multiple Annotations added.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation AnnotateApi: " + e.Message);
			}
		}
	}
}