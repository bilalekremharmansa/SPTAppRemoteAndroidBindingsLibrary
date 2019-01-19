using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='WelcomeDetails']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/WelcomeDetails", DoNotGenerateAcw=true)]
	public partial class WelcomeDetails : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='WelcomeDetails']/field[@name='roles']"
		[Register ("roles")]
		public global::Com.Spotify.Protocol.Types.Roles Roles {
			get {
				const string __id = "roles.Lcom/spotify/protocol/types/Roles;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Roles> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "roles.Lcom/spotify/protocol/types/Roles;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/WelcomeDetails", typeof (WelcomeDetails));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected WelcomeDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='WelcomeDetails']/constructor[@name='WelcomeDetails' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.Roles']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Roles;)V", "")]
		public unsafe WelcomeDetails (global::Com.Spotify.Protocol.Types.Roles roles)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Roles;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((roles == null) ? IntPtr.Zero : ((global::Java.Lang.Object) roles).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
