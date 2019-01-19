using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/SdkRemoteClientConnector", DoNotGenerateAcw=true)]
	public partial class SdkRemoteClientConnector : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.IRemoteClientConnector {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/field[@name='APP_ID_AUTH']"
		[Register ("APP_ID_AUTH")]
		public const string AppIdAuth = (string) "appid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/field[@name='CATEGORY']"
		[Register ("CATEGORY")]
		public const string Category = (string) "app";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/field[@name='EXTRA_REDIRECT_URI']"
		[Register ("EXTRA_REDIRECT_URI")]
		public const string ExtraRedirectUri = (string) "redirect_uri";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/field[@name='EXTRA_SCOPES']"
		[Register ("EXTRA_SCOPES")]
		public const string ExtraScopes = (string) "scopes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/field[@name='EXTRA_SHOW_AUTH_VIEW']"
		[Register ("EXTRA_SHOW_AUTH_VIEW")]
		public const string ExtraShowAuthView = (string) "show_auth_view";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/field[@name='REMOTE_CONTROL_SCOPE']"
		[Register ("REMOTE_CONTROL_SCOPE")]
		public const string RemoteControlScope = (string) "app-remote-control";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/SdkRemoteClientConnector", typeof (SdkRemoteClientConnector));
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

		protected SdkRemoteClientConnector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_Handler ()
		{
			if (cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ == null)
				cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_);
			return cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_;
		}

		static void n_Connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectionCallback)
		{
			global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback connectionCallback = (global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback> (native_connectionCallback, JniHandleOwnership.DoNotTransfer);
			__this.Connect (connectionCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClientConnector.ConnectionCallback']]"
		[Register ("connect", "(Lcom/spotify/protocol/client/RemoteClientConnector$ConnectionCallback;)V", "GetConnect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_Handler")]
		public virtual unsafe void Connect (global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback connectionCallback)
		{
			const string __id = "connect.(Lcom/spotify/protocol/client/RemoteClientConnector$ConnectionCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connectionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/method[@name='create' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.spotify.android.appremote.api.ConnectionParams'] and parameter[3][@type='java.lang.String']]"
		[Register ("create", "(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Ljava/lang/String;)Lcom/spotify/android/appremote/internal/SdkRemoteClientConnector;", "")]
		public static unsafe global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector Create (global::Android.Content.Context context, global::Com.Spotify.Android.Appremote.Api.ConnectionParams connectionParams, string spotifyPackagename)
		{
			const string __id = "create.(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Ljava/lang/String;)Lcom/spotify/android/appremote/internal/SdkRemoteClientConnector;";
			IntPtr native_spotifyPackagename = JNIEnv.NewString (spotifyPackagename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((connectionParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionParams).Handle);
				__args [2] = new JniArgumentValue (native_spotifyPackagename);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_spotifyPackagename);
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/method[@name='getDefaultImageSizeForCurrentDisplay' and count(parameter)=1 and parameter[1][@type='android.util.DisplayMetrics']]"
		[Register ("getDefaultImageSizeForCurrentDisplay", "(Landroid/util/DisplayMetrics;)I", "")]
		public static unsafe int GetDefaultImageSizeForCurrentDisplay (global::Android.Util.DisplayMetrics displayMetrics)
		{
			const string __id = "getDefaultImageSizeForCurrentDisplay.(Landroid/util/DisplayMetrics;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((displayMetrics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) displayMetrics).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_;
#pragma warning disable 0169
		static Delegate GetSetConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_Handler ()
		{
			if (cb_setConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_ == null)
				cb_setConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_);
			return cb_setConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_;
		}

		static void n_SetConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.SdkRemoteClientConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener listener = (global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionTerminatedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='SdkRemoteClientConnector']/method[@name='setConnectionTerminatedListener' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.OnConnectionTerminatedListener']]"
		[Register ("setConnectionTerminatedListener", "(Lcom/spotify/protocol/client/OnConnectionTerminatedListener;)V", "GetSetConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_Handler")]
		public virtual unsafe void SetConnectionTerminatedListener (global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener listener)
		{
			const string __id = "setConnectionTerminatedListener.(Lcom/spotify/protocol/client/OnConnectionTerminatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener"
		public event EventHandler ConnectionTerminated {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener, global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor>(
						ref weak_implementor_SetConnectionTerminatedListener,
						__CreateIOnConnectionTerminatedListenerImplementor,
						SetConnectionTerminatedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener, global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor>(
						ref weak_implementor_SetConnectionTerminatedListener,
						global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor.__IsEmpty,
						__v => SetConnectionTerminatedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetConnectionTerminatedListener;

		global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor __CreateIOnConnectionTerminatedListenerImplementor ()
		{
			return new global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor (this);
		}
#endregion
	}
}
