using System;
using Xamarin.Forms;

namespace ImageGesture
{
	public class SamplePage : ContentPage
	{
		public SamplePage ()
		{
			var i = new TappedImage () {
				Source = "drawable/Sample.png",
			};

			i.TapLocationEvent += (sender, e) => {
				this.DisplayAlert ("Click", "It was at: " + e.TapLocation.X + ", " + e.TapLocation.Y, "Thanks");
			};

			Content = new StackLayout () {
				Children = {
					new Label(){
						Text = "Hello world"
					},
					i
				}
			};
		}
	}
}