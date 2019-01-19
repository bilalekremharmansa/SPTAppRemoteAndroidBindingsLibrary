using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/SpotifyAppRemote", DoNotGenerateAcw=true)]
	public partial class SpotifyAppRemote : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/SpotifyAppRemote", typeof (SpotifyAppRemote));
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

		protected SpotifyAppRemote (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConnectApi;
#pragma warning disable 0169
		static Delegate GetGetConnectApiHandler ()
		{
			if (cb_getConnectApi == null)
				cb_getConnectApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectApi);
			return cb_getConnectApi;
		}

		static IntPtr n_GetConnectApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectApi);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.IConnectApi ConnectApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='getConnectApi' and count(parameter)=0]"
			[Register ("getConnectApi", "()Lcom/spotify/android/appremote/api/ConnectApi;", "GetGetConnectApiHandler")]
			get {
				const string __id = "getConnectApi.()Lcom/spotify/android/appremote/api/ConnectApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnectApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentApi;
#pragma warning disable 0169
		static Delegate GetGetContentApiHandler ()
		{
			if (cb_getContentApi == null)
				cb_getContentApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentApi);
			return cb_getContentApi;
		}

		static IntPtr n_GetContentApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentApi);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.IContentApi ContentApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='getContentApi' and count(parameter)=0]"
			[Register ("getContentApi", "()Lcom/spotify/android/appremote/api/ContentApi;", "GetGetContentApiHandler")]
			get {
				const string __id = "getContentApi.()Lcom/spotify/android/appremote/api/ContentApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IContentApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool DebugMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='isDebugMode' and count(parameter)=0]"
			[Register ("isDebugMode", "()Z", "GetIsDebugModeHandler")]
			get {
				const string __id = "isDebugMode.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugMode", "(Z)V", "GetSetDebugMode_ZHandler")]
			set {
				const string __id = "setDebugMode.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImagesApi;
#pragma warning disable 0169
		static Delegate GetGetImagesApiHandler ()
		{
			if (cb_getImagesApi == null)
				cb_getImagesApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImagesApi);
			return cb_getImagesApi;
		}

		static IntPtr n_GetImagesApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImagesApi);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.IImagesApi ImagesApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='getImagesApi' and count(parameter)=0]"
			[Register ("getImagesApi", "()Lcom/spotify/android/appremote/api/ImagesApi;", "GetGetImagesApiHandler")]
			get {
				const string __id = "getImagesApi.()Lcom/spotify/android/appremote/api/ImagesApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IImagesApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMotionStateApi;
#pragma warning disable 0169
		static Delegate GetGetMotionStateApiHandler ()
		{
			if (cb_getMotionStateApi == null)
				cb_getMotionStateApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMotionStateApi);
			return cb_getMotionStateApi;
		}

		static IntPtr n_GetMotionStateApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MotionStateApi);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.IMotionStateApi MotionStateApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='getMotionStateApi' and count(parameter)=0]"
			[Register ("getMotionStateApi", "()Lcom/spotify/android/appremote/api/MotionStateApi;", "GetGetMotionStateApiHandler")]
			get {
				const string __id = "getMotionStateApi.()Lcom/spotify/android/appremote/api/MotionStateApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IMotionStateApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlayerApi;
#pragma warning disable 0169
		static Delegate GetGetPlayerApiHandler ()
		{
			if (cb_getPlayerApi == null)
				cb_getPlayerApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerApi);
			return cb_getPlayerApi;
		}

		static IntPtr n_GetPlayerApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayerApi);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.IPlayerApi PlayerApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='getPlayerApi' and count(parameter)=0]"
			[Register ("getPlayerApi", "()Lcom/spotify/android/appremote/api/PlayerApi;", "GetGetPlayerApiHandler")]
			get {
				const string __id = "getPlayerApi.()Lcom/spotify/android/appremote/api/PlayerApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserApi;
#pragma warning disable 0169
		static Delegate GetGetUserApiHandler ()
		{
			if (cb_getUserApi == null)
				cb_getUserApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserApi);
			return cb_getUserApi;
		}

		static IntPtr n_GetUserApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserApi);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.IUserApi UserApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='getUserApi' and count(parameter)=0]"
			[Register ("getUserApi", "()Lcom/spotify/android/appremote/api/UserApi;", "GetGetUserApiHandler")]
			get {
				const string __id = "getUserApi.()Lcom/spotify/android/appremote/api/UserApi;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IUserApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_call_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCall_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_Handler ()
		{
			if (cb_call_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_ == null)
				cb_call_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_);
			return cb_call_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_;
		}

		static IntPtr n_Call_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_argument, IntPtr native_resultType)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object argument = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_argument, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class resultType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_resultType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (uri, argument, resultType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='call' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='S'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("call", "(Ljava/lang/String;Lcom/spotify/protocol/types/Item;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;", "GetCall_Ljava_lang_String_Lcom_spotify_protocol_types_Item_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.spotify.protocol.types.Item", "S extends com.spotify.protocol.types.Item"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Call (string uri, global::Java.Lang.Object argument, global::Java.Lang.Class resultType)
		{
			const string __id = "call.(Ljava/lang/String;Lcom/spotify/protocol/types/Item;Ljava/lang/Class;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			IntPtr native_argument = JNIEnv.ToLocalJniHandle (argument);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue (native_argument);
				__args [2] = new JniArgumentValue ((resultType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native_argument);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.spotify.android.appremote.api.ConnectionParams'] and parameter[3][@type='com.spotify.android.appremote.api.Connector.ConnectionListener']]"
		[Register ("connect", "(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Lcom/spotify/android/appremote/api/Connector$ConnectionListener;)V", "")]
		public static unsafe void Connect (global::Android.Content.Context context, global::Com.Spotify.Android.Appremote.Api.ConnectionParams @params, global::Com.Spotify.Android.Appremote.Api.IConnectorConnectionListener connectionListener)
		{
			const string __id = "connect.(Landroid/content/Context;Lcom/spotify/android/appremote/api/ConnectionParams;Lcom/spotify/android/appremote/api/Connector$ConnectionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [2] = new JniArgumentValue ((connectionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionListener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.SpotifyAppRemote']]"
		[Register ("disconnect", "(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V", "")]
		public static unsafe void Disconnect (global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote spotifyAppRemote)
		{
			const string __id = "disconnect.(Lcom/spotify/android/appremote/api/SpotifyAppRemote;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((spotifyAppRemote == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spotifyAppRemote).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='isSpotifyInstalled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSpotifyInstalled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsSpotifyInstalled (global::Android.Content.Context context)
		{
			const string __id = "isSpotifyInstalled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
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

		static IntPtr n_Subscribe_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_eventType)
		{
			global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.SpotifyAppRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (uri, eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='SpotifyAppRemote']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("subscribe", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;", "GetSubscribe_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.spotify.protocol.types.Item"})]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription Subscribe (string uri, global::Java.Lang.Class eventType)
		{
			const string __id = "subscribe.(Ljava/lang/String;Ljava/lang/Class;)Lcom/spotify/protocol/client/Subscription;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

	}
}
