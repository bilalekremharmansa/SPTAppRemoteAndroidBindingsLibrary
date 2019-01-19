using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/Roles", DoNotGenerateAcw=true)]
	public partial class Roles : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']/field[@name='broker']"
		[Register ("broker")]
		public global::Com.Spotify.Protocol.Types.Empty Broker {
			get {
				const string __id = "broker.Lcom/spotify/protocol/types/Empty;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Empty> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "broker.Lcom/spotify/protocol/types/Empty;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']/field[@name='caller']"
		[Register ("caller")]
		public global::Com.Spotify.Protocol.Types.Empty Caller {
			get {
				const string __id = "caller.Lcom/spotify/protocol/types/Empty;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Empty> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "caller.Lcom/spotify/protocol/types/Empty;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']/field[@name='dealer']"
		[Register ("dealer")]
		public global::Com.Spotify.Protocol.Types.Empty Dealer {
			get {
				const string __id = "dealer.Lcom/spotify/protocol/types/Empty;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Empty> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dealer.Lcom/spotify/protocol/types/Empty;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']/field[@name='subscriber']"
		[Register ("subscriber")]
		public global::Com.Spotify.Protocol.Types.Empty Subscriber {
			get {
				const string __id = "subscriber.Lcom/spotify/protocol/types/Empty;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Empty> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subscriber.Lcom/spotify/protocol/types/Empty;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/Roles", typeof (Roles));
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

		protected Roles (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']/constructor[@name='Roles' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Roles ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Roles']/constructor[@name='Roles' and count(parameter)=4 and parameter[1][@type='com.spotify.protocol.types.Empty'] and parameter[2][@type='com.spotify.protocol.types.Empty'] and parameter[3][@type='com.spotify.protocol.types.Empty'] and parameter[4][@type='com.spotify.protocol.types.Empty']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Empty;Lcom/spotify/protocol/types/Empty;Lcom/spotify/protocol/types/Empty;Lcom/spotify/protocol/types/Empty;)V", "")]
		public unsafe Roles (global::Com.Spotify.Protocol.Types.Empty dealer, global::Com.Spotify.Protocol.Types.Empty broker, global::Com.Spotify.Protocol.Types.Empty subscriber, global::Com.Spotify.Protocol.Types.Empty caller)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Empty;Lcom/spotify/protocol/types/Empty;Lcom/spotify/protocol/types/Empty;Lcom/spotify/protocol/types/Empty;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((dealer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dealer).Handle);
				__args [1] = new JniArgumentValue ((broker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) broker).Handle);
				__args [2] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				__args [3] = new JniArgumentValue ((caller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caller).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
