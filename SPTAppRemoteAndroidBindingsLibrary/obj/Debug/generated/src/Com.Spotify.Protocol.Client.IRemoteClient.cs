using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']"
	[Register ("com/spotify/protocol/client/RemoteClient", "", "Com.Spotify.Protocol.Client.IRemoteClientInvoker")]
	public partial interface IRemoteClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']/method[@name='call' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("call", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetCall_Ljava_lang_String_Ljava_lang_Class_Handler:Com.Spotify.Protocol.Client.IRemoteClientInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Com.Spotify.Protocol.Client.CallResult Call (string p0, global::Java.Lang.Class p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']/method[@name='call' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("call", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetCall_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_Handler:Com.Spotify.Protocol.Client.IRemoteClientInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Com.Spotify.Protocol.Client.CallResult Call (string p0, global::Java.Lang.Object p1, global::Java.Lang.Class p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']/method[@name='goodbye' and count(parameter)=0]"
		[Register ("goodbye", "()V", "GetGoodbyeHandler:Com.Spotify.Protocol.Client.IRemoteClientInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Goodbye ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']/method[@name='hello' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("hello", "(Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetHello_Ljava_lang_Class_Handler:Com.Spotify.Protocol.Client.IRemoteClientInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Com.Spotify.Protocol.Client.CallResult Hello (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;", "GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler:Com.Spotify.Protocol.Client.IRemoteClientInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Com.Spotify.Protocol.Client.Subscription Subscribe (string p0, global::Java.Lang.Class p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='RemoteClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Subscription&lt;T&gt;']]"
		[Register ("unsubscribe", "(Lcom/spotify/protocol/client/Subscription;)V", "GetUnsubscribe_Lcom_spotify_protocol_client_Subscription_Handler:Com.Spotify.Protocol.Client.IRemoteClientInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		void Unsubscribe (global::Com.Spotify.Protocol.Client.Subscription p0);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/RemoteClient", DoNotGenerateAcw=true)]
	internal class IRemoteClientInvoker : global::Java.Lang.Object, IRemoteClient {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/RemoteClient", typeof (IRemoteClientInvoker));

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

		public static IRemoteClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.RemoteClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_call_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCall_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_call_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_call_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_String_Ljava_lang_Class_);
			return cb_call_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_Call_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_call_Ljava_lang_String_Ljava_lang_Class_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Call (string p0, global::Java.Lang.Class p1)
		{
			if (id_call_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_call_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCall_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ == null)
				cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_);
			return cb_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_;
		}

		static IntPtr n_Call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Call (string p0, global::Java.Lang.Object p1, global::Java.Lang.Class p2)
		{
			if (id_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
				id_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Spotify.Protocol.Client.IRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Goodbye ();
		}
#pragma warning restore 0169

		IntPtr id_goodbye;
		public unsafe void Goodbye ()
		{
			if (id_goodbye == IntPtr.Zero)
				id_goodbye = JNIEnv.GetMethodID (class_ref, "goodbye", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_goodbye);
		}

		static Delegate cb_hello_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetHello_Ljava_lang_Class_Handler ()
		{
			if (cb_hello_Ljava_lang_Class_ == null)
				cb_hello_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Hello_Ljava_lang_Class_);
			return cb_hello_Ljava_lang_Class_;
		}

		static IntPtr n_Hello_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hello (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hello_Ljava_lang_Class_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Hello (global::Java.Lang.Class p0)
		{
			if (id_hello_Ljava_lang_Class_ == IntPtr.Zero)
				id_hello_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "hello", "(Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hello_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_subscribe_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_subscribe_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Ljava_lang_Class_);
			return cb_subscribe_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_Ljava_lang_Class_;
		public unsafe global::Com.Spotify.Protocol.Client.Subscription Subscribe (string p0, global::Java.Lang.Class p1)
		{
			if (id_subscribe_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Spotify.Protocol.Client.Subscription __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Lcom_spotify_protocol_client_Subscription_Handler ()
		{
			if (cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_ == null)
				cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Lcom_spotify_protocol_client_Subscription_);
			return cb_unsubscribe_Lcom_spotify_protocol_client_Subscription_;
		}

		static void n_Unsubscribe_Lcom_spotify_protocol_client_Subscription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IRemoteClient __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IRemoteClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.Subscription p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unsubscribe (p0);
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_Lcom_spotify_protocol_client_Subscription_;
		public unsafe void Unsubscribe (global::Com.Spotify.Protocol.Client.Subscription p0)
		{
			if (id_unsubscribe_Lcom_spotify_protocol_client_Subscription_ == IntPtr.Zero)
				id_unsubscribe_Lcom_spotify_protocol_client_Subscription_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Lcom/spotify/protocol/client/Subscription;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Lcom_spotify_protocol_client_Subscription_, __args);
		}

	}

}
