using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyLocator']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/SpotifyLocator", DoNotGenerateAcw=true)]
	public partial class SpotifyLocator : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/SpotifyLocator", typeof (SpotifyLocator));
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

		protected SpotifyLocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyLocator']/constructor[@name='SpotifyLocator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpotifyLocator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getSpotifyBestPackageName_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetSpotifyBestPackageName_Landroid_content_Context_Handler ()
		{
			if (cb_getSpotifyBestPackageName_Landroid_content_Context_ == null)
				cb_getSpotifyBestPackageName_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSpotifyBestPackageName_Landroid_content_Context_);
			return cb_getSpotifyBestPackageName_Landroid_content_Context_;
		}

		static IntPtr n_GetSpotifyBestPackageName_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Spotify.Android.Appremote.Internal.SpotifyLocator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SpotifyLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSpotifyBestPackageName (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyLocator']/method[@name='getSpotifyBestPackageName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSpotifyBestPackageName", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetSpotifyBestPackageName_Landroid_content_Context_Handler")]
		public virtual unsafe string GetSpotifyBestPackageName (global::Android.Content.Context context)
		{
			const string __id = "getSpotifyBestPackageName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isSpotifyInstalled_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsSpotifyInstalled_Landroid_content_Context_Handler ()
		{
			if (cb_isSpotifyInstalled_Landroid_content_Context_ == null)
				cb_isSpotifyInstalled_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSpotifyInstalled_Landroid_content_Context_);
			return cb_isSpotifyInstalled_Landroid_content_Context_;
		}

		static bool n_IsSpotifyInstalled_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Spotify.Android.Appremote.Internal.SpotifyLocator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SpotifyLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSpotifyInstalled (context);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SpotifyLocator']/method[@name='isSpotifyInstalled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSpotifyInstalled", "(Landroid/content/Context;)Z", "GetIsSpotifyInstalled_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsSpotifyInstalled (global::Android.Content.Context context)
		{
			const string __id = "isSpotifyInstalled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
