using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Add Ellipse annotations
	internal class AddEllipseAnnotation
	{
		public static void Run()
		{
			var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
				var request = new PostAnnotationsRequest();
				request.filePath = "one-page.docx";
				AnnotationInfo[] annotations =
				{
					new AnnotationInfo
					{
						AnnotationPosition = new Point { X = 1, Y = 1 },
						Box = new Rectangle { X = 100, Y = 100, Width = 100, Height = 100 },
						PageNumber = 0,
						BackgroundColor = 65535,
						PenColor = 65535,
						PenStyle = AnnotationInfo.PenStyleEnum.Solid,
						PenWidth = 3,
						Opacity = 0.7,
                        Type = AnnotationInfo.TypeEnum.Ellipse,
                        Text = "This is ellipse annotation",
						CreatorName = "Anonym A.",
						CreatedOn = DateTime.Now,
						Replies = new List<AnnotationReplyInfo>
						{
							new AnnotationReplyInfo
							{
								Comment = "First comment",
								RepliedOn = DateTime.Now
							},
							new AnnotationReplyInfo
							{
								Comment = "Second comment",
								RepliedOn = DateTime.Now
							}
						}
					},
				};
				request.annotations = annotations.ToList();
				apiInstance.PostAnnotations(request);
				Console.WriteLine("AddEllipseeAnnotation: Ellipse Annotation added.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}