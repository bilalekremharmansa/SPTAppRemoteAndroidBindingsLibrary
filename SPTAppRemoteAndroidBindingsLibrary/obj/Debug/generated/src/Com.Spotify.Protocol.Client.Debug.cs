using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/Debug", DoNotGenerateAcw=true)]
	public partial class Debug : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Assertion']"
		[Register ("com/spotify/protocol/client/Debug$Assertion", "", "Com.Spotify.Protocol.Client.Debug/IAssertionInvoker")]
		public partial interface IAssertion : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Assertion']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("assertTrue", "(ZLjava/lang/String;)V", "GetAssertTrue_ZLjava_lang_String_Handler:Com.Spotify.Protocol.Client.Debug/IAssertionInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void AssertTrue (bool p0, string p1);

		}

		[global::Android.Runtime.Register ("com/spotify/protocol/client/Debug$Assertion", DoNotGenerateAcw=true)]
		internal class IAssertionInvoker : global::Java.Lang.Object, IAssertion {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/Debug$Assertion", typeof (IAssertionInvoker));

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

			public static IAssertion GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAssertion> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.Debug.Assertion"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAssertionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_assertTrue_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAssertTrue_ZLjava_lang_String_Handler ()
			{
				if (cb_assertTrue_ZLjava_lang_String_ == null)
					cb_assertTrue_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_AssertTrue_ZLjava_lang_String_);
				return cb_assertTrue_ZLjava_lang_String_;
			}

			static void n_AssertTrue_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Com.Spotify.Protocol.Client.Debug.IAssertion __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Debug.IAssertion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.AssertTrue (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_assertTrue_ZLjava_lang_String_;
			public unsafe void AssertTrue (bool p0, string p1)
			{
				if (id_assertTrue_ZLjava_lang_String_ == IntPtr.Zero)
					id_assertTrue_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "assertTrue", "(ZLjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_assertTrue_ZLjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Logger']"
		[Register ("com/spotify/protocol/client/Debug$Logger", "", "Com.Spotify.Protocol.Client.Debug/ILoggerInvoker")]
		public partial interface ILogger : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Logger']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Spotify.Protocol.Client.Debug/ILoggerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void D (string p0, params global::Java.Lang.Object[] p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Logger']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Spotify.Protocol.Client.Debug/ILoggerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void D (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Logger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Spotify.Protocol.Client.Debug/ILoggerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void E (string p0, params global::Java.Lang.Object[] p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Debug.Logger']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Spotify.Protocol.Client.Debug/ILoggerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
			void E (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2);

		}

		[global::Android.Runtime.Register ("com/spotify/protocol/client/Debug$Logger", DoNotGenerateAcw=true)]
		internal class ILoggerInvoker : global::Java.Lang.Object, ILogger {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/Debug$Logger", typeof (ILoggerInvoker));

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

			public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.Debug.Logger"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_d_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetD_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_d_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_d_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_D_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Spotify.Protocol.Client.Debug.ILogger __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Debug.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.D (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_d_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void D (string p0, params global::Java.Lang.Object[] p1)
			{
				if (id_d_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetD_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_D_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Spotify.Protocol.Client.Debug.ILogger __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Debug.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.D (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			IntPtr id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void D (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				if (id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_e_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetE_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_e_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_e_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_E_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Spotify.Protocol.Client.Debug.ILogger __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Debug.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.E (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_e_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void E (string p0, params global::Java.Lang.Object[] p1)
			{
				if (id_e_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetE_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_E_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Spotify.Protocol.Client.Debug.ILogger __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Debug.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.E (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			IntPtr id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void E (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				if (id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/Debug", typeof (Debug));
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

		protected Debug (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertTrue", "(ZLjava/lang/String;)V", "")]
		public static unsafe void AssertTrue (bool expression, string message)
		{
			const string __id = "assertTrue.(ZLjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expression);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "d.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (global::Java.Lang.Throwable e, string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "d.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "e.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable e, string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "e.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='setAssertion' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Debug.Assertion']]"
		[Register ("setAssertion", "(Lcom/spotify/protocol/client/Debug$Assertion;)V", "")]
		public static unsafe void SetAssertion (global::Com.Spotify.Protocol.Client.Debug.IAssertion assertion)
		{
			const string __id = "setAssertion.(Lcom/spotify/protocol/client/Debug$Assertion;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((assertion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) assertion).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='Debug']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Debug.Logger']]"
		[Register ("setLogger", "(Lcom/spotify/protocol/client/Debug$Logger;)V", "")]
		public static unsafe void SetLogger (global::Com.Spotify.Protocol.Client.Debug.ILogger logger)
		{
			const string __id = "setLogger.(Lcom/spotify/protocol/client/Debug$Logger;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
