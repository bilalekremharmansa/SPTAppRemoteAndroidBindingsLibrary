using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/PlayerApiImpl", DoNotGenerateAcw=true)]
	public partial class PlayerApiImpl : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Api.IPlayerApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/PlayerApiImpl", typeof (PlayerApiImpl));
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

		protected PlayerApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/constructor[@name='PlayerApiImpl' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe PlayerApiImpl (global::Com.Spotify.Protocol.Client.IRemoteClient client)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/client/RemoteClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayerState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult PlayerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='getPlayerState' and count(parameter)=0]"
			[Register ("getPlayerState", "()Lcom/spotify/protocol/client/CallResult;", "GetGetPlayerStateHandler")]
			get {
				const string __id = "getPlayerState.()Lcom/spotify/protocol/client/CallResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pause ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()Lcom/spotify/protocol/client/CallResult;", "GetPauseHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Pause ()
		{
			const string __id = "pause.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_play_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlay_Ljava_lang_String_Handler ()
		{
			if (cb_play_Ljava_lang_String_ == null)
				cb_play_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Play_Ljava_lang_String_);
			return cb_play_Ljava_lang_String_;
		}

		static IntPtr n_Play_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Play (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='play' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("play", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetPlay_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Play (string uri)
		{
			const string __id = "play.(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;";
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

		static Delegate cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_;
#pragma warning disable 0169
		static Delegate GetPlay_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_Handler ()
		{
			if (cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ == null)
				cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_);
			return cb_play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_;
		}

		static IntPtr n_Play_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_streamType)
		{
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType streamType = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType> (native_streamType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Play (uri, streamType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='play' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.spotify.android.appremote.api.PlayerApi.StreamType']]"
		[Register ("play", "(Ljava/lang/String;Lcom/spotify/android/appremote/api/PlayerApi$StreamType;)Lcom/spotify/protocol/client/CallResult;", "GetPlay_Ljava_lang_String_Lcom_spotify_android_appremote_api_PlayerApi_StreamType_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Play (string uri, global::Com.Spotify.Android.Appremote.Api.PlayerApiStreamType streamType)
		{
			const string __id = "play.(Ljava/lang/String;Lcom/spotify/android/appremote/api/PlayerApi$StreamType;)Lcom/spotify/protocol/client/CallResult;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue ((streamType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_queue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueue_Ljava_lang_String_Handler ()
		{
			if (cb_queue_Ljava_lang_String_ == null)
				cb_queue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Queue_Ljava_lang_String_);
			return cb_queue_Ljava_lang_String_;
		}

		static IntPtr n_Queue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Queue (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='queue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queue", "(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;", "GetQueue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Queue (string uri)
		{
			const string __id = "queue.(Ljava/lang/String;)Lcom/spotify/protocol/client/CallResult;";
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resume ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()Lcom/spotify/protocol/client/CallResult;", "GetResumeHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult Resume ()
		{
			const string __id = "resume.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static IntPtr n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long positionMs)
		{
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekTo (positionMs));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)Lcom/spotify/protocol/client/CallResult;", "GetSeekTo_JHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult SeekTo (long positionMs)
		{
			const string __id = "seekTo.(J)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionMs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRepeat_I;
#pragma warning disable 0169
		static Delegate GetSetRepeat_IHandler ()
		{
			if (cb_setRepeat_I == null)
				cb_setRepeat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetRepeat_I);
			return cb_setRepeat_I;
		}

		static IntPtr n_SetRepeat_I (IntPtr jnienv, IntPtr native__this, int repeatMode)
		{
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRepeat (repeatMode));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='setRepeat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeat", "(I)Lcom/spotify/protocol/client/CallResult;", "GetSetRepeat_IHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult SetRepeat (int repeatMode)
		{
			const string __id = "setRepeat.(I)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (repeatMode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setShuffle_Z;
#pragma warning disable 0169
		static Delegate GetSetShuffle_ZHandler ()
		{
			if (cb_setShuffle_Z == null)
				cb_setShuffle_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShuffle_Z);
			return cb_setShuffle_Z;
		}

		static IntPtr n_SetShuffle_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShuffle (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='setShuffle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShuffle", "(Z)Lcom/spotify/protocol/client/CallResult;", "GetSetShuffle_ZHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult SetShuffle (bool enabled)
		{
			const string __id = "setShuffle.(Z)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkipNext ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='skipNext' and count(parameter)=0]"
		[Register ("skipNext", "()Lcom/spotify/protocol/client/CallResult;", "GetSkipNextHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult SkipNext ()
		{
			const string __id = "skipNext.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkipPrevious ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='skipPrevious' and count(parameter)=0]"
		[Register ("skipPrevious", "()Lcom/spotify/protocol/client/CallResult;", "GetSkipPreviousHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult SkipPrevious ()
		{
			const string __id = "skipPrevious.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToPlayerContext ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='subscribeToPlayerContext' and count(parameter)=0]"
		[Register ("subscribeToPlayerContext", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToPlayerContextHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToPlayerContext ()
		{
			const string __id = "subscribeToPlayerContext.()Lcom/spotify/protocol/client/Subscription;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToPlayerState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='subscribeToPlayerState' and count(parameter)=0]"
		[Register ("subscribeToPlayerState", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToPlayerStateHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToPlayerState ()
		{
			const string __id = "subscribeToPlayerState.()Lcom/spotify/protocol/client/Subscription;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToggleRepeat ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='toggleRepeat' and count(parameter)=0]"
		[Register ("toggleRepeat", "()Lcom/spotify/protocol/client/CallResult;", "GetToggleRepeatHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult ToggleRepeat ()
		{
			const string __id = "toggleRepeat.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.PlayerApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToggleShuffle ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='PlayerApiImpl']/method[@name='toggleShuffle' and count(parameter)=0]"
		[Register ("toggleShuffle", "()Lcom/spotify/protocol/client/CallResult;", "GetToggleShuffleHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult ToggleShuffle ()
		{
			const string __id = "toggleShuffle.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
