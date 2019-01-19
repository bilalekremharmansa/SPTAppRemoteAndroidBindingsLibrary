using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api.error']/class[@name='CouldNotFindSpotifyApp']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/error/CouldNotFindSpotifyApp", DoNotGenerateAcw=true)]
	public partial class CouldNotFindSpotifyApp : global::Com.Spotify.Protocol.Error.SpotifyAppRemoteException {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/error/CouldNotFindSpotifyApp", typeof (CouldNotFindSpotifyApp));
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

		protected CouldNotFindSpotifyApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.api.error']/class[@name='CouldNotFindSpotifyApp']/constructor[@name='CouldNotFindSpotifyApp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CouldNotFindSpotifyApp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
