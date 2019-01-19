using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='PendingResult']"
	[Register ("com/spotify/protocol/client/PendingResult", "", "Com.Spotify.Protocol.Client.IPendingResultInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPendingResult : IJavaObject {

		bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='PendingResult']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler:Com.Spotify.Protocol.Client.IPendingResultInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='PendingResult']/method[@name='await' and count(parameter)=0]"
		[Register ("await", "()Lcom/spotify/protocol/client/Result;", "GetAwaitHandler:Com.Spotify.Protocol.Client.IPendingResultInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.IResult Await ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='PendingResult']/method[@name='await' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/spotify/protocol/client/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler:Com.Spotify.Protocol.Client.IPendingResultInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.IResult Await (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='PendingResult']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Spotify.Protocol.Client.IPendingResultInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='PendingResult']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.ErrorCallback']]"
		[Register ("setErrorCallback", "(Lcom/spotify/protocol/client/ErrorCallback;)Lcom/spotify/protocol/client/PendingResult;", "GetSetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_Handler:Com.Spotify.Protocol.Client.IPendingResultInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.IPendingResult SetErrorCallback (global::Com.Spotify.Protocol.Client.IErrorCallback p0);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/PendingResult", DoNotGenerateAcw=true)]
	internal class IPendingResultInvoker : global::Java.Lang.Object, IPendingResult {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/PendingResult", typeof (IPendingResultInvoker));

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

		public static IPendingResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPendingResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.PendingResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPendingResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.IPendingResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		IntPtr id_isCanceled;
		public unsafe bool IsCanceled {
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCanceled);
			}
		}

		static Delegate cb_await;
#pragma warning disable 0169
		static Delegate GetAwaitHandler ()
		{
			if (cb_await == null)
				cb_await = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Await);
			return cb_await;
		}

		static IntPtr n_Await (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.IPendingResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Await ());
		}
#pragma warning restore 0169

		IntPtr id_await;
		public unsafe global::Com.Spotify.Protocol.Client.IResult Await ()
		{
			if (id_await == IntPtr.Zero)
				id_await = JNIEnv.GetMethodID (class_ref, "await", "()Lcom/spotify/protocol/client/Result;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_await), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_await_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwait_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_await_JLjava_util_concurrent_TimeUnit_ == null)
				cb_await_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Await_JLjava_util_concurrent_TimeUnit_);
			return cb_await_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Await_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Spotify.Protocol.Client.IPendingResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Await (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_await_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Com.Spotify.Protocol.Client.IResult Await (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_await_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_await_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "await", "(JLjava/util/concurrent/TimeUnit;)Lcom/spotify/protocol/client/Result;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Spotify.Protocol.Client.IResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_await_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.IPendingResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_;
#pragma warning disable 0169
		static Delegate GetSetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_Handler ()
		{
			if (cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ == null)
				cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_);
			return cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_;
		}

		static IntPtr n_SetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Client.IPendingResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IErrorCallback p0 = (global::Com.Spotify.Protocol.Client.IErrorCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IErrorCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetErrorCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_;
		public unsafe global::Com.Spotify.Protocol.Client.IPendingResult SetErrorCallback (global::Com.Spotify.Protocol.Client.IErrorCallback p0)
		{
			if (id_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ == IntPtr.Zero)
				id_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ = JNIEnv.GetMethodID (class_ref, "setErrorCallback", "(Lcom/spotify/protocol/client/ErrorCallback;)Lcom/spotify/protocol/client/PendingResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Spotify.Protocol.Client.IPendingResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
