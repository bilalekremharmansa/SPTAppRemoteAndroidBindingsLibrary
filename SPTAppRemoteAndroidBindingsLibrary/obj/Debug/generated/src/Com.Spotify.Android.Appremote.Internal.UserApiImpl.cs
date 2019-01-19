using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/UserApiImpl", DoNotGenerateAcw=true)]
	public partial class UserApiImpl : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Api.IUserApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/UserApiImpl", typeof (UserApiImpl));
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

		protected UserApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/constructor[@name='UserApiImpl' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe UserApiImpl (global::Com.Spotify.Protocol.Client.IRemoteClient remoteClient)
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
			global::Com.Spotify.Android.Appremote.Internal.UserApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.UserApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Capabilities);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Capabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/method[@name='getCapabilities' and count(parameter)=0]"
			[Register ("getCapabilities", "()Lcom/spotify/protocol/client/CallResult;", "GetGetCapabilitiesHandler")]
			get {
				const string __id = "getCapabilities.()Lcom/spotify/protocol/client/CallResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static IntPtr n_AddToLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Spotify.Android.Appremote.Internal.UserApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.UserApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddToLibrary (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/method[@name='addToLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addToLibrary", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetAddToLibrary_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult AddToLibrary (string uri)
		{
			const string __id = "addToLibrary.(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_getLibraryState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibraryState_Ljava_lang_String_Handler ()
		{
			if (cb_getLibraryState_Ljava_lang_String_ == null)
				cb_getLibraryState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibraryState_Ljava_lang_String_);
			return cb_getLibraryState_Ljava_lang_String_;
		}

		static IntPtr n_GetLibraryState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Spotify.Android.Appremote.Internal.UserApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.UserApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLibraryState (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/method[@name='getLibraryState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryState", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetGetLibraryState_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult GetLibraryState (string uri)
		{
			const string __id = "getLibraryState.(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_removeFromLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveFromLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_removeFromLibrary_Ljava_lang_String_ == null)
				cb_removeFromLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveFromLibrary_Ljava_lang_String_);
			return cb_removeFromLibrary_Ljava_lang_String_;
		}

		static IntPtr n_RemoveFromLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Spotify.Android.Appremote.Internal.UserApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.UserApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveFromLibrary (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/method[@name='removeFromLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeFromLibrary", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetRemoveFromLibrary_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult RemoveFromLibrary (string uri)
		{
			const string __id = "removeFromLibrary.(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
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
			global::Com.Spotify.Android.Appremote.Internal.UserApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.UserApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToCapabilities ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/method[@name='subscribeToCapabilities' and count(parameter)=0]"
		[Register ("subscribeToCapabilities", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToCapabilitiesHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToCapabilities ()
		{
			const string __id = "subscribeToCapabilities.()Lcom/spotify/protocol/client/Subscription;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.UserApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.UserApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToUserStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='UserApiImpl']/method[@name='subscribeToUserStatus' and count(parameter)=0]"
		[Register ("subscribeToUserStatus", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToUserStatusHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToUserStatus ()
		{
			const string __id = "subscribeToUserStatus.()Lcom/spotify/protocol/client/Subscription;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
