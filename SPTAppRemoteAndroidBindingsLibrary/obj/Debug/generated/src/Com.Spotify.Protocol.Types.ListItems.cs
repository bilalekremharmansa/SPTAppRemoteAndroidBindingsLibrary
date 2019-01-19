using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItems']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/ListItems", DoNotGenerateAcw=true)]
	public partial class ListItems : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItems']/field[@name='items']"
		[Register ("items")]
		public IList<Com.Spotify.Protocol.Types.ListItem> Items {
			get {
				const string __id = "items.[Lcom/spotify/protocol/types/ListItem;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Com.Spotify.Protocol.Types.ListItem>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "items.[Lcom/spotify/protocol/types/ListItem;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Spotify.Protocol.Types.ListItem>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItems']/field[@name='limit']"
		[Register ("limit")]
		public int Limit {
			get {
				const string __id = "limit.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "limit.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItems']/field[@name='offset']"
		[Register ("offset")]
		public int Offset {
			get {
				const string __id = "offset.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "offset.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItems']/field[@name='total']"
		[Register ("total")]
		public int Total {
			get {
				const string __id = "total.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "total.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/ListItems", typeof (ListItems));
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

		protected ListItems (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItems']/constructor[@name='ListItems' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.spotify.protocol.types.ListItem[]']]"
		[Register (".ctor", "(III[Lcom/spotify/protocol/types/ListItem;)V", "")]
		public unsafe ListItems (int limit, int offset, int total, global::Com.Spotify.Protocol.Types.ListItem[] items)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III[Lcom/spotify/protocol/types/ListItem;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (limit);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (total);
				__args [3] = new JniArgumentValue (native_items);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

	}
}
