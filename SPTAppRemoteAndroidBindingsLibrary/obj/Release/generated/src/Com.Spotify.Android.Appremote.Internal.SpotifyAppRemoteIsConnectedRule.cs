using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyAppRemoteIsConnectedRule']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/SpotifyAppRemoteIsConnectedRule", DoNotGenerateAcw=true)]
	public partial class SpotifyAppRemoteIsConnectedRule : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/SpotifyAppRemoteIsConnectedRule", typeof (SpotifyAppRemoteIsConnectedRule));
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

		protected SpotifyAppRemoteIsConnectedRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyAppRemoteIsConnectedRule']/constructor[@name='SpotifyAppRemoteIsConnectedRule' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.SpotifyAppRemote']]"
		[Register (".ctor", "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V", "")]
		public unsafe SpotifyAppRemoteIsConnectedRule (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote spotifyAppRemote)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((spotifyAppRemote == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spotifyAppRemote).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.SpotifyAppRemoteIsConnectedRule __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SpotifyAppRemoteIsConnectedRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyAppRemoteIsConnectedRule']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/Throwable;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSatisfied;
#pragma warning disable 0169
		static Delegate GetIsSatisfiedHandler ()
		{
			if (cb_isSatisfied == null)
				cb_isSatisfied = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSatisfied);
			return cb_isSatisfied;
		}

		static bool n_IsSatisfied (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.SpotifyAppRemoteIsConnectedRule __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SpotifyAppRemoteIsConnectedRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSatisfied;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSatisfied {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyAppRemoteIsConnectedRule']/method[@name='isSatisfied' and count(parameter)=0]"
			[Register ("isSatisfied", "()Z", "GetIsSatisfiedHandler")]
			get {
				const string __id = "isSatisfied.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
