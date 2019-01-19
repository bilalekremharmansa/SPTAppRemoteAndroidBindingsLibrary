using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']"
	[Register ("com/spotify/protocol/WampClient$Receiver", "", "Com.Spotify.Protocol.IWampClientReceiverInvoker")]
	public partial interface IWampClientReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onAbort' and count(parameter)=2 and parameter[1][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAbort", "(Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V", "GetOnAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnAbort (global::Com.Spotify.Protocol.Mappers.IJsonObject p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId'] and parameter[2][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[3][@type='java.lang.String']]"
		[Register ("onError", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V", "GetOnError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnError (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.types.Types.SubscriptionId'] and parameter[2][@type='int'] and parameter[3][@type='com.spotify.protocol.mappers.JsonObject']]"
		[Register ("onEvent", "(Lcom/spotify/protocol/types/Types$SubscriptionId;ILcom/spotify/protocol/mappers/JsonObject;)V", "GetOnEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnEvent (global::Com.Spotify.Protocol.Types.TypesSubscriptionId p0, int p1, global::Com.Spotify.Protocol.Mappers.IJsonObject p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onGoodbye' and count(parameter)=2 and parameter[1][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("onGoodbye", "(Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V", "GetOnGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnGoodbye (global::Com.Spotify.Protocol.Mappers.IJsonObject p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onResult' and count(parameter)=4 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId'] and parameter[2][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[3][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[4][@type='com.spotify.protocol.mappers.JsonObject']]"
		[Register ("onResult", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Lcom/spotify/protocol/mappers/JsonObject;Lcom/spotify/protocol/mappers/JsonObject;)V", "GetOnResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnResult (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, global::Com.Spotify.Protocol.Mappers.IJsonObject p2, global::Com.Spotify.Protocol.Mappers.IJsonObject p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onSubscribeError' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId'] and parameter[2][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[3][@type='java.lang.String']]"
		[Register ("onSubscribeError", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V", "GetOnSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnSubscribeError (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onSubscribed' and count(parameter)=2 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId'] and parameter[2][@type='com.spotify.protocol.types.Types.SubscriptionId']]"
		[Register ("onSubscribed", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/types/Types$SubscriptionId;)V", "GetOnSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnSubscribed (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Types.TypesSubscriptionId p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onUnsubscribed' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId']]"
		[Register ("onUnsubscribed", "(Lcom/spotify/protocol/types/Types$RequestId;)V", "GetOnUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnUnsubscribed (global::Com.Spotify.Protocol.Types.TypesRequestId p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onUnubscribeError' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId'] and parameter[2][@type='com.spotify.protocol.mappers.JsonObject'] and parameter[3][@type='java.lang.String']]"
		[Register ("onUnubscribeError", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V", "GetOnUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnUnubscribeError (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Receiver']/method[@name='onWelcome' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.spotify.protocol.mappers.JsonObject']]"
		[Register ("onWelcome", "(ILcom/spotify/protocol/mappers/JsonObject;)V", "GetOnWelcome_ILcom_spotify_protocol_mappers_JsonObject_Handler:Com.Spotify.Protocol.IWampClientReceiverInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnWelcome (int p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/WampClient$Receiver", DoNotGenerateAcw=true)]
	internal class IWampClientReceiverInvoker : global::Java.Lang.Object, IWampClientReceiver {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/WampClient$Receiver", typeof (IWampClientReceiverInvoker));

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

		public static IWampClientReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWampClientReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.WampClient.Receiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWampClientReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler ()
		{
			if (cb_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == null)
				cb_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_);
			return cb_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		}

		static void n_OnAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p0 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAbort (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		public unsafe void OnAbort (global::Com.Spotify.Protocol.Mappers.IJsonObject p0, string p1)
		{
			if (id_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == IntPtr.Zero)
				id_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAbort", "(Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAbort_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler ()
		{
			if (cb_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == null)
				cb_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_);
			return cb_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		}

		static void n_OnError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesRequestId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p1 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		public unsafe void OnError (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, string p2)
		{
			if (id_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == IntPtr.Zero)
				id_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_Handler ()
		{
			if (cb_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_ == null)
				cb_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_);
			return cb_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_;
		}

		static void n_OnEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesSubscriptionId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesSubscriptionId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p2 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_;
		public unsafe void OnEvent (global::Com.Spotify.Protocol.Types.TypesSubscriptionId p0, int p1, global::Com.Spotify.Protocol.Mappers.IJsonObject p2)
		{
			if (id_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_ == IntPtr.Zero)
				id_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lcom/spotify/protocol/types/Types$SubscriptionId;ILcom/spotify/protocol/mappers/JsonObject;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Lcom_spotify_protocol_types_Types_SubscriptionId_ILcom_spotify_protocol_mappers_JsonObject_, __args);
		}

		static Delegate cb_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler ()
		{
			if (cb_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == null)
				cb_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_);
			return cb_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		}

		static void n_OnGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p0 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGoodbye (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		public unsafe void OnGoodbye (global::Com.Spotify.Protocol.Mappers.IJsonObject p0, string p1)
		{
			if (id_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == IntPtr.Zero)
				id_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onGoodbye", "(Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGoodbye_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Handler ()
		{
			if (cb_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_ == null)
				cb_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_);
			return cb_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_;
		}

		static void n_OnResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesRequestId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p1 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p2 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p3 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_;
		public unsafe void OnResult (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, global::Com.Spotify.Protocol.Mappers.IJsonObject p2, global::Com.Spotify.Protocol.Mappers.IJsonObject p3)
		{
			if (id_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_ == IntPtr.Zero)
				id_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Lcom/spotify/protocol/mappers/JsonObject;Lcom/spotify/protocol/mappers/JsonObject;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_Lcom_spotify_protocol_mappers_JsonObject_, __args);
		}

		static Delegate cb_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler ()
		{
			if (cb_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == null)
				cb_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_);
			return cb_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		}

		static void n_OnSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesRequestId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p1 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribeError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		public unsafe void OnSubscribeError (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, string p2)
		{
			if (id_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == IntPtr.Zero)
				id_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSubscribeError", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_;
#pragma warning disable 0169
		static Delegate GetOnSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_Handler ()
		{
			if (cb_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_ == null)
				cb_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_);
			return cb_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_;
		}

		static void n_OnSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesRequestId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesSubscriptionId p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesSubscriptionId> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_;
		public unsafe void OnSubscribed (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Types.TypesSubscriptionId p1)
		{
			if (id_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_ == IntPtr.Zero)
				id_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_ = JNIEnv.GetMethodID (class_ref, "onSubscribed", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/types/Types$SubscriptionId;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribed_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_types_Types_SubscriptionId_, __args);
		}

		static Delegate cb_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_;
#pragma warning disable 0169
		static Delegate GetOnUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_Handler ()
		{
			if (cb_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_ == null)
				cb_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_);
			return cb_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_;
		}

		static void n_OnUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesRequestId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnsubscribed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_;
		public unsafe void OnUnsubscribed (global::Com.Spotify.Protocol.Types.TypesRequestId p0)
		{
			if (id_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_ == IntPtr.Zero)
				id_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_ = JNIEnv.GetMethodID (class_ref, "onUnsubscribed", "(Lcom/spotify/protocol/types/Types$RequestId;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnsubscribed_Lcom_spotify_protocol_types_Types_RequestId_, __args);
		}

		static Delegate cb_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_Handler ()
		{
			if (cb_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == null)
				cb_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_);
			return cb_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		}

		static void n_OnUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.TypesRequestId p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p1 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUnubscribeError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_;
		public unsafe void OnUnubscribeError (global::Com.Spotify.Protocol.Types.TypesRequestId p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1, string p2)
		{
			if (id_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ == IntPtr.Zero)
				id_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUnubscribeError", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/mappers/JsonObject;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnubscribeError_Lcom_spotify_protocol_types_Types_RequestId_Lcom_spotify_protocol_mappers_JsonObject_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_;
#pragma warning disable 0169
		static Delegate GetOnWelcome_ILcom_spotify_protocol_mappers_JsonObject_Handler ()
		{
			if (cb_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_ == null)
				cb_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnWelcome_ILcom_spotify_protocol_mappers_JsonObject_);
			return cb_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_;
		}

		static void n_OnWelcome_ILcom_spotify_protocol_mappers_JsonObject_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.IWampClientReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Mappers.IJsonObject p1 = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWelcome (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_;
		public unsafe void OnWelcome (int p0, global::Com.Spotify.Protocol.Mappers.IJsonObject p1)
		{
			if (id_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_ == IntPtr.Zero)
				id_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_ = JNIEnv.GetMethodID (class_ref, "onWelcome", "(ILcom/spotify/protocol/mappers/JsonObject;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWelcome_ILcom_spotify_protocol_mappers_JsonObject_, __args);
		}

	}


	[Register ("com/spotify/protocol/WampClient$RequestType", DoNotGenerateAcw=true)]
	public abstract class WampClientRequestType : Java.Lang.Object {

		internal WampClientRequestType ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='ABORT']"
		[Register ("ABORT")]
		public const int Abort = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='CALL']"
		[Register ("CALL")]
		public const int Call = (int) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public const int Cancel = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='EVENT']"
		[Register ("EVENT")]
		public const int Event = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='GOODBYE']"
		[Register ("GOODBYE")]
		public const int Goodbye = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='HELLO']"
		[Register ("HELLO")]
		public const int Hello = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='RESULT']"
		[Register ("RESULT")]
		public const int Result = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='SUBSCRIBE']"
		[Register ("SUBSCRIBE")]
		public const int Subscribe = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='SUBSCRIBED']"
		[Register ("SUBSCRIBED")]
		public const int Subscribed = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='UNSUBSCRIBE']"
		[Register ("UNSUBSCRIBE")]
		public const int Unsubscribe = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='UNSUBSCRIBED']"
		[Register ("UNSUBSCRIBED")]
		public const int Unsubscribed = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='WELCOME']"
		[Register ("WELCOME")]
		public const int Welcome = (int) 2;
	}

	[Register ("com/spotify/protocol/WampClient$RequestType", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'WampClientRequestType' type. This type will be removed in a future release.")]
	public abstract class WampClientRequestTypeConsts : WampClientRequestType {

		private WampClientRequestTypeConsts ()
		{
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Router']"
	[Register ("com/spotify/protocol/WampClient$Router", "", "Com.Spotify.Protocol.IWampClientRouterInvoker")]
	public partial interface IWampClientRouter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Router']/method[@name='addReceiver' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampClient.Receiver']]"
		[Register ("addReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V", "GetAddReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler:Com.Spotify.Protocol.IWampClientRouterInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void AddReceiver (global::Com.Spotify.Protocol.IWampClientReceiver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Router']/method[@name='removeReceiver' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampClient.Receiver']]"
		[Register ("removeReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V", "GetRemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler:Com.Spotify.Protocol.IWampClientRouterInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void RemoveReceiver (global::Com.Spotify.Protocol.IWampClientReceiver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Router']/method[@name='route' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampMessage']]"
		[Register ("route", "(Lcom/spotify/protocol/WampMessage;)Z", "GetRoute_Lcom_spotify_protocol_WampMessage_Handler:Com.Spotify.Protocol.IWampClientRouterInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		bool Route (global::Com.Spotify.Protocol.WampMessage p0);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/WampClient$Router", DoNotGenerateAcw=true)]
	internal class IWampClientRouterInvoker : global::Java.Lang.Object, IWampClientRouter {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/WampClient$Router", typeof (IWampClientRouterInvoker));

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

		public static IWampClientRouter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWampClientRouter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.WampClient.Router"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWampClientRouterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
#pragma warning disable 0169
		static Delegate GetAddReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler ()
		{
			if (cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == null)
				cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddReceiver_Lcom_spotify_protocol_WampClient_Receiver_);
			return cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		}

		static void n_AddReceiver_Lcom_spotify_protocol_WampClient_Receiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.IWampClientRouter __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientRouter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.IWampClientReceiver p0 = (global::Com.Spotify.Protocol.IWampClientReceiver)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddReceiver (p0);
		}
#pragma warning restore 0169

		IntPtr id_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		public unsafe void AddReceiver (global::Com.Spotify.Protocol.IWampClientReceiver p0)
		{
			if (id_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == IntPtr.Zero)
				id_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNIEnv.GetMethodID (class_ref, "addReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_, __args);
		}

		static Delegate cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
#pragma warning disable 0169
		static Delegate GetRemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler ()
		{
			if (cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == null)
				cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_);
			return cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		}

		static void n_RemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.IWampClientRouter __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientRouter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.IWampClientReceiver p0 = (global::Com.Spotify.Protocol.IWampClientReceiver)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveReceiver (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		public unsafe void RemoveReceiver (global::Com.Spotify.Protocol.IWampClientReceiver p0)
		{
			if (id_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == IntPtr.Zero)
				id_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNIEnv.GetMethodID (class_ref, "removeReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_, __args);
		}

		static Delegate cb_route_Lcom_spotify_protocol_WampMessage_;
#pragma warning disable 0169
		static Delegate GetRoute_Lcom_spotify_protocol_WampMessage_Handler ()
		{
			if (cb_route_Lcom_spotify_protocol_WampMessage_ == null)
				cb_route_Lcom_spotify_protocol_WampMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Route_Lcom_spotify_protocol_WampMessage_);
			return cb_route_Lcom_spotify_protocol_WampMessage_;
		}

		static bool n_Route_Lcom_spotify_protocol_WampMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.IWampClientRouter __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientRouter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.WampMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.WampMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Route (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_route_Lcom_spotify_protocol_WampMessage_;
		public unsafe bool Route (global::Com.Spotify.Protocol.WampMessage p0)
		{
			if (id_route_Lcom_spotify_protocol_WampMessage_ == IntPtr.Zero)
				id_route_Lcom_spotify_protocol_WampMessage_ = JNIEnv.GetMethodID (class_ref, "route", "(Lcom/spotify/protocol/WampMessage;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_route_Lcom_spotify_protocol_WampMessage_, __args);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']"
	[Register ("com/spotify/protocol/WampClient$Sender", "", "Com.Spotify.Protocol.IWampClientSenderInvoker")]
	public partial interface IWampClientSender : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendCall' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendCall", "(ILjava/lang/Object;Ljava/lang/String;)V", "GetSendCall_ILjava_lang_Object_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendCall (int p0, global::Java.Lang.Object p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendCall' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.Object&gt;']]"
		[Register ("sendCall", "(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;)V", "GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Handler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendCall (int p0, global::Java.Lang.Object p1, string p2, global::System.Collections.Generic.IList<global::Java.Lang.Object> p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendCall' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.Object&gt;'] and parameter[5][@type='java.lang.Object']]"
		[Register ("sendCall", "(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;Ljava/lang/Object;)V", "GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_Handler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendCall (int p0, global::Java.Lang.Object p1, string p2, global::System.Collections.Generic.IList<global::Java.Lang.Object> p3, global::Java.Lang.Object p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendCancel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("sendCancel", "(ILjava/lang/Object;)V", "GetSendCancel_ILjava_lang_Object_Handler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendCancel (int p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendGoodbye' and count(parameter)=0]"
		[Register ("sendGoodbye", "()V", "GetSendGoodbyeHandler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendGoodbye ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendHello' and count(parameter)=0]"
		[Register ("sendHello", "()V", "GetSendHelloHandler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendHello ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendSubscribe' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendSubscribe", "(ILjava/lang/Object;Ljava/lang/String;)V", "GetSendSubscribe_ILjava_lang_Object_Ljava_lang_String_Handler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendSubscribe (int p0, global::Java.Lang.Object p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.Sender']/method[@name='sendUnsubscribe' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("sendUnsubscribe", "(II)V", "GetSendUnsubscribe_IIHandler:Com.Spotify.Protocol.IWampClientSenderInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void SendUnsubscribe (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/WampClient$Sender", DoNotGenerateAcw=true)]
	internal class IWampClientSenderInvoker : global::Java.Lang.Object, IWampClientSender {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/WampClient$Sender", typeof (IWampClientSenderInvoker));

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

		public static IWampClientSender GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWampClientSender> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.WampClient.Sender"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWampClientSenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendCall_ILjava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendCall_ILjava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_sendCall_ILjava_lang_Object_Ljava_lang_String_ == null)
				cb_sendCall_ILjava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendCall_ILjava_lang_Object_Ljava_lang_String_);
			return cb_sendCall_ILjava_lang_Object_Ljava_lang_String_;
		}

		static void n_SendCall_ILjava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendCall (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendCall_ILjava_lang_Object_Ljava_lang_String_;
		public unsafe void SendCall (int p0, global::Java.Lang.Object p1, string p2)
		{
			if (id_sendCall_ILjava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_sendCall_ILjava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendCall", "(ILjava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCall_ILjava_lang_Object_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ == null)
				cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_);
			return cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendCall (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_;
		public unsafe void SendCall (int p0, global::Java.Lang.Object p1, string p2, global::System.Collections.Generic.IList<global::Java.Lang.Object> p3)
		{
			if (id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "sendCall", "(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_Handler ()
		{
			if (cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ == null)
				cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_);
			return cb_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_;
		}

		static void n_SendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SendCall (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_;
		public unsafe void SendCall (int p0, global::Java.Lang.Object p1, string p2, global::System.Collections.Generic.IList<global::Java.Lang.Object> p3, global::Java.Lang.Object p4)
		{
			if (id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ == IntPtr.Zero)
				id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sendCall", "(ILjava/lang/Object;Ljava/lang/String;Ljava/util/List;Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCall_ILjava_lang_Object_Ljava_lang_String_Ljava_util_List_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_sendCancel_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSendCancel_ILjava_lang_Object_Handler ()
		{
			if (cb_sendCancel_ILjava_lang_Object_ == null)
				cb_sendCancel_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SendCancel_ILjava_lang_Object_);
			return cb_sendCancel_ILjava_lang_Object_;
		}

		static void n_SendCancel_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendCancel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendCancel_ILjava_lang_Object_;
		public unsafe void SendCancel (int p0, global::Java.Lang.Object p1)
		{
			if (id_sendCancel_ILjava_lang_Object_ == IntPtr.Zero)
				id_sendCancel_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sendCancel", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCancel_ILjava_lang_Object_, __args);
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
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendGoodbye ();
		}
#pragma warning restore 0169

		IntPtr id_sendGoodbye;
		public unsafe void SendGoodbye ()
		{
			if (id_sendGoodbye == IntPtr.Zero)
				id_sendGoodbye = JNIEnv.GetMethodID (class_ref, "sendGoodbye", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendGoodbye);
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
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendHello ();
		}
#pragma warning restore 0169

		IntPtr id_sendHello;
		public unsafe void SendHello ()
		{
			if (id_sendHello == IntPtr.Zero)
				id_sendHello = JNIEnv.GetMethodID (class_ref, "sendHello", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendHello);
		}

		static Delegate cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendSubscribe_ILjava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_ == null)
				cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendSubscribe_ILjava_lang_Object_Ljava_lang_String_);
			return cb_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_;
		}

		static void n_SendSubscribe_ILjava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendSubscribe (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_;
		public unsafe void SendSubscribe (int p0, global::Java.Lang.Object p1, string p2)
		{
			if (id_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendSubscribe", "(ILjava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSubscribe_ILjava_lang_Object_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendUnsubscribe_II;
#pragma warning disable 0169
		static Delegate GetSendUnsubscribe_IIHandler ()
		{
			if (cb_sendUnsubscribe_II == null)
				cb_sendUnsubscribe_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SendUnsubscribe_II);
			return cb_sendUnsubscribe_II;
		}

		static void n_SendUnsubscribe_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Spotify.Protocol.IWampClientSender __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendUnsubscribe (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendUnsubscribe_II;
		public unsafe void SendUnsubscribe (int p0, int p1)
		{
			if (id_sendUnsubscribe_II == IntPtr.Zero)
				id_sendUnsubscribe_II = JNIEnv.GetMethodID (class_ref, "sendUnsubscribe", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendUnsubscribe_II, __args);
		}

	}


	[Register ("com/spotify/protocol/WampClient", DoNotGenerateAcw=true)]
	public abstract class WampClient : Java.Lang.Object {

		internal WampClient ()
		{
		}

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

	[Register ("com/spotify/protocol/WampClient", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'WampClient' type. This type will be removed in a future release.")]
	public abstract class WampClientConsts : WampClient {

		private WampClientConsts ()
		{
		}
	}

}
