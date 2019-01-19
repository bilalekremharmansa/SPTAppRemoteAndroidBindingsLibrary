using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/RemoteServiceIo", DoNotGenerateAcw=true)]
	public partial class RemoteServiceIo : global::Java.Lang.Object, global::Android.Content.IServiceConnection, global::Com.Spotify.Protocol.Client.IAppProtocolIo {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/RemoteServiceIo", typeof (RemoteServiceIo));
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

		protected RemoteServiceIo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/constructor[@name='RemoteServiceIo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe RemoteServiceIo (string spotifyPackageName, global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_spotifyPackageName = JNIEnv.NewString (spotifyPackageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_spotifyPackageName);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_spotifyPackageName);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				const string __id = "isConnecting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static IntPtr n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lcom/spotify/protocol/client/PendingResult;", "GetConnectHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.IPendingResult Connect ()
		{
			const string __id = "connect.()Lcom/spotify/protocol/client/PendingResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_service)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName name = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder service = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_service, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (name, service);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual unsafe void OnServiceConnected (global::Android.Content.ComponentName name, global::Android.OS.IBinder service)
		{
			const string __id = "onServiceConnected.(Landroid/content/ComponentName;Landroid/os/IBinder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName name = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_name, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnServiceDisconnected (global::Android.Content.ComponentName name)
		{
			const string __id = "onServiceDisconnected.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_;
#pragma warning disable 0169
		static Delegate GetSetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_Handler ()
		{
			if (cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ == null)
				cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_);
			return cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_;
		}

		static void n_SetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataInput)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput dataInput = (global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput> (native_dataInput, JniHandleOwnership.DoNotTransfer);
			__this.SetDataInput (dataInput);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='setDataInput' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.AppProtocolIo.DataInput']]"
		[Register ("setDataInput", "(Lcom/spotify/protocol/client/AppProtocolIo$DataInput;)V", "GetSetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_Handler")]
		public virtual unsafe void SetDataInput (global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput dataInput)
		{
			const string __id = "setDataInput.(Lcom/spotify/protocol/client/AppProtocolIo$DataInput;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataInput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataInput).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_Handler ()
		{
			if (cb_setOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_ == null)
				cb_setOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_);
			return cb_setOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_;
		}

		static void n_SetOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener listener = (global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnConnectionTerminatedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='setOnConnectionTerminatedListener' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.OnConnectionTerminatedListener']]"
		[Register ("setOnConnectionTerminatedListener", "(Lcom/spotify/protocol/client/OnConnectionTerminatedListener;)V", "GetSetOnConnectionTerminatedListener_Lcom_spotify_protocol_client_OnConnectionTerminatedListener_Handler")]
		public virtual unsafe void SetOnConnectionTerminatedListener (global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener listener)
		{
			const string __id = "setOnConnectionTerminatedListener.(Lcom/spotify/protocol/client/OnConnectionTerminatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeData_arrayBI;
#pragma warning disable 0169
		static Delegate GetWriteData_arrayBIHandler ()
		{
			if (cb_writeData_arrayBI == null)
				cb_writeData_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteData_arrayBI);
			return cb_writeData_arrayBI;
		}

		static void n_WriteData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_message, int length)
		{
			global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.RemoteServiceIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] message = (byte[]) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteData (message, length);
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='RemoteServiceIo']/method[@name='writeData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("writeData", "([BI)V", "GetWriteData_arrayBIHandler")]
		public virtual unsafe void WriteData (byte[] message, int length)
		{
			const string __id = "writeData.([BI)V";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
			}
		}

#region "Event implementation for Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener"
		public event EventHandler ConnectionTerminated {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener, global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor>(
						ref weak_implementor_SetOnConnectionTerminatedListener,
						__CreateIOnConnectionTerminatedListenerImplementor,
						SetOnConnectionTerminatedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener, global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor>(
						ref weak_implementor_SetOnConnectionTerminatedListener,
						global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor.__IsEmpty,
						__v => SetOnConnectionTerminatedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnConnectionTerminatedListener;

		global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor __CreateIOnConnectionTerminatedListenerImplementor ()
		{
			return new global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerImplementor (this);
		}
#endregion
	}
}
