using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using ImageGesture;
using ImageGesture.iOS;
using UIKit;

[assembly:ExportRenderer(typeof(TappedImage),typeof(TappedImageRenderer))]
namespace ImageGesture.iOS
{
	public class TappedImageRenderer : ImageRenderer
	{
		public TappedImageRenderer ()
		{
			this.UserInteractionEnabled = true;
			var r = new UITapGestureRecognizer(t => {
				var l = t.LocationInView(this);
				var asPoint = new Point (l.X, l.Y);
				((TappedImage)Element).OnTapped (asPoint);
			});
			r.NumberOfTapsRequired = 1;
			AddGestureRecognizer (r);
		}
//
//		public override void TouchesEnded (Foundation.NSSet touches, UIKit.UIEvent evt)
//		{
//			base.TouchesEnded (touches, evt);
//
//			var touch = touches.AnyObject as UITouch;
//			if (touch != null) {
//				var l = touch.LocationInView (this);
//				var asPoint = new Point (l.X, l.Y);
//				((TappedImage)Element).OnTapped (asPoint);
//			}
//		}
	}
}