using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnectorFactory']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/SdkRemoteClientConnectorFactory", DoNotGenerateAcw=true)]
	public partial class SdkRemoteClientConnectorFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/SdkRemoteClientConnectorFactory", typeof (SdkRemoteClientConnectorFactory));
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

		protected SdkRemoteClientConnectorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnectorFactory']/constructor[@name='SdkRemoteClientConnectorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SdkRemoteClientConnectorFactory ()
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

		static Delegate cb_newConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_Handler ()
		{
			if (cb_newConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_ == null)
				cb_newConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_);
			return cb_newConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_;
		}

		static IntPtr n_NewConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native__params, IntPtr native_spotifyBestPackageName)
		{
			global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnectorFactory __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnectorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams @params = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (native__params, JniHandleOwnership.DoNotTransfer);
			string spotifyBestPackageName = JNIEnv.GetString (native_spotifyBestPackageName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewConnector (context, @params, spotifyBestPackageName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnectorFactory']/method[@name='newConnector' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.spotify.android.appremote.api.ConnectionParams'] and parameter[3][@type='java.lang.String']]"
		[Register ("newConnector", "(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Ljava/lang/String;)Lcom/spotify/android/appremote/internal/SdkRemoteClientConnector;", "GetNewConnector_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector NewConnector (global::Android.Content.Context context, global::Com.Spotify.Android.Appremote.Api.ConnectionParams @params, string spotifyBestPackageName)
		{
			const string __id = "newConnector.(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Ljava/lang/String;)Lcom/spotify/android/appremote/internal/SdkRemoteClientConnector;";
			IntPtr native_spotifyBestPackageName = JNIEnv.NewString (spotifyBestPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [2] = new JniArgumentValue (native_spotifyBestPackageName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_spotifyBestPackageName);
			}
		}

	}
}
