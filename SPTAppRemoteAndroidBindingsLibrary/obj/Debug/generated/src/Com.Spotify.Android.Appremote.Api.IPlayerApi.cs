using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='PlayerApi.StreamType']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/PlayerApi$StreamType", DoNotGenerateAcw=true)]
	public sealed partial class PlayerApiStreamType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='PlayerApi.StreamType']/field[@name='ALARM']"
		[Register ("ALARM")]
		public static global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType Alarm {
			get {
				const string __id = "ALARM.Lcom/spotify/android/appremote/api/PlayerApi$StreamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='PlayerApi.StreamType']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/PlayerApi$StreamType", typeof (PlayerApiStreamType));
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

		internal PlayerApiStreamType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='PlayerApi.StreamType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/android/appremote/api/PlayerApi$StreamType;", "")]
		public static unsafe global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/spotify/android/appremote/api/PlayerApi$StreamType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='PlayerApi.StreamType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/spotify/android/appremote/api/PlayerApi$StreamType;", "")]
		public static unsafe global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType[] Values ()
		{
			const string __id = "values.()[Lcom/spotify/android/appremote/api/PlayerApi$StreamType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']"
	[Register ("com/spotify/android/appremote/api/PlayerApi", "", "Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker")]
	public partial interface IPlayerApi : IJavaObject {

		global::Com.Spotify.Protocol.Client.CallResult PlayerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='getPlayerState' and count(parameter)=0]"
			[Register ("getPlayerState", "()Lcom/spotify/protocol/client/CallResult;", "GetGetPlayerStateHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()Lcom/spotify/protocol/client/CallResult;", "GetPauseHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='play' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("play", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetPlay_Ljava_lang_String_Handler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult Play (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='play' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.spotify.android.appremote.api.PlayerApi.StreamType']]"
		[Register ("play", "(Ljava/lang/String;Lcom/spotify/android/appremote/api/PlayerApi$StreamType;)Lcom/spotify/protocol/client/CallResult;", "GetPlay_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_Handler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult Play (string p0, global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='queue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queue", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetQueue_Ljava_lang_String_Handler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult Queue (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()Lcom/spotify/protocol/client/CallResult;", "GetResumeHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult Resume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)Lcom/spotify/protocol/client/CallResult;", "GetSeekTo_JHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult SeekTo (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='setRepeat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeat", "(I)Lcom/spotify/protocol/client/CallResult;", "GetSetRepeat_IHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult SetRepeat (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='setShuffle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShuffle", "(Z)Lcom/spotify/protocol/client/CallResult;", "GetSetShuffle_ZHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult SetShuffle (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='skipNext' and count(parameter)=0]"
		[Register ("skipNext", "()Lcom/spotify/protocol/client/CallResult;", "GetSkipNextHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult SkipNext ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='skipPrevious' and count(parameter)=0]"
		[Register ("skipPrevious", "()Lcom/spotify/protocol/client/CallResult;", "GetSkipPreviousHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult SkipPrevious ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='subscribeToPlayerContext' and count(parameter)=0]"
		[Register ("subscribeToPlayerContext", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToPlayerContextHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.Subscription SubscribeToPlayerContext ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='subscribeToPlayerState' and count(parameter)=0]"
		[Register ("subscribeToPlayerState", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToPlayerStateHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.Subscription SubscribeToPlayerState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='toggleRepeat' and count(parameter)=0]"
		[Register ("toggleRepeat", "()Lcom/spotify/protocol/client/CallResult;", "GetToggleRepeatHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult ToggleRepeat ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='PlayerApi']/method[@name='toggleShuffle' and count(parameter)=0]"
		[Register ("toggleShuffle", "()Lcom/spotify/protocol/client/CallResult;", "GetToggleShuffleHandler:Com.Spotify.Android.Appremote.Api.IPlayerApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult ToggleShuffle ();

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/PlayerApi", DoNotGenerateAcw=true)]
	internal class IPlayerApiInvoker : global::Java.Lang.Object, IPlayerApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/PlayerApi", typeof (IPlayerApiInvoker));

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

		public static IPlayerApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayerApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.PlayerApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPlayerState;
#pragma warning disable 0169
		static Delegate GetGetPlayerStateHandler ()
		{
			if (cb_getPlayerState == null)
				cb_getPlayerState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerState);
			return cb_getPlayerState;
		}

		static IntPtr n_GetPlayerState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayerState);
		}
#pragma warning restore 0169

		IntPtr id_getPlayerState;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult PlayerState {
			get {
				if (id_getPlayerState == IntPtr.Zero)
					id_getPlayerState = JNIEnv.GetMethodID (class_ref, "getPlayerState", "()Lcom/spotify/protocol/client/CallResult;");
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayerState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static IntPtr n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pause ());
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pause), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_play_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlay_Ljava_lang_String_Handler ()
		{
			if (cb_play_Ljava_lang_String_ == null)
				cb_play_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Play_Ljava_lang_String_);
			return cb_play_Ljava_lang_String_;
		}

		static IntPtr n_Play_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Play (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_play_Ljava_lang_String_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Play (string p0)
		{
			if (id_play_Ljava_lang_String_ == IntPtr.Zero)
				id_play_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "play", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_play_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_;
#pragma warning disable 0169
		static Delegate GetPlay_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_Handler ()
		{
			if (cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ == null)
				cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_);
			return cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_;
		}

		static IntPtr n_Play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Play (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Play (string p0, global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType p1)
		{
			if (id_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ == IntPtr.Zero)
				id_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ = JNIEnv.GetMethodID (class_ref, "play", "(Ljava/lang/String;Lcom/spotify/android/appremote/api/PlayerApi$StreamType;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_queue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueue_Ljava_lang_String_Handler ()
		{
			if (cb_queue_Ljava_lang_String_ == null)
				cb_queue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Queue_Ljava_lang_String_);
			return cb_queue_Ljava_lang_String_;
		}

		static IntPtr n_Queue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Queue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_queue_Ljava_lang_String_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Queue (string p0)
		{
			if (id_queue_Ljava_lang_String_ == IntPtr.Zero)
				id_queue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queue", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static IntPtr n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resume ());
		}
#pragma warning restore 0169

		IntPtr id_resume;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resume), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static IntPtr n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekTo (p0));
		}
#pragma warning restore 0169

		IntPtr id_seekTo_J;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setRepeat_I;
#pragma warning disable 0169
		static Delegate GetSetRepeat_IHandler ()
		{
			if (cb_setRepeat_I == null)
				cb_setRepeat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetRepeat_I);
			return cb_setRepeat_I;
		}

		static IntPtr n_SetRepeat_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRepeat (p0));
		}
#pragma warning restore 0169

		IntPtr id_setRepeat_I;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult SetRepeat (int p0)
		{
			if (id_setRepeat_I == IntPtr.Zero)
				id_setRepeat_I = JNIEnv.GetMethodID (class_ref, "setRepeat", "(I)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRepeat_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setShuffle_Z;
#pragma warning disable 0169
		static Delegate GetSetShuffle_ZHandler ()
		{
			if (cb_setShuffle_Z == null)
				cb_setShuffle_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShuffle_Z);
			return cb_setShuffle_Z;
		}

		static IntPtr n_SetShuffle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShuffle (p0));
		}
#pragma warning restore 0169

		IntPtr id_setShuffle_Z;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult SetShuffle (bool p0)
		{
			if (id_setShuffle_Z == IntPtr.Zero)
				id_setShuffle_Z = JNIEnv.GetMethodID (class_ref, "setShuffle", "(Z)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShuffle_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_skipNext;
#pragma warning disable 0169
		static Delegate GetSkipNextHandler ()
		{
			if (cb_skipNext == null)
				cb_skipNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SkipNext);
			return cb_skipNext;
		}

		static IntPtr n_SkipNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkipNext ());
		}
#pragma warning restore 0169

		IntPtr id_skipNext;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult SkipNext ()
		{
			if (id_skipNext == IntPtr.Zero)
				id_skipNext = JNIEnv.GetMethodID (class_ref, "skipNext", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipNext), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_skipPrevious;
#pragma warning disable 0169
		static Delegate GetSkipPreviousHandler ()
		{
			if (cb_skipPrevious == null)
				cb_skipPrevious = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SkipPrevious);
			return cb_skipPrevious;
		}

		static IntPtr n_SkipPrevious (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkipPrevious ());
		}
#pragma warning restore 0169

		IntPtr id_skipPrevious;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult SkipPrevious ()
		{
			if (id_skipPrevious == IntPtr.Zero)
				id_skipPrevious = JNIEnv.GetMethodID (class_ref, "skipPrevious", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipPrevious), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_subscribeToPlayerContext;
#pragma warning disable 0169
		static Delegate GetSubscribeToPlayerContextHandler ()
		{
			if (cb_subscribeToPlayerContext == null)
				cb_subscribeToPlayerContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SubscribeToPlayerContext);
			return cb_subscribeToPlayerContext;
		}

		static IntPtr n_SubscribeToPlayerContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToPlayerContext ());
		}
#pragma warning restore 0169

		IntPtr id_subscribeToPlayerContext;
		public unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToPlayerContext ()
		{
			if (id_subscribeToPlayerContext == IntPtr.Zero)
				id_subscribeToPlayerContext = JNIEnv.GetMethodID (class_ref, "subscribeToPlayerContext", "()Lcom/spotify/protocol/client/Subscription;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToPlayerContext), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_subscribeToPlayerState;
#pragma warning disable 0169
		static Delegate GetSubscribeToPlayerStateHandler ()
		{
			if (cb_subscribeToPlayerState == null)
				cb_subscribeToPlayerState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SubscribeToPlayerState);
			return cb_subscribeToPlayerState;
		}

		static IntPtr n_SubscribeToPlayerState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToPlayerState ());
		}
#pragma warning restore 0169

		IntPtr id_subscribeToPlayerState;
		public unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToPlayerState ()
		{
			if (id_subscribeToPlayerState == IntPtr.Zero)
				id_subscribeToPlayerState = JNIEnv.GetMethodID (class_ref, "subscribeToPlayerState", "()Lcom/spotify/protocol/client/Subscription;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToPlayerState), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toggleRepeat;
#pragma warning disable 0169
		static Delegate GetToggleRepeatHandler ()
		{
			if (cb_toggleRepeat == null)
				cb_toggleRepeat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToggleRepeat);
			return cb_toggleRepeat;
		}

		static IntPtr n_ToggleRepeat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToggleRepeat ());
		}
#pragma warning restore 0169

		IntPtr id_toggleRepeat;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult ToggleRepeat ()
		{
			if (id_toggleRepeat == IntPtr.Zero)
				id_toggleRepeat = JNIEnv.GetMethodID (class_ref, "toggleRepeat", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toggleRepeat), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toggleShuffle;
#pragma warning disable 0169
		static Delegate GetToggleShuffleHandler ()
		{
			if (cb_toggleShuffle == null)
				cb_toggleShuffle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToggleShuffle);
			return cb_toggleShuffle;
		}

		static IntPtr n_ToggleShuffle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.IPlayerApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IPlayerApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToggleShuffle ());
		}
#pragma warning restore 0169

		IntPtr id_toggleShuffle;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult ToggleShuffle ()
		{
			if (id_toggleShuffle == IntPtr.Zero)
				id_toggleShuffle = JNIEnv.GetMethodID (class_ref, "toggleShuffle", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toggleShuffle), JniHandleOwnership.TransferLocalRef);
		}

	}

}
