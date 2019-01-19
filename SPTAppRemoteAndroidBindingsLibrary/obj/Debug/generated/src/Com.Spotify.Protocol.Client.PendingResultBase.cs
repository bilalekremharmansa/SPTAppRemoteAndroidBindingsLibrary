using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/PendingResultBase", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class PendingResultBase : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.IPendingResult {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/field[@name='mErrorCallback']"
		[Register ("mErrorCallback")]
		protected global::Com.Spotify.Protocol.Client.IErrorCallback MErrorCallback {
			get {
				const string __id = "mErrorCallback.Lcom/spotify/protocol/client/ErrorCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IErrorCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mErrorCallback.Lcom/spotify/protocol/client/ErrorCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/field[@name='mIsCanceled']"
		[Register ("mIsCanceled")]
		protected bool MIsCanceled {
			get {
				const string __id = "mIsCanceled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsCanceled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/field[@name='mRecentResult']"
		[Register ("mRecentResult")]
		protected global::Com.Spotify.Protocol.Client.IResult MRecentResult {
			get {
				const string __id = "mRecentResult.Lcom/spotify/protocol/client/Result;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRecentResult.Lcom/spotify/protocol/client/Result;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/PendingResultBase", typeof (PendingResultBase));
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

		protected PendingResultBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/constructor[@name='PendingResultBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PendingResultBase ()
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
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Await ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='await' and count(parameter)=0]"
		[Register ("await", "()Lcom/spotify/protocol/client/Result;", "GetAwaitHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.IResult Await ()
		{
			const string __id = "await.()Lcom/spotify/protocol/client/Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_await_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwait_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_await_JLjava_util_concurrent_TimeUnit_ == null)
				cb_await_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Await_JLjava_util_concurrent_TimeUnit_);
			return cb_await_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Await_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_timeUnit)
		{
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit timeUnit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_timeUnit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Await (timeout, timeUnit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='await' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/spotify/protocol/client/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.IResult Await (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			const string __id = "await.(JLjava/util/concurrent/TimeUnit;)Lcom/spotify/protocol/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deliverError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDeliverError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_deliverError_Ljava_lang_Throwable_ == null)
				cb_deliverError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverError_Ljava_lang_Throwable_);
			return cb_deliverError_Ljava_lang_Throwable_;
		}

		static void n_DeliverError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.DeliverError (t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='deliverError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("deliverError", "(Ljava/lang/Throwable;)V", "GetDeliverError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void DeliverError (global::Java.Lang.Throwable t)
		{
			const string __id = "deliverError.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deliverResult_Lcom_spotify_protocol_client_Result_;
#pragma warning disable 0169
		static Delegate GetDeliverResult_Lcom_spotify_protocol_client_Result_Handler ()
		{
			if (cb_deliverResult_Lcom_spotify_protocol_client_Result_ == null)
				cb_deliverResult_Lcom_spotify_protocol_client_Result_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResult_Lcom_spotify_protocol_client_Result_);
			return cb_deliverResult_Lcom_spotify_protocol_client_Result_;
		}

		static void n_DeliverResult_Lcom_spotify_protocol_client_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IResult result = (global::Com.Spotify.Protocol.Client.IResult)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResult (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='deliverResult' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.Result&lt;T&gt;']]"
		[Register ("deliverResult", "(Lcom/spotify/protocol/client/Result;)V", "GetDeliverResult_Lcom_spotify_protocol_client_Result_Handler")]
		public virtual unsafe void DeliverResult (global::Com.Spotify.Protocol.Client.IResult result)
		{
			const string __id = "deliverResult.(Lcom/spotify/protocol/client/Result;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResultDelivered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='onResultDelivered' and count(parameter)=0]"
		[Register ("onResultDelivered", "()V", "GetOnResultDeliveredHandler")]
		protected abstract void OnResultDelivered ();

		static Delegate cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_;
#pragma warning disable 0169
		static Delegate GetSetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_Handler ()
		{
			if (cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ == null)
				cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_);
			return cb_setErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_;
		}

		static IntPtr n_SetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCallback)
		{
			global::Com.Spotify.Protocol.Client.PendingResultBase __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.PendingResultBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Client.IErrorCallback errorCallback = (global::Com.Spotify.Protocol.Client.IErrorCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IErrorCallback> (native_errorCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetErrorCallback (errorCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.ErrorCallback']]"
		[Register ("setErrorCallback", "(Lcom/spotify/protocol/client/ErrorCallback;)Lcom/spotify/protocol/client/PendingResult;", "GetSetErrorCallback_Lcom_spotify_protocol_client_ErrorCallback_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.IPendingResult SetErrorCallback (global::Com.Spotify.Protocol.Client.IErrorCallback errorCallback)
		{
			const string __id = "setErrorCallback.(Lcom/spotify/protocol/client/ErrorCallback;)Lcom/spotify/protocol/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IPendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/PendingResultBase", DoNotGenerateAcw=true)]
	internal partial class PendingResultBaseInvoker : PendingResultBase, global::Com.Spotify.Protocol.Client.IPendingResult {

		public PendingResultBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/PendingResultBase", typeof (PendingResultBaseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='PendingResultBase']/method[@name='onResultDelivered' and count(parameter)=0]"
		[Register ("onResultDelivered", "()V", "GetOnResultDeliveredHandler")]
		protected override unsafe void OnResultDelivered ()
		{
			const string __id = "onResultDelivered.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
