// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TrackYourRide.iOS.Views
{
	[Register ("StartView")]
	partial class StartView
	{
		[Outlet]
		UIKit.UIButton ToLoginButton { get; set; }

		[Outlet]
		UIKit.UIButton ToRegisterButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ToLoginButton != null) {
				ToLoginButton.Dispose ();
				ToLoginButton = null;
			}

			if (ToRegisterButton != null) {
				ToRegisterButton.Dispose ();
				ToRegisterButton = null;
			}
		}
	}
}
