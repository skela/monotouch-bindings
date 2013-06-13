using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SVGKit;

namespace Test
{
	public partial class TestViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TestViewController ()
			: base (UserInterfaceIdiomIsPhone ? "TestViewController_iPhone" : "TestViewController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}



		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{

				return true;
			
		}

		#region View lifecycle

		SVGKImageView imageView;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			SVGKImage image = SVGKImage.ImageNamed ("Broken_crossed_circle.svg");
			imageView = new SVGKImageView (image);

			View.AddSubview (imageView);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewWillLayoutSubviews()
		{
			base.ViewWillLayoutSubviews ();

			RectangleF rect = View.Bounds;
			rect.X = 10;
			rect.Y = 10;
			rect.Width = rect.Width - rect.X * 2;
			rect.Height = rect.Height - rect.Y * 2;
			imageView.Frame = rect;
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

