﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Dia1Ex2
{
	[Register ("Dia1_Ex2ViewController")]
	partial class Dia1_Ex2ViewController
	{
		[Outlet]
		UIKit.UIButton button { get; set; }

		[Outlet]
		UIKit.UIImageView imageView { get; set; }

		[Outlet]
		UIKit.UITextField textField { get; set; }

		[Outlet]
		UIKit.UITextView textView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (button != null) {
				button.Dispose ();
				button = null;
			}

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}

			if (textView != null) {
				textView.Dispose ();
				textView = null;
			}
		}
	}
}
