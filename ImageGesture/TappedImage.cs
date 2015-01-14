using System;
using Xamarin.Forms;

namespace ImageGesture
{
	public class TappedImage : Image
	{
		public event EventHandler<TapLocationEventArgs> TapLocationEvent;

		public TappedImage ()
		{
		}

		public void OnTapped (Point location)
		{
			if (TapLocationEvent != null)
				TapLocationEvent (this, new TapLocationEventArgs (location));
		}
	}

	public class TapLocationEventArgs:EventArgs
	{
		public Point TapLocation{ get; private set; }

		public TapLocationEventArgs (Point p)
		{
			TapLocation = p;
		}
	}
}