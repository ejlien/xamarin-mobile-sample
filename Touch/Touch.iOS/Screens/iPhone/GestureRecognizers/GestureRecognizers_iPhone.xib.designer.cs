// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_Touch.Screens.iPhone.GestureRecognizers {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[Foundation.Register("GestureRecognizers_iPhone")]
	public partial class GestureRecognizers_iPhone {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIImageView __mt_imgDragMe;
		
		private UIKit.UIImageView __mt_imgTapMe;
		
		private UIKit.UILabel __mt_lblGestureStatus;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("imgDragMe")]
		private UIKit.UIImageView imgDragMe {
			get {
				this.__mt_imgDragMe = ((UIKit.UIImageView)(this.GetNativeField("imgDragMe")));
				return this.__mt_imgDragMe;
			}
			set {
				this.__mt_imgDragMe = value;
				this.SetNativeField("imgDragMe", value);
			}
		}
		
		[Foundation.Connect("imgTapMe")]
		private UIKit.UIImageView imgTapMe {
			get {
				this.__mt_imgTapMe = ((UIKit.UIImageView)(this.GetNativeField("imgTapMe")));
				return this.__mt_imgTapMe;
			}
			set {
				this.__mt_imgTapMe = value;
				this.SetNativeField("imgTapMe", value);
			}
		}
		
		[Foundation.Connect("lblGestureStatus")]
		private UIKit.UILabel lblGestureStatus {
			get {
				this.__mt_lblGestureStatus = ((UIKit.UILabel)(this.GetNativeField("lblGestureStatus")));
				return this.__mt_lblGestureStatus;
			}
			set {
				this.__mt_lblGestureStatus = value;
				this.SetNativeField("lblGestureStatus", value);
			}
		}
	}
}