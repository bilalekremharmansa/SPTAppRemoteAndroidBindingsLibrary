using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/RemoteWampClient", DoNotGenerateAcw=true)]
	public partial class RemoteWampClient : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.IRemoteClient {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/RemoteWampClient", typeof (RemoteWampClient));
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

		protected RemoteWampClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/constructor[@name='RemoteWampClient' and count(parameter)=2 and parameter[1][@type='com.spotify.protocol.client.AppProtocolCommunicator'] and parameter[2][@type='com.spotify.protocol.client.WampCallsOrchestrator']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/AppProtocolCommunicator;Lcom/spotify/protocol/client/WampCallsOrchestrator;)V", "")]
		public unsafe RemoteWampClient (global::Com.Spotify.Protocol.Client.AppProtocolCommunicator communicator, global::Com.Spotify.Protocol.Client.WampCallsOrchestrator wampCallsOrchestrator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/client/AppProtocolCommunicator;Lcom/spotify/protocol/client/WampCallsOrchestrator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((communicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) communicator).Handle);
				__args [1] = new JniArgumentValue ((wampCallsOrchestrator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wampCallsOrchestrator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_call_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCall_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_call_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_call_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_String_Ljava_lang_Class_);
			return cb_call_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_Call_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_procedureUri, IntPtr native_resultType)
		{
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (procedureUri, resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='call' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("call", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetCall_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Call (string procedureUri, global::Java.Lang.Class resultType)
		{
			const string __id = "call.(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_procedureUri = JNIEnv.NewString (procedureUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_procedureUri);
				__args [1] = new JniArgumentValue ((resultType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_procedureUri);
			}
		}

		static Delegate cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCall_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ == null)
				cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_);
			return cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_;
		}

		static IntPtr n_Call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_procedureUri, IntPtr native_arguments, IntPtr native_resultType)
		{
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object arguments = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arguments, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (procedureUri, arguments, resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='call' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("call", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetCall_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Call (string procedureUri, global::Java.Lang.Object arguments, global::Java.Lang.Class resultType)
		{
			const string __id = "call.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_procedureUri = JNIEnv.NewString (procedureUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_procedureUri);
				__args [1] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
				__args [2] = new JniArgumentValue ((resultType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_procedureUri);
			}
		}

		static Delegate cb_goodbye;
#pragma warning disable 0169
		static Delegate GetGoodbyeHandler ()
		{
			if (cb_goodbye == null)
				cb_goodbye = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Goodbye);
			return cb_goodbye;
		}

		static void n_Goodbye (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Goodbye ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='goodbye' and count(parameter)=0]"
		[Register ("goodbye", "()V", "GetGoodbyeHandler")]
		public virtual unsafe void Goodbye ()
		{
			const string __id = "goodbye.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_hello_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetHello_Ljava_lang_Class_Handler ()
		{
			if (cb_hello_Ljava_lang_Class_ == null)
				cb_hello_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Hello_Ljava_lang_Class_);
			return cb_hello_Ljava_lang_Class_;
		}

		static IntPtr n_Hello_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultType)
		{
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hello (resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("hello", "(Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetHello_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Hello (global::Java.Lang.Class resultType)
		{
			const string __id = "hello.(Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener listener = (global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnConnectionTerminatedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='setOnConnectionTerminatedListener' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.OnConnectionTerminatedListener']]"
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

		static Delegate cb_subscribe_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_subscribe_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Ljava_lang_Class_);
			return cb_subscribe_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_eventType)
		{
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topic, eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;", "GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription Subscribe (string topic, global::Java.Lang.Class eventType)
		{
			const string __id = "subscribe.(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topic);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Lcom_spotify_protocol_client_Subscription_Handler ()
		{
			if (cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_ == null)
				cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Lcom_spotify_protocol_client_Subscription_);
			return cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_;
		}

		static void n_Unsubscribe_Lcom_spotify_protocol_client_Subscription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscription)
		{
			global::Com.Spotify.Protocol.Client.RemoteWampClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.RemoteWampClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.Subscription subscription = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (native_subscription, JniHandleOwnership.DoNotTransfer);
			__this.Unsubscribe (subscription);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RemoteWampClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Subscription&lt;T&gt;']]"
		[Register ("unsubscribe", "(Lcom/spotify/protocol/client/Subscription;)V", "GetUnsubscribe_Lcom_spotify_protocol_client_Subscription_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe void Unsubscribe (global::Com.Spotify.Protocol.Client.Subscription subscription)
		{
			const string __id = "unsubscribe.(Lcom/spotify/protocol/client/Subscription;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscription == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscription).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
