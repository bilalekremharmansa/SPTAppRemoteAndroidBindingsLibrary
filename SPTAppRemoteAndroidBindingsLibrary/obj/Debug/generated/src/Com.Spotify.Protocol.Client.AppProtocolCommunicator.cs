using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/AppProtocolCommunicator", DoNotGenerateAcw=true)]
	public partial class AppProtocolCommunicator : global::Java.Lang.Object, global::Com.Spotify.Protocol.IWampClientSender, global::Com.Spotify.Protocol.Client.IAppProtocolIoDataInput {


		public static class InterfaceConsts {

			// The following are fields from: com.spotify.protocol.WampClient

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient']/field[@name='ERROR_INVALID_ARGUMENT']"
			[Register ("ERROR_INVALID_ARGUMENT")]
			public const string ErrorInvalidArgument = (string) "wamp.error.invalid_argument";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient']/field[@name='ERROR_INVALID_URI']"
			[Register ("ERROR_INVALID_URI")]
			public const string ErrorInvalidUri = (string) "wamp.error.invalid_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient']/field[@name='WAMP_CLIENT_REQUEST_SYSTEM_SHUTDOWN']"
			[Register ("WAMP_CLIENT_REQUEST_SYSTEM_SHUTDOWN")]
			public const string WampClientRequestSystemShutdown = (string) "wamp.client_request.system_shutdown";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient']/field[@name='WAMP_ERROR']"
			[Register ("WAMP_ERROR")]
			public const string WampError = (string) "wamp.error";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient']/field[@name='WAMP_ERROR_SYSTEM_SHUTDOWN']"
			[Register ("WAMP_ERROR_SYSTEM_SHUTDOWN")]
			public const string WampErrorSystemShutdown = (string) "wamp.error.system_shutdown";
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/AppProtocolCommunicator", typeof (AppProtocolCommunicator));
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

		protected AppProtocolCommunicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/constructor[@name='AppProtocolCommunicator' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.client.ConnectionDetails'] and parameter[2][@type='com.spotify.protocol.mappers.JsonMapper'] and parameter[3][@type='com.spotify.protocol.client.AppProtocolIo']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/ConnectionDetails;Lcom/spotify/protocol/mappers/JsonMapper;Lcom/spotify/protocol/client/AppProtocolIo;)V", "")]
		public unsafe AppProtocolCommunicator (global::Com.Spotify.Protocol.Client.ConnectionDetails connectionDetails, global::Com.Spotify.Protocol.Mappers.IJsonMapper mapper, global::Com.Spotify.Protocol.Client.IAppProtocolIo protocolIo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/client/ConnectionDetails;Lcom/spotify/protocol/mappers/JsonMapper;Lcom/spotify/protocol/client/AppProtocolIo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((connectionDetails == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionDetails).Handle);
				__args [1] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [2] = new JniArgumentValue ((protocolIo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocolIo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onData_arrayBI;
#pragma warning disable 0169
		static Delegate GetOnData_arrayBIHandler ()
		{
			if (cb_onData_arrayBI == null)
				cb_onData_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnData_arrayBI);
			return cb_onData_arrayBI;
		}

		static void n_OnData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int length)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnData (data, length);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='onData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("onData", "([BI)V", "GetOnData_arrayBIHandler")]
		public virtual unsafe void OnData (byte[] data, int length)
		{
			const string __id = "onData.([BI)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_sendCall_ILjava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendCall_ILjava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_sendCall_ILjava_lang_Object_Ljava_lang_String_ == null)
				cb_sendCall_ILjava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendCall_ILjava_lang_Object_Ljava_lang_String_);
			return cb_sendCall_ILjava_lang_Object_Ljava_lang_String_;
		}

		static void n_SendCall_ILjava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int requestId, IntPtr native_options, IntPtr native_procedureUri)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			__this.SendCall (requestId, options, procedureUri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendCall' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendCall", "(ILjava/lang/Object;Ljava/lang/String;)V", "GetSendCall_ILjava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void SendCall (int requestId, global::Java.Lang.Object options, string procedureUri)
		{
			const string __id = "sendCall.(ILjava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_procedureUri = JNIEnv.NewString (procedureUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue (native_procedureUri);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_procedureUri);
			}
		}

		static Delegate cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ == null)
				cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_);
			return cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, int requestId, IntPtr native_options, IntPtr native_procedureUri, IntPtr native_arguments)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			var arguments = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_arguments, JniHandleOwnership.DoNotTransfer);
			__this.SendCall (requestId, options, procedureUri, arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendCall' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.Object&gt;']]"
		[Register ("sendCall", "(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;)V", "GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void SendCall (int requestId, global::Java.Lang.Object options, string procedureUri, global::System.Collections.Generic.IList<global::Java.Lang.Object> arguments)
		{
			const string __id = "sendCall.(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_procedureUri = JNIEnv.NewString (procedureUri);
			IntPtr native_arguments = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (requestId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue (native_procedureUri);
				__args [3] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_procedureUri);
				JNIEnv.DeleteLocalRef (native_arguments);
			}
		}

		static Delegate cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_Handler ()
		{
			if (cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ == null)
				cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_);
			return cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_;
		}

		static void n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int requestId, IntPtr native_options, IntPtr native_procedureUri, IntPtr native_arguments, IntPtr native_item)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			var arguments = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_arguments, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			__this.SendCall (requestId, options, procedureUri, arguments, item);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendCall' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.Object&gt;'] and parameter[5][@type='java.lang.Object']]"
		[Register ("sendCall", "(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;Ljava/lang/Object;)V", "GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_Handler")]
		public virtual unsafe void SendCall (int requestId, global::Java.Lang.Object options, string procedureUri, global::System.Collections.Generic.IList<global::Java.Lang.Object> arguments, global::Java.Lang.Object item)
		{
			const string __id = "sendCall.(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;Ljava/lang/Object;)V";
			IntPtr native_procedureUri = JNIEnv.NewString (procedureUri);
			IntPtr native_arguments = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (requestId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue (native_procedureUri);
				__args [3] = new JniArgumentValue (native_arguments);
				__args [4] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_procedureUri);
				JNIEnv.DeleteLocalRef (native_arguments);
			}
		}

		static Delegate cb_sendCancel_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSendCancel_ILjava_lang_Object_Handler ()
		{
			if (cb_sendCancel_ILjava_lang_Object_ == null)
				cb_sendCancel_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SendCancel_ILjava_lang_Object_);
			return cb_sendCancel_ILjava_lang_Object_;
		}

		static void n_SendCancel_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int requestId, IntPtr native_options)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.SendCancel (requestId, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendCancel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("sendCancel", "(ILjava/lang/Object;)V", "GetSendCancel_ILjava_lang_Object_Handler")]
		public virtual unsafe void SendCancel (int requestId, global::Java.Lang.Object options)
		{
			const string __id = "sendCancel.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (requestId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendGoodbye;
#pragma warning disable 0169
		static Delegate GetSendGoodbyeHandler ()
		{
			if (cb_sendGoodbye == null)
				cb_sendGoodbye = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendGoodbye);
			return cb_sendGoodbye;
		}

		static void n_SendGoodbye (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendGoodbye ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendGoodbye' and count(parameter)=0]"
		[Register ("sendGoodbye", "()V", "GetSendGoodbyeHandler")]
		public virtual unsafe void SendGoodbye ()
		{
			const string __id = "sendGoodbye.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sendHello;
#pragma warning disable 0169
		static Delegate GetSendHelloHandler ()
		{
			if (cb_sendHello == null)
				cb_sendHello = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendHello);
			return cb_sendHello;
		}

		static void n_SendHello (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendHello ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendHello' and count(parameter)=0]"
		[Register ("sendHello", "()V", "GetSendHelloHandler")]
		public virtual unsafe void SendHello ()
		{
			const string __id = "sendHello.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendSubscribe_ILjava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_ == null)
				cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendSubscribe_ILjava_lang_Object_Ljava_lang_String_);
			return cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_;
		}

		static void n_SendSubscribe_ILjava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int requestId, IntPtr native_options, IntPtr native_topicUri)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			string topicUri = JNIEnv.GetString (native_topicUri, JniHandleOwnership.DoNotTransfer);
			__this.SendSubscribe (requestId, options, topicUri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendSubscribe' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendSubscribe", "(ILjava/lang/Object;Ljava/lang/String;)V", "GetSendSubscribe_ILjava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void SendSubscribe (int requestId, global::Java.Lang.Object options, string topicUri)
		{
			const string __id = "sendSubscribe.(ILjava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_topicUri = JNIEnv.NewString (topicUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestId);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue (native_topicUri);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicUri);
			}
		}

		static Delegate cb_sendUnsubscribe_II;
