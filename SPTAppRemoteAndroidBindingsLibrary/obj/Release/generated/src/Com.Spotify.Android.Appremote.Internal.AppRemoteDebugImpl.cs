using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/AppRemoteDebugImpl", DoNotGenerateAcw=true)]
	public partial class AppRemoteDebugImpl : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.Debug.IAssertion, global::Com.Spotify.Protocol.Client.Debug.ILogger {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/AppRemoteDebugImpl", typeof (AppRemoteDebugImpl));
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

		protected AppRemoteDebugImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']/constructor[@name='AppRemoteDebugImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppRemoteDebugImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_assertTrue_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAssertTrue_ZLjava_lang_String_Handler ()
		{
			if (cb_assertTrue_ZLjava_lang_String_ == null)
				cb_assertTrue_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_AssertTrue_ZLjava_lang_String_);
			return cb_assertTrue_ZLjava_lang_String_;
		}

		static void n_AssertTrue_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool expression, IntPtr native_message)
		{
			global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.AssertTrue (expression, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertTrue", "(ZLjava/lang/String;)V", "GetAssertTrue_ZLjava_lang_String_Handler")]
		public virtual unsafe void AssertTrue (bool expression, string message)
		{
			const string __id = "assertTrue.(ZLjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expression);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_d_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_d_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_d_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_D_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_args)
		{
			global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.D (format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void D (string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "d.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
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

		static void n_D_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_format, IntPtr native_args)
		{
			global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			string format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.D (e, format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void D (global::Java.Lang.Throwable e, string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "d.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
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

		static void n_E_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_args)
		{
			global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.E (format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void E (string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "e.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
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

		static void n_E_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_format, IntPtr native_args)
		{
			global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.AppRemoteDebugImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable e = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_e, JniHandleOwnership.DoNotTransfer);
			string format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.E (e, format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='AppRemoteDebugImpl']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void E (global::Java.Lang.Throwable e, string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "e.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

	}
}
