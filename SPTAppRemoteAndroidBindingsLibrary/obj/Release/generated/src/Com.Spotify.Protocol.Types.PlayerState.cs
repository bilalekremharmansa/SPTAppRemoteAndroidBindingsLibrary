using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/PlayerState", DoNotGenerateAcw=true)]
	public partial class PlayerState : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/field[@name='isPaused']"
		[Register ("isPaused")]
		public bool IsPaused {
			get {
				const string __id = "isPaused.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isPaused.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/field[@name='playbackOptions']"
		[Register ("playbackOptions")]
		public global::Com.Spotify.Protocol.Types.PlayerOptions PlaybackOptions {
			get {
				const string __id = "playbackOptions.Lcom/spotify/protocol/types/PlayerOptions;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.PlayerOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "playbackOptions.Lcom/spotify/protocol/types/PlayerOptions;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/field[@name='playbackPosition']"
		[Register ("playbackPosition")]
		public long PlaybackPosition {
			get {
				const string __id = "playbackPosition.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "playbackPosition.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/field[@name='playbackRestrictions']"
		[Register ("playbackRestrictions")]
		public global::Com.Spotify.Protocol.Types.PlayerRestrictions PlaybackRestrictions {
			get {
				const string __id = "playbackRestrictions.Lcom/spotify/protocol/types/PlayerRestrictions;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.PlayerRestrictions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "playbackRestrictions.Lcom/spotify/protocol/types/PlayerRestrictions;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/field[@name='playbackSpeed']"
		[Register ("playbackSpeed")]
		public float PlaybackSpeed {
			get {
				const string __id = "playbackSpeed.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "playbackSpeed.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/field[@name='track']"
		[Register ("track")]
		public global::Com.Spotify.Protocol.Types.Track Track {
			get {
				const string __id = "track.Lcom/spotify/protocol/types/Track;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Track> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "track.Lcom/spotify/protocol/types/Track;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/PlayerState", typeof (PlayerState));
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

		protected PlayerState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerState']/constructor[@name='PlayerState' and count(parameter)=6 and parameter[1][@type='com.spotify.protocol.types.Track'] and parameter[2][@type='boolean'] and parameter[3][@type='float'] and parameter[4][@type='long'] and parameter[5][@type='com.spotify.protocol.types.PlayerOptions'] and parameter[6][@type='com.spotify.protocol.types.PlayerRestrictions']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Track;ZFJLcom/spotify/protocol/types/PlayerOptions;Lcom/spotify/protocol/types/PlayerRestrictions;)V", "")]
		public unsafe PlayerState (global::Com.Spotify.Protocol.Types.Track track, bool isPaused, float playbackSpeed, long playbackPosition, global::Com.Spotify.Protocol.Types.PlayerOptions playbackOptions, global::Com.Spotify.Protocol.Types.PlayerRestrictions playbackRestrictions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Track;ZFJLcom/spotify/protocol/types/PlayerOptions;Lcom/spotify/protocol/types/PlayerRestrictions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				__args [1] = new JniArgumentValue (isPaused);
				__args [2] = new JniArgumentValue (playbackSpeed);
				__args [3] = new JniArgumentValue (playbackPosition);
				__args [4] = new JniArgumentValue ((playbackOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackOptions).Handle);
				__args [5] = new JniArgumentValue ((playbackRestrictions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackRestrictions).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
