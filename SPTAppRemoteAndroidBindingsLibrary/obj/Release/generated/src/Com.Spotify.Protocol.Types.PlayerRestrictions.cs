using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/PlayerRestrictions", DoNotGenerateAcw=true)]
	public partial class PlayerRestrictions : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Spotify.Protocol.Types.PlayerRestrictions Default {
			get {
				const string __id = "DEFAULT.Lcom/spotify/protocol/types/PlayerRestrictions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.PlayerRestrictions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='canRepeatContext']"
		[Register ("canRepeatContext")]
		public bool CanRepeatContext {
			get {
				const string __id = "canRepeatContext.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canRepeatContext.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='canRepeatTrack']"
		[Register ("canRepeatTrack")]
		public bool CanRepeatTrack {
			get {
				const string __id = "canRepeatTrack.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canRepeatTrack.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='canSeek']"
		[Register ("canSeek")]
		public bool CanSeek {
			get {
				const string __id = "canSeek.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canSeek.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='canSkipNext']"
		[Register ("canSkipNext")]
		public bool CanSkipNext {
			get {
				const string __id = "canSkipNext.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canSkipNext.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='canSkipPrev']"
		[Register ("canSkipPrev")]
		public bool CanSkipPrev {
			get {
				const string __id = "canSkipPrev.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canSkipPrev.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/field[@name='canToggleShuffle']"
		[Register ("canToggleShuffle")]
		public bool CanToggleShuffle {
			get {
				const string __id = "canToggleShuffle.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canToggleShuffle.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/PlayerRestrictions", typeof (PlayerRestrictions));
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

		protected PlayerRestrictions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='PlayerRestrictions']/constructor[@name='PlayerRestrictions' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(ZZZZZZ)V", "")]
		public unsafe PlayerRestrictions (bool canSkipNext, bool canSkipPrev, bool canRepeatTrack, bool canRepeatContext, bool canToggleShuffle, bool canSeek)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZZZZZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (canSkipNext);
				__args [1] = new JniArgumentValue (canSkipPrev);
				__args [2] = new JniArgumentValue (canRepeatTrack);
				__args [3] = new JniArgumentValue (canRepeatContext);
				__args [4] = new JniArgumentValue (canToggleShuffle);
				__args [5] = new JniArgumentValue (canSeek);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