#pragma warning disable 0169
		static Delegate GetSendUnsubscribe_IIHandler ()
		{
			if (cb_sendUnsubscribe_II == null)
				cb_sendUnsubscribe_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SendUnsubscribe_II);
			return cb_sendUnsubscribe_II;
		}

		static void n_SendUnsubscribe_II (IntPtr jnienv, IntPtr native__this, int requestId, int subscriptionId)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendUnsubscribe (requestId, subscriptionId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='sendUnsubscribe' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("sendUnsubscribe", "(II)V", "GetSendUnsubscribe_IIHandler")]
		public virtual unsafe void SendUnsubscribe (int requestId, int subscriptionId)
		{
			const string __id = "sendUnsubscribe.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (requestId);
				__args [1] = new JniArgumentValue (subscriptionId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
#pragma warning disable 0169
		static Delegate GetSetMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler ()
		{
			if (cb_setMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == null)
				cb_setMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_);
			return cb_setMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		}

		static void n_SetMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			global::Com.Spotify.Protocol.Client.AppProtocolCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.AppProtocolCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.IWampClientReceiver receiver = (global::Com.Spotify.Protocol.IWampClientReceiver)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageReceiver (receiver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='AppProtocolCommunicator']/method[@name='setMessageReceiver' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampClient.Receiver']]"
		[Register ("setMessageReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V", "GetSetMessageReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler")]
		public virtual unsafe void SetMessageReceiver (global::Com.Spotify.Protocol.IWampClientReceiver receiver)
		{
			const string __id = "setMessageReceiver.(Lcom/spotify/protocol/WampClient$Receiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
