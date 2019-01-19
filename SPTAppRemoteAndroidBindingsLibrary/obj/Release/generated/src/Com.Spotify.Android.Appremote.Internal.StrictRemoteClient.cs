using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/StrictRemoteClient", DoNotGenerateAcw=true)]
	public partial class StrictRemoteClient : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.IRemoteClient {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.internal']/interface[@name='StrictRemoteClient.Rule']"
		[Register ("com/spotify/android/appremote/internal/StrictRemoteClient$Rule", "", "Com.Spotify.Android.Appremote.Internal.StrictRemoteClient/IRuleInvoker")]
		public partial interface IRule : IJavaObject {

			global::Java.Lang.Throwable Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/interface[@name='StrictRemoteClient.Rule']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Ljava/lang/Throwable;", "GetGetErrorHandler:Com.Spotify.Android.Appremote.Internal.StrictRemoteClient/IRuleInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
			}

			bool IsSatisfied {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/interface[@name='StrictRemoteClient.Rule']/method[@name='isSatisfied' and count(parameter)=0]"
				[Register ("isSatisfied", "()Z", "GetIsSatisfiedHandler:Com.Spotify.Android.Appremote.Internal.StrictRemoteClient/IRuleInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
			}

		}

		[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/StrictRemoteClient$Rule", DoNotGenerateAcw=true)]
		internal class IRuleInvoker : global::Java.Lang.Object, IRule {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/internal/StrictRemoteClient$Rule", typeof (IRuleInvoker));

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

			public static IRule GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRule> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.internal.StrictRemoteClient.Rule"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getError;
#pragma warning disable 0169
			static Delegate GetGetErrorHandler ()
			{
				if (cb_getError == null)
					cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
				return cb_getError;
			}

			static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Error);
			}
#pragma warning restore 0169

			IntPtr id_getError;
			public unsafe global::Java.Lang.Throwable Error {
				get {
					if (id_getError == IntPtr.Zero)
						id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Ljava/lang/Throwable;");
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_isSatisfied;
#pragma warning disable 0169
			static Delegate GetIsSatisfiedHandler ()
			{
				if (cb_isSatisfied == null)
					cb_isSatisfied = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSatisfied);
				return cb_isSatisfied;
			}

			static bool n_IsSatisfied (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSatisfied;
			}
#pragma warning restore 0169

			IntPtr id_isSatisfied;
			public unsafe bool IsSatisfied {
				get {
					if (id_isSatisfied == IntPtr.Zero)
						id_isSatisfied = JNIEnv.GetMethodID (class_ref, "isSatisfied", "()Z");
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSatisfied);
				}
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/StrictRemoteClient", typeof (StrictRemoteClient));
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

		protected StrictRemoteClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/constructor[@name='StrictRemoteClient' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe StrictRemoteClient (global::Com.Spotify.Protocol.Client.IRemoteClient remoteClient)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/client/RemoteClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((remoteClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteClient).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_;
#pragma warning disable 0169
		static Delegate GetAddRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_Handler ()
		{
			if (cb_addRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_ == null)
				cb_addRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_);
			return cb_addRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_;
		}

		static void n_AddRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rule)
		{
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule rule = (global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule)global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule> (native_rule, JniHandleOwnership.DoNotTransfer);
			__this.AddRule (rule);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='addRule' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.internal.StrictRemoteClient.Rule']]"
		[Register ("addRule", "(Lcom/spotify/android/appremote/internal/StrictRemoteClient$Rule;)V", "GetAddRule_Lcom_spotify_android_appremote_internal_StrictRemoteClient_Rule_Handler")]
		public virtual unsafe void AddRule (global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient.IRule rule)
		{
			const string __id = "addRule.(Lcom/spotify/android/appremote/internal/StrictRemoteClient$Rule;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rule == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rule).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (procedureUri, resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='call' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
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
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string procedureUri = JNIEnv.GetString (native_procedureUri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object arguments = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arguments, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (procedureUri, arguments, resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='call' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
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
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Goodbye ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='goodbye' and count(parameter)=0]"
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
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hello (resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
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

		static Delegate cb_subscribe_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_subscribe_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Ljava_lang_Class_);
			return cb_subscribe_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_eventClass)
		{
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventClass, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topic, eventClass));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;", "GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription Subscribe (string topic, global::Java.Lang.Class eventClass)
		{
			const string __id = "subscribe.(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topic);
				__args [1] = new JniArgumentValue ((eventClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventClass).Handle);
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
			global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.StrictRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.Subscription subscription = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (native_subscription, JniHandleOwnership.DoNotTransfer);
			__this.Unsubscribe (subscription);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='StrictRemoteClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Subscription&lt;T&gt;']]"
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

	}
}
