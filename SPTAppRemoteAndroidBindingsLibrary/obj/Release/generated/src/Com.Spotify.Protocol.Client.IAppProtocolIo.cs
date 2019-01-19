using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo.DataInput']"
	[Register ("com/spotify/protocol/client/AppProtocolIo$DataInput", "", "Com.Spotify.Protocol.Client.IAppProtocolIoDataInputInvoker")]
	public partial interface IAppProtocolIoDataInput : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo.DataInput']/method[@name='onData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("onData", "([BI)V", "GetOnData_arrayBIHandler:Com.Spotify.Protocol.Client.IAppProtocolIoDataInputInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnData (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/AppProtocolIo$DataInput", DoNotGenerateAcw=true)]
	internal class IAppProtocolIoDataInputInvoker : global::Java.Lang.Object, IAppProtocolIoDataInput {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/AppProtocolIo$DataInput", typeof (IAppProtocolIoDataInputInvoker));

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

		public static IAppProtocolIoDataInput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppProtocolIoDataInput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.AppProtocolIo.DataInput"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppProtocolIoDataInputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onData_arrayBI;
#pragma warning disable 0169
		static Delegate GetOnData_arrayBIHandler ()
		{
			if (cb_onData_arrayBI == null)
				cb_onData_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnData_arrayBI);
			return cb_onData_arrayBI;
		}

		static void n_OnData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onData_arrayBI;
		public unsafe void OnData (byte[] p0, int p1)
		{
			if (id_onData_arrayBI == IntPtr.Zero)
				id_onData_arrayBI = JNIEnv.GetMethodID (class_ref, "onData", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']"
	[Register ("com/spotify/protocol/client/AppProtocolIo", "", "Com.Spotify.Protocol.Client.IAppProtocolIoInvoker")]
	public partial interface IAppProtocolIo : IJavaObject {

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Com.Spotify.Protocol.Client.IAppProtocolIoInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler:Com.Spotify.Protocol.Client.IAppProtocolIoInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lcom/spotify/protocol/client/PendingResult;", "GetConnectHandler:Com.Spotify.Protocol.Client.IAppProtocolIoInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.IPendingResult Connect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:Com.Spotify.Protocol.Client.IAppProtocolIoInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']/method[@name='setDataInput' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.AppProtocolIo.DataInput']]"
		[Register ("setDataInput", "(Lcom/spotify/protocol/client/AppProtocolIo$DataInput;)V", "GetSetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_Handler:Com.Spotify.Protocol.Client.IAppProtocolIoInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SetDataInput (global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='AppProtocolIo']/method[@name='writeData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("writeData", "([BI)V", "GetWriteData_arrayBIHandler:Com.Spotify.Protocol.Client.IAppProtocolIoInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void WriteData (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/AppProtocolIo", DoNotGenerateAcw=true)]
	internal class IAppProtocolIoInvoker : global::Java.Lang.Object, IAppProtocolIo {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/AppProtocolIo", typeof (IAppProtocolIoInvoker));

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

		public static IAppProtocolIo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppProtocolIo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.AppProtocolIo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppProtocolIoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Spotify.Protocol.Client.IAppProtocolIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public unsafe bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
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
			global::Com.Spotify.Protocol.Client.IAppProtocolIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		IntPtr id_isConnecting;
		public unsafe bool IsConnecting {
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting);
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
			global::Com.Spotify.Protocol.Client.IAppProtocolIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		IntPtr id_connect;
		public unsafe global::Com.Spotify.Protocol.Client.IPendingResult Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()Lcom/spotify/protocol/client/PendingResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Protocol.Client.IAppProtocolIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_;
#pragma warning disable 0169
		static Delegate GetSetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_Handler ()
		{
			if (cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ == null)
				cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_);
			return cb_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_;
		}

		static void n_SetDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IAppProtocolIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput p0 = (global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataInput (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_;
		public unsafe void SetDataInput (global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput p0)
		{
			if (id_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ == IntPtr.Zero)
				id_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_ = JNIEnv.GetMethodID (class_ref, "setDataInput", "(Lcom/spotify/protocol/client/AppProtocolIo$DataInput;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataInput_Lcom_spotify_protocol_client_AppProtocolIo_DataInput_, __args);
		}

		static Delegate cb_writeData_arrayBI;
#pragma warning disable 0169
		static Delegate GetWriteData_arrayBIHandler ()
		{
			if (cb_writeData_arrayBI == null)
				cb_writeData_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteData_arrayBI);
			return cb_writeData_arrayBI;
		}

		static void n_WriteData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Spotify.Protocol.Client.IAppProtocolIo __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IAppProtocolIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_writeData_arrayBI;
		public unsafe void WriteData (byte[] p0, int p1)
		{
			if (id_writeData_arrayBI == IntPtr.Zero)
				id_writeData_arrayBI = JNIEnv.GetMethodID (class_ref, "writeData", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeData_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
