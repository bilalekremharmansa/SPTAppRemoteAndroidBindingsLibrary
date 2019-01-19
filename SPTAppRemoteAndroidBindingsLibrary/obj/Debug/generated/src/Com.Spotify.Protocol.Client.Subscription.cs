using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Subscription']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/Subscription", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class Subscription : global::Com.Spotify.Protocol.Client.PendingResultBase {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Subscription.EventCallback']"
		[Register ("com/spotify/protocol/client/Subscription$EventCallback", "", "Com.Spotify.Protocol.Client.Subscription/IEventCallbackInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IEventCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Subscription.EventCallback']/method[@name='onEvent' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("onEvent", "(Ljava/lang/Object;)V", "GetOnEvent_Ljava_lang_Object_Handler:Com.Spotify.Protocol.Client.Subscription/IEventCallbackInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void OnEvent (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/spotify/protocol/client/Subscription$EventCallback", DoNotGenerateAcw=true)]
		internal class IEventCallbackInvoker : global::Java.Lang.Object, IEventCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/Subscription$EventCallback", typeof (IEventCallbackInvoker));

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

			public static IEventCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEventCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.Subscription.EventCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEventCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onEvent_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnEvent_Ljava_lang_Object_Handler ()
			{
				if (cb_onEvent_Ljava_lang_Object_ == null)
					cb_onEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEvent_Ljava_lang_Object_);
				return cb_onEvent_Ljava_lang_Object_;
			}

			static void n_OnEvent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Protocol.Client.Subscription.IEventCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnEvent (p0);
			}
#pragma warning restore 0169

			IntPtr id_onEvent_Ljava_lang_Object_;
			public unsafe void OnEvent (global::Java.Lang.Object p0)
			{
				if (id_onEvent_Ljava_lang_Object_ == IntPtr.Zero)
					id_onEvent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Subscription.LifecycleCallback']"
		[Register ("com/spotify/protocol/client/Subscription$LifecycleCallback", "", "Com.Spotify.Protocol.Client.Subscription/ILifecycleCallbackInvoker")]
		public partial interface ILifecycleCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Subscription.LifecycleCallback']/method[@name='onStart' and count(parameter)=0]"
			[Register ("onStart", "()V", "GetOnStartHandler:Com.Spotify.Protocol.Client.Subscription/ILifecycleCallbackInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void OnStart ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Subscription.LifecycleCallback']/method[@name='onStop' and count(parameter)=0]"
			[Register ("onStop", "()V", "GetOnStopHandler:Com.Spotify.Protocol.Client.Subscription/ILifecycleCallbackInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void OnStop ();

		}

		[global::Android.Runtime.Register ("com/spotify/protocol/client/Subscription$LifecycleCallback", DoNotGenerateAcw=true)]
		internal class ILifecycleCallbackInvoker : global::Java.Lang.Object, ILifecycleCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/Subscription$LifecycleCallback", typeof (ILifecycleCallbackInvoker));

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

			public static ILifecycleCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILifecycleCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.Subscription.LifecycleCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILifecycleCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onStart;
#pragma warning disable 0169
			static Delegate GetOnStartHandler ()
			{
				if (cb_onStart == null)
					cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
				return cb_onStart;
			}

			static void n_OnStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStart ();
			}
#pragma warning restore 0169

			IntPtr id_onStart;
			public unsafe void OnStart ()
			{
				if (id_onStart == IntPtr.Zero)
					id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart);
			}

			static Delegate cb_onStop;
#pragma warning disable 0169
			static Delegate GetOnStopHandler ()
			{
				if (cb_onStop == null)
					cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
				return cb_onStop;
			}

			static void n_OnStop (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStop ();
			}
#pragma warning restore 0169

			IntPtr id_onStop;
			public unsafe void OnStop ()
			{
				if (id_onStop == IntPtr.Zero)
					id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStop);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/Subscription", typeof (Subscription));
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

		protected Subscription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Subscription']/constructor[@name='Subscription' and count(parameter)=2 and parameter[1][@type='com.spotify.protocol.types.Types.RequestId'] and parameter[2][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe Subscription (global::Com.Spotify.Protocol.Types.TypesRequestId requestId, global::Com.Spotify.Protocol.Client.IRemoteClient remoteWampClient)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Types$RequestId;Lcom/spotify/protocol/client/RemoteClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((requestId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestId).Handle);
				__args [1] = new JniArgumentValue ((remoteWampClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteWampClient).Handle);
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
			global::Com.Spotify.Protocol.Client.Subscription __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestId);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Protocol.Types.TypesRequestId RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Subscription']/method[@name='getRequestId' and count(parameter)=0]"
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
			global::Com.Spotify.Protocol.Client.Subscription __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResultDelivered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Subscription']/method[@name='onResultDelivered' and count(parameter)=0]"
		[Register ("onResultDelivered", "()V", "GetOnResultDeliveredHandler")]
		protected override unsafe void OnResultDelivered ()
		{
			const string __id = "onResultDelivered.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_;
#pragma warning disable 0169
		static Delegate GetSetEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_Handler ()
		{
			if (cb_setEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_ == null)
				cb_setEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_);
			return cb_setEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_;
		}

		static IntPtr n_SetEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventCallback)
		{
			global::Com.Spotify.Protocol.Client.Subscription __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.Subscription.IEventCallback eventCallback = (global::Com.Spotify.Protocol.Client.Subscription.IEventCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription.IEventCallback> (native_eventCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEventCallback (eventCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Subscription']/method[@name='setEventCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Subscription.EventCallback&lt;T&gt;']]"
		[Register ("setEventCallback", "(Lcom/spotify/protocol/client/Subscription$EventCallback;)Lcom/spotify/protocol/client/Subscription;", "GetSetEventCallback_Lcom_spotify_protocol_client_Subscription_EventCallback_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SetEventCallback (global::Com.Spotify.Protocol.Client.Subscription.IEventCallback eventCallback)
		{
			const string __id = "setEventCallback.(Lcom/spotify/protocol/client/Subscription$EventCallback;)Lcom/spotify/protocol/client/Subscription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_;
#pragma warning disable 0169
		static Delegate GetSetLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_Handler ()
		{
			if (cb_setLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_ == null)
				cb_setLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_);
			return cb_setLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_;
		}

		static IntPtr n_SetLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lifecycleCallback)
		{
			global::Com.Spotify.Protocol.Client.Subscription __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback lifecycleCallback = (global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback> (native_lifecycleCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLifecycleCallback (lifecycleCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Subscription']/method[@name='setLifecycleCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Subscription.LifecycleCallback']]"
		[Register ("setLifecycleCallback", "(Lcom/spotify/protocol/client/Subscription$LifecycleCallback;)Lcom/spotify/protocol/client/Subscription;", "GetSetLifecycleCallback_Lcom_spotify_protocol_client_Subscription_LifecycleCallback_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SetLifecycleCallback (global::Com.Spotify.Protocol.Client.Subscription.ILifecycleCallback lifecycleCallback)
		{
			const string __id = "setLifecycleCallback.(Lcom/spotify/protocol/client/Subscription$LifecycleCallback;)Lcom/spotify/protocol/client/Subscription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lifecycleCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lifecycleCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
