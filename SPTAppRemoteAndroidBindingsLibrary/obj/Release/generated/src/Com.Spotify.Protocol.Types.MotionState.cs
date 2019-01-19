using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/MotionState", DoNotGenerateAcw=true)]
	public partial class MotionState : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='DETECTED']"
		[Register ("DETECTED")]
		public const int Detected = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='DETECTING']"
		[Register ("DETECTING")]
		public const int Detecting = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='INITIAL']"
		[Register ("INITIAL")]
		public const int Initial = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='SKIPPED']"
		[Register ("SKIPPED")]
		public const int Skipped = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public const int Unknown = (int) -1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/field[@name='state']"
		[Register ("state")]
		public int State {
			get {
				const string __id = "state.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "state.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/MotionState", typeof (MotionState));
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

		protected MotionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='MotionState']/constructor[@name='MotionState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MotionState (int state)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (state);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
