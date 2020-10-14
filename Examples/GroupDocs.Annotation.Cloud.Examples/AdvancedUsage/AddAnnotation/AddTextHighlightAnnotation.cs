using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Add Text highlight annotations
	internal class AddTextHighlightAnnotation
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
                        Points = new List<Point>
                        {
                            new Point {X = 80, Y = 730}, new Point {X=240, Y=730}, new Point {X=80, Y=650}, new Point {X=240, Y=650}
                        },
						BackgroundColor = 65535,
                        PageNumber = 0,
                        Type = AnnotationInfo.TypeEnum.TextHighlight,
                        Text = "This is text highlight annotation",
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
				Console.WriteLine("AddTextHighlightAnnotation: Text highlight Annotation added.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}