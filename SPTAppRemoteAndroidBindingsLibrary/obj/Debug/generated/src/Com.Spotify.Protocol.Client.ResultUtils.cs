using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/ResultUtils", DoNotGenerateAcw=true)]
	public partial class ResultUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.ErrorResult']"
		[global::Android.Runtime.Register ("com/spotify/protocol/client/ResultUtils$ErrorResult", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class ErrorResult : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.IResult {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/ResultUtils$ErrorResult", typeof (ErrorResult));
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

			protected ErrorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Object Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.ErrorResult']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler")]
				get {
					const string __id = "getData.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
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
				global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Error);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Throwable Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.ErrorResult']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Ljava/lang/Throwable;", "GetGetErrorHandler")]
				get {
					const string __id = "getError.()Ljava/lang/Throwable;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getErrorMessage;
#pragma warning disable 0169
			static Delegate GetGetErrorMessageHandler ()
			{
				if (cb_getErrorMessage == null)
					cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMessage);
				return cb_getErrorMessage;
			}

			static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ErrorMessage);
			}
#pragma warning restore 0169

			public virtual unsafe string ErrorMessage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.ErrorResult']/method[@name='getErrorMessage' and count(parameter)=0]"
				[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
				get {
					const string __id = "getErrorMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isSuccessful;
#pragma warning disable 0169
			static Delegate GetIsSuccessfulHandler ()
			{
				if (cb_isSuccessful == null)
					cb_isSuccessful = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccessful);
				return cb_isSuccessful;
			}

			static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.ErrorResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSuccessful;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.ErrorResult']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get {
					const string __id = "isSuccessful.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.SuccessfulResult']"
		[global::Android.Runtime.Register ("com/spotify/protocol/client/ResultUtils$SuccessfulResult", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class SuccessfulResult : global::Java.Lang.Object, global::Com.Spotify.Protocol.Client.IResult {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/ResultUtils$SuccessfulResult", typeof (SuccessfulResult));
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

			protected SuccessfulResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Object Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.SuccessfulResult']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler")]
				get {
					const string __id = "getData.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
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
				global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Error);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Throwable Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.SuccessfulResult']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Ljava/lang/Throwable;", "GetGetErrorHandler")]
				get {
					const string __id = "getError.()Ljava/lang/Throwable;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getErrorMessage;
#pragma warning disable 0169
			static Delegate GetGetErrorMessageHandler ()
			{
				if (cb_getErrorMessage == null)
					cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMessage);
				return cb_getErrorMessage;
			}

			static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ErrorMessage);
			}
#pragma warning restore 0169

			public virtual unsafe string ErrorMessage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.SuccessfulResult']/method[@name='getErrorMessage' and count(parameter)=0]"
				[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
				get {
					const string __id = "getErrorMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isSuccessful;
#pragma warning disable 0169
			static Delegate GetIsSuccessfulHandler ()
			{
				if (cb_isSuccessful == null)
					cb_isSuccessful = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccessful);
				return cb_isSuccessful;
			}

			static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ResultUtils.SuccessfulResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSuccessful;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils.SuccessfulResult']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get {
					const string __id = "isSuccessful.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/ResultUtils", typeof (ResultUtils));
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

		protected ResultUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils']/method[@name='createErrorResult' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("createErrorResult", "(Ljava/lang/Throwable;)Lcom/spotify/protocol/client/Result;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Spotify.Protocol.Client.IResult CreateErrorResult (global::Java.Lang.Throwable t)
		{
			const string __id = "createErrorResult.(Ljava/lang/Throwable;)Lcom/spotify/protocol/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ResultUtils']/method[@name='createSuccessfulResult' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("createSuccessfulResult", "(Ljava/lang/Object;)Lcom/spotify/protocol/client/Result;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Spotify.Protocol.Client.IResult CreateSuccessfulResult (global::Java.Lang.Object payload)
		{
			const string __id = "createSuccessfulResult.(Ljava/lang/Object;)Lcom/spotify/protocol/client/Result;";
			IntPtr native_payload = JNIEnv.ToLocalJniHandle (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_payload);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_payload);
			}
		}

	}
}
