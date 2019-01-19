using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='Connector.ConnectionListener']"
	[Register ("com/spotify/android/appremote/api/Connector$ConnectionListener", "", "Com.Spotify.Android.Appremote.Api.IConnectorConnectionListenerInvoker")]
	public partial interface IConnectorConnectionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='Connector.ConnectionListener']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.SpotifyAppRemote']]"
		[Register ("onConnected", "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V", "GetOnConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_Handler:Com.Spotify.Android.Appremote.Api.IConnectorConnectionListenerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnConnected (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='Connector.ConnectionListener']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Ljava/lang/Throwable;)V", "GetOnFailure_Ljava_lang_Throwable_Handler:Com.Spotify.Android.Appremote.Api.IConnectorConnectionListenerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnFailure (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/Connector$ConnectionListener", DoNotGenerateAcw=true)]
	internal class IConnectorConnectionListenerInvoker : global::Java.Lang.Object, IConnectorConnectionListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/Connector$ConnectionListener", typeof (IConnectorConnectionListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConnectorConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectorConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.Connector.ConnectionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectorConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_Handler ()
		{
			if (cb_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ == null)
				cb_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_);
			return cb_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_;
		}

		static void n_OnConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_;
		public unsafe void OnConnected (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0)
		{
			if (id_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ == IntPtr.Zero)
				id_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Lcom_spotify_android_appremote_api_SpotifyAppRemote_, __args);
		}

		static Delegate cb_onFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Throwable_ == null)
				cb_onFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Throwable_);
			return cb_onFailure_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_Throwable_;
		public unsafe void OnFailure (global::Java.Lang.Throwable p0)
		{
			if (id_onFailure_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_Throwable_, __args);
		}

	}

	// event args for com.spotify.android.appremote.api.Connector.ConnectionListener.onConnected
	public partial class ConnectedEventArgs : global::System.EventArgs {

		public ConnectedEventArgs (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0)
		{
			this.p0 = p0;
		}

		global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0;
		public global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote P0 {
			get { return p0; }
		}
	}

	// event args for com.spotify.android.appremote.api.Connector.ConnectionListener.onFailure
	public partial class FailureEventArgs : global::System.EventArgs {

		public FailureEventArgs (global::Java.Lang.Throwable p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Throwable p0;
		public global::Java.Lang.Throwable P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/spotify/android/appremote/api/Connector_ConnectionListenerImplementor")]
	internal sealed partial class IConnectorConnectionListenerImplementor : global::Java.Lang.Object, IConnectorConnectionListener {

		object sender;

		public IConnectorConnectionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/spotify/android/appremote/api/Connector_ConnectionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectedEventArgs> OnConnectedHandler;
#pragma warning restore 0649

		public void OnConnected (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0)
		{
			var __h = OnConnectedHandler;
			if (__h != null)
				__h (sender, new ConnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

		public void OnFailure (global::Java.Lang.Throwable p0)
		{
			var __h = OnFailureHandler;
			if (__h != null)
				__h (sender, new FailureEventArgs (p0));
		}

		internal static bool __IsEmpty (IConnectorConnectionListenerImplementor value)
		{
			return value.OnConnectedHandler == null && value.OnFailureHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='Connector']"
	[Register ("com/spotify/android/appremote/api/Connector", "", "Com.Spotify.Android.Appremote.Api.IConnectorInvoker")]
	public partial interface IConnector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='Connector']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.spotify.android.appremote.api.ConnectionParams'] and parameter[3][@type='com.spotify.android.appremote.api.Connector.ConnectionListener']]"
		[Register ("connect", "(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Lcom/spotify/android/appremote/api/Connector$ConnectionListener;)V", "GetConnect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_Handler:Com.Spotify.Android.Appremote.Api.IConnectorInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Connect (global::Android.Content.Context p0, global::Com.Spotify.Android.Appremote.Api.ConnectionParams p1, global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='Connector']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.SpotifyAppRemote']]"
		[Register ("disconnect", "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V", "GetDisconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_Handler:Com.Spotify.Android.Appremote.Api.IConnectorInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Disconnect (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0);

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/Connector", DoNotGenerateAcw=true)]
	internal class IConnectorInvoker : global::Java.Lang.Object, IConnector {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/Connector", typeof (IConnectorInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConnector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.Connector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_Handler ()
		{
			if (cb_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_ == null)
				cb_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_);
			return cb_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_;
		}

		static void n_Connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Android.Appremote.Api.IConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener p2 = (global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_;
		public unsafe void Connect (global::Android.Content.Context p0, global::Com.Spotify.Android.Appremote.Api.ConnectionParams p1, global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener p2)
		{
			if (id_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_ == IntPtr.Zero)
				id_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Lcom/spotify/android/appremote/api/Connector$ConnectionListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Landroid_content_Context_Lcom_spotify_android_appremote_api_ConnectionParams_Lcom_spotify_android_appremote_api_Connector_ConnectionListener_, __args);
		}

		static Delegate cb_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_Handler ()
		{
			if (cb_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ == null)
				cb_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_);
			return cb_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_;
		}

		static void n_Disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_;
		public unsafe void Disconnect (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote p0)
		{
			if (id_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ == IntPtr.Zero)
				id_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Lcom_spotify_android_appremote_api_SpotifyAppRemote_, __args);
		}

	}

}
