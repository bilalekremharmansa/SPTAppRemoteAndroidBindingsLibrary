using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Result']"
	[Register ("com/spotify/protocol/client/Result", "", "Com.Spotify.Protocol.Client.IResultInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IResult : IJavaObject {

		global::Java.Lang.Object Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Result']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler:Com.Spotify.Protocol.Client.IResultInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		global::Java.Lang.Throwable Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Result']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/Throwable;", "GetGetErrorHandler:Com.Spotify.Protocol.Client.IResultInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Result']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler:Com.Spotify.Protocol.Client.IResultInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='Result']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler:Com.Spotify.Protocol.Client.IResultInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/Result", DoNotGenerateAcw=true)]
	internal class IResultInvoker : global::Java.Lang.Object, IResult {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/Result", typeof (IResultInvoker));

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

		public static IResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.Result"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Spotify.Protocol.Client.IResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		IntPtr id_getData;
		public unsafe global::Java.Lang.Object Data {
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Protocol.Client.IResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Spotify.Protocol.Client.IResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMessage);
		}
#pragma warning restore 0169

		IntPtr id_getErrorMessage;
		public unsafe string ErrorMessage {
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Protocol.Client.IResult __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		IntPtr id_isSuccessful;
		public unsafe bool IsSuccessful {
			get {
				if (id_isSuccessful == IntPtr.Zero)
					id_isSuccessful = JNIEnv.GetMethodID (class_ref, "isSuccessful", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccessful);
			}
		}

	}

}
