using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='CallResult']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/CallResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class CallResult : global::Com.Spotify.Protocol.Client.PendingResultBase {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='CallResult.ResultCallback']"
		[Register ("com/spotify/protocol/client/CallResult$ResultCallback", "", "Com.Spotify.Protocol.Client.CallResult/IResultCallbackInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IResultCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='CallResult.ResultCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("onResult", "(Ljava/lang/Object;)V", "GetOnResult_Ljava_lang_Object_Handler:Com.Spotify.Protocol.Client.CallResult/IResultCallbackInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void OnResult (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/spotify/protocol/client/CallResult$ResultCallback", DoNotGenerateAcw=true)]
		internal class IResultCallbackInvoker : global::Java.Lang.Object, IResultCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/CallResult$ResultCallback", typeof (IResultCallbackInvoker));

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

			public static IResultCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResultCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.CallResult.ResultCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResultCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResult_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnResult_Ljava_lang_Object_Handler ()
			{
				if (cb_onResult_Ljava_lang_Object_ == null)
					cb_onResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Ljava_lang_Object_);
				return cb_onResult_Ljava_lang_Object_;
			}

			static void n_OnResult_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Protocol.Client.CallResult.IResultCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult.IResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResult_Ljava_lang_Object_;
			public unsafe void OnResult (global::Java.Lang.Object p0)
			{
				if (id_onResult_Ljava_lang_Object_ == IntPtr.Zero)
					id_onResult_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/CallResult", typeof (CallResult));
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

		protected CallResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='CallResult']/constructor[@name='CallResult' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Types$RequestId;)V", "")]
		public unsafe CallResult (global::Com.Spotify.Protocol.Types.TypesRequestId requestId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Types$RequestId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.CallResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestId);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Protocol.Types.TypesRequestId RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='CallResult']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Lcom/spotify/protocol/types/Types$RequestId;", "GetGetRequestIdHandler")]
			get {
				const string __id = "getRequestId.()Lcom/spotify/protocol/types/Types$RequestId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onResultDelivered;
#pragma warning disable 0169
		static Delegate GetOnResultDeliveredHandler ()
		{
			if (cb_onResultDelivered == null)
				cb_onResultDelivered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResultDelivered);
			return cb_onResultDelivered;
		}

		static void n_OnResultDelivered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.CallResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResultDelivered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='CallResult']/method[@name='onResultDelivered' and count(parameter)=0]"
		[Register ("onResultDelivered", "()V", "GetOnResultDeliveredHandler")]
		protected override unsafe void OnResultDelivered ()
		{
			const string __id = "onResultDelivered.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_;
#pragma warning disable 0169
		static Delegate GetSetResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_Handler ()
		{
			if (cb_setResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_ == null)
				cb_setResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_);
			return cb_setResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_;
		}

		static IntPtr n_SetResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Spotify.Protocol.Client.CallResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.CallResult.IResultCallback @callback = (global::Com.Spotify.Protocol.Client.CallResult.IResultCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult.IResultCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResultCallback (@callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='CallResult']/method[@name='setResultCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.CallResult.ResultCallback&lt;T&gt;']]"
		[Register ("setResultCallback", "(Lcom/spotify/protocol/client/CallResult$ResultCallback;)Lcom/spotify/protocol/client/CallResult;", "GetSetResultCallback_Lcom_spotify_protocol_client_CallResult_ResultCallback_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult SetResultCallback (global::Com.Spotify.Protocol.Client.CallResult.IResultCallback @callback)
		{
			const string __id = "setResultCallback.(Lcom/spotify/protocol/client/CallResult$ResultCallback;)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
