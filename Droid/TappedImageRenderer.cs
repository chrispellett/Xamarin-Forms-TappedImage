using System;
using Xamarin.Forms;
using ImageGesture;
using ImageGesture.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using Android.App;

[assembly:ExportRenderer (typeof(TappedImage), typeof(TappedImageRenderer))]
namespace ImageGesture.Droid
{
	public class TappedImageRenderer : ImageRenderer//, Android.Views.GestureDetector.IOnGestureListener
	{
		private bool eventAttached;

		public TappedImageRenderer ()
		{
//			var g = new GestureDetector (this);

//			var a = ((Activity)Context);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged (e);

			if (Control != null && !eventAttached) {
				Control.Touch += (sender, te) => {
					var p = new Point (te.Event.RawX, te.Event.RawY);
					((TappedImage)Element).OnTapped (p);
				};
				eventAttached = true;
			}
		}

		//		public bool OnDown (MotionEvent e)
		//		{
		//		}
		//
		//		public bool OnFling (MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
		//		{
		//		}
		//
		//		public void OnLongPress (MotionEvent e)
		//		{
		//		}
		//
		//		public bool OnScroll (MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
		//		{
		//		}
		//
		//		public void OnShowPress (MotionEvent e)
		//		{
		//		}
		//
		//		public bool OnSingleTapUp (MotionEvent e)
		//		{
		//			return true;
		//		}
	}
}