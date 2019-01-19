using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClientConnector.ConnectionCallback']"
	[Register ("com/spotify/protocol/client/RemoteClientConnector$ConnectionCallback", "", "Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallbackInvoker")]
	public partial interface IRemoteClientConnectorConnectionCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClientConnector.ConnectionCallback']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register ("onConnected", "(Lcom/spotify/protocol/client/RemoteClient;)V", "GetOnConnected_Lcom_spotify_protocol_client_RemoteClient_Handler:Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallbackInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnConnected (global::Com.Spotify.Protocol.Client.IRemoteClient p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClientConnector.ConnectionCallback']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onConnectionFailed", "(Ljava/lang/Throwable;)V", "GetOnConnectionFailed_Ljava_lang_Throwable_Handler:Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallbackInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnConnectionFailed (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/RemoteClientConnector$ConnectionCallback", DoNotGenerateAcw=true)]
	internal class IRemoteClientConnectorConnectionCallbackInvoker : global::Java.Lang.Object, IRemoteClientConnectorConnectionCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/RemoteClientConnector$ConnectionCallback", typeof (IRemoteClientConnectorConnectionCallbackInvoker));

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

		public static IRemoteClientConnectorConnectionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteClientConnectorConnectionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.RemoteClientConnector.ConnectionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteClientConnectorConnectionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnected_Lcom_spotify_protocol_client_RemoteClient_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Lcom_spotify_protocol_client_RemoteClient_Handler ()
		{
			if (cb_onConnected_Lcom_spotify_protocol_client_RemoteClient_ == null)
				cb_onConnected_Lcom_spotify_protocol_client_RemoteClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Lcom_spotify_protocol_client_RemoteClient_);
			return cb_onConnected_Lcom_spotify_protocol_client_RemoteClient_;
		}

		static void n_OnConnected_Lcom_spotify_protocol_client_RemoteClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IRemoteClient p0 = (global::Com.Spotify.Protocol.Client.IRemoteClient)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnected_Lcom_spotify_protocol_client_RemoteClient_;
		public unsafe void OnConnected (global::Com.Spotify.Protocol.Client.IRemoteClient p0)
		{
			if (id_onConnected_Lcom_spotify_protocol_client_RemoteClient_ == IntPtr.Zero)
				id_onConnected_Lcom_spotify_protocol_client_RemoteClient_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lcom/spotify/protocol/client/RemoteClient;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Lcom_spotify_protocol_client_RemoteClient_, __args);
		}

		static Delegate cb_onConnectionFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onConnectionFailed_Ljava_lang_Throwable_ == null)
				cb_onConnectionFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionFailed_Ljava_lang_Throwable_);
			return cb_onConnectionFailed_Ljava_lang_Throwable_;
		}

		static void n_OnConnectionFailed_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionFailed_Ljava_lang_Throwable_;
		public unsafe void OnConnectionFailed (global::Java.Lang.Throwable p0)
		{
			if (id_onConnectionFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onConnectionFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionFailed_Ljava_lang_Throwable_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClientConnector']"
	[Register ("com/spotify/protocol/client/RemoteClientConnector", "", "Com.Spotify.Protocol.Client.IRemoteClientConnectorInvoker")]
	public partial interface IRemoteClientConnector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClientConnector']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClientConnector.ConnectionCallback']]"
		[Register ("connect", "(Lcom/spotify/protocol/client/RemoteClientConnector$ConnectionCallback;)V", "GetConnect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_Handler:Com.Spotify.Protocol.Client.IRemoteClientConnectorInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Connect (global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClientConnector']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:Com.Spotify.Protocol.Client.IRemoteClientConnectorInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Disconnect ();

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/RemoteClientConnector", DoNotGenerateAcw=true)]
	internal class IRemoteClientConnectorInvoker : global::Java.Lang.Object, IRemoteClientConnector {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/RemoteClientConnector", typeof (IRemoteClientConnectorInvoker));

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

		public static IRemoteClientConnector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteClientConnector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.RemoteClientConnector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteClientConnectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_Handler ()
		{
			if (cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ == null)
				cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_);
			return cb_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_;
		}

		static void n_Connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClientConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClientConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback p0 = (global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		IntPtr id_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_;
		public unsafe void Connect (global::Com.Spotify.Protocol.Client.IRemoteClientConnectorConnectionCallback p0)
		{
			if (id_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ == IntPtr.Zero)
				id_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/spotify/protocol/client/RemoteClientConnector$ConnectionCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_spotify_protocol_client_RemoteClientConnector_ConnectionCallback_, __args);
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
			global::Com.Spotify.Protocol.Client.IRemoteClientConnector __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClientConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
		}

	}

}
