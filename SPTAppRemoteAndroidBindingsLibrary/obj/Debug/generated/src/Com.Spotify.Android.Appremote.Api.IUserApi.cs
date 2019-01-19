using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']"
	[Register ("com/spotify/android/appremote/api/UserApi", "", "Com.Spotify.Android.Appremote.Api.IUserApiInvoker")]
	public partial interface IUserApi : IJavaObject {

		global::Com.Spotify.Protocol.Client.CallResult Capabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']/method[@name='getCapabilities' and count(parameter)=0]"
			[Register ("getCapabilities", "()Lcom/spotify/protocol/client/CallResult;", "GetGetCapabilitiesHandler:Com.Spotify.Android.Appremote.Api.IUserApiInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']/method[@name='addToLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addToLibrary", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetAddToLibrary_Ljava_lang_String_Handler:Com.Spotify.Android.Appremote.Api.IUserApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult AddToLibrary (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']/method[@name='getLibraryState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryState", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetGetLibraryState_Ljava_lang_String_Handler:Com.Spotify.Android.Appremote.Api.IUserApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult GetLibraryState (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']/method[@name='removeFromLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeFromLibrary", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetRemoveFromLibrary_Ljava_lang_String_Handler:Com.Spotify.Android.Appremote.Api.IUserApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult RemoveFromLibrary (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']/method[@name='subscribeToCapabilities' and count(parameter)=0]"
		[Register ("subscribeToCapabilities", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToCapabilitiesHandler:Com.Spotify.Android.Appremote.Api.IUserApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.Subscription SubscribeToCapabilities ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='UserApi']/method[@name='subscribeToUserStatus' and count(parameter)=0]"
		[Register ("subscribeToUserStatus", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToUserStatusHandler:Com.Spotify.Android.Appremote.Api.IUserApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.Subscription SubscribeToUserStatus ();

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/UserApi", DoNotGenerateAcw=true)]
	internal class IUserApiInvoker : global::Java.Lang.Object, IUserApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/UserApi", typeof (IUserApiInvoker));

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

		public static IUserApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUserApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.UserApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUserApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCapabilities;
#pragma warning disable 0169
		static Delegate GetGetCapabilitiesHandler ()
		{
			if (cb_getCapabilities == null)
				cb_getCapabilities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCapabilities);
			return cb_getCapabilities;
		}

		static IntPtr n_GetCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IUserApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Capabilities);
		}
#pragma warning restore 0169

		IntPtr id_getCapabilities;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Capabilities {
			get {
				if (id_getCapabilities == IntPtr.Zero)
					id_getCapabilities = JNIEnv.GetMethodID (class_ref, "getCapabilities", "()Lcom/spotify/protocol/client/CallResult;");
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCapabilities), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addToLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddToLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_addToLibrary_Ljava_lang_String_ == null)
				cb_addToLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddToLibrary_Ljava_lang_String_);
			return cb_addToLibrary_Ljava_lang_String_;
		}

		static IntPtr n_AddToLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IUserApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddToLibrary (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addToLibrary_Ljava_lang_String_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult AddToLibrary (string p0)
		{
			if (id_addToLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_addToLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addToLibrary", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addToLibrary_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLibraryState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibraryState_Ljava_lang_String_Handler ()
		{
			if (cb_getLibraryState_Ljava_lang_String_ == null)
				cb_getLibraryState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibraryState_Ljava_lang_String_);
			return cb_getLibraryState_Ljava_lang_String_;
		}

		static IntPtr n_GetLibraryState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IUserApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLibraryState (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLibraryState_Ljava_lang_String_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult GetLibraryState (string p0)
		{
			if (id_getLibraryState_Ljava_lang_String_ == IntPtr.Zero)
				id_getLibraryState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibraryState", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibraryState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeFromLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveFromLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_removeFromLibrary_Ljava_lang_String_ == null)
				cb_removeFromLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveFromLibrary_Ljava_lang_String_);
			return cb_removeFromLibrary_Ljava_lang_String_;
		}

		static IntPtr n_RemoveFromLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IUserApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveFromLibrary (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeFromLibrary_Ljava_lang_String_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult RemoveFromLibrary (string p0)
		{
			if (id_removeFromLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_removeFromLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeFromLibrary", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeFromLibrary_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_subscribeToCapabilities;
#pragma warning disable 0169
		static Delegate GetSubscribeToCapabilitiesHandler ()
		{
			if (cb_subscribeToCapabilities == null)
				cb_subscribeToCapabilities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SubscribeToCapabilities);
			return cb_subscribeToCapabilities;
		}

		static IntPtr n_SubscribeToCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IUserApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToCapabilities ());
		}
#pragma warning restore 0169

		IntPtr id_subscribeToCapabilities;
		public unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToCapabilities ()
		{
			if (id_subscribeToCapabilities == IntPtr.Zero)
				id_subscribeToCapabilities = JNIEnv.GetMethodID (class_ref, "subscribeToCapabilities", "()Lcom/spotify/protocol/client/Subscription;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToCapabilities), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_subscribeToUserStatus;
#pragma warning disable 0169
		static Delegate GetSubscribeToUserStatusHandler ()
		{
			if (cb_subscribeToUserStatus == null)
				cb_subscribeToUserStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SubscribeToUserStatus);
			return cb_subscribeToUserStatus;
		}

		static IntPtr n_SubscribeToUserStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IUserApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToUserStatus ());
		}
#pragma warning restore 0169

		IntPtr id_subscribeToUserStatus;
		public unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToUserStatus ()
		{
			if (id_subscribeToUserStatus == IntPtr.Zero)
				id_subscribeToUserStatus = JNIEnv.GetMethodID (class_ref, "subscribeToUserStatus", "()Lcom/spotify/protocol/client/Subscription;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToUserStatus), JniHandleOwnership.TransferLocalRef);
		}

	}

}
