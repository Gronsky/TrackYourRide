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
	[Register ("RegisterView")]
	partial class RegisterView
	{
		[Outlet]
		UIKit.UIButton RegisterButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RegisterButton != null) {
				RegisterButton.Dispose ();
				RegisterButton = null;
			}
		}
	}
}
