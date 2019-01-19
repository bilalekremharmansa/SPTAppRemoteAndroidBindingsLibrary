using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/ListItem", DoNotGenerateAcw=true)]
	public partial class ListItem : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='hasChildren']"
		[Register ("hasChildren")]
		public bool HasChildren {
			get {
				const string __id = "hasChildren.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "hasChildren.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				const string __id = "id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='imageUri']"
		[Register ("imageUri")]
		public global::Com.Spotify.Protocol.Types.ImageUri ImageUri {
			get {
				const string __id = "imageUri.Lcom/spotify/protocol/types/ImageUri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ImageUri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "imageUri.Lcom/spotify/protocol/types/ImageUri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='playable']"
		[Register ("playable")]
		public bool Playable {
			get {
				const string __id = "playable.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "playable.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='subtitle']"
		[Register ("subtitle")]
		public string Subtitle {
			get {
				const string __id = "subtitle.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subtitle.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				const string __id = "title.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "title.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/field[@name='uri']"
		[Register ("uri")]
		public string Uri {
			get {
				const string __id = "uri.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/ListItem", typeof (ListItem));
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

		protected ListItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='ListItem']/constructor[@name='ListItem' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.spotify.protocol.types.ImageUri'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/spotify/protocol/types/ImageUri;Ljava/lang/String;Ljava/lang/String;ZZ)V", "")]
		public unsafe ListItem (string id, string uri, global::Com.Spotify.Protocol.Types.ImageUri imageUri, string title, string subtitle, bool playable, bool hasChildren)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lcom/spotify/protocol/types/ImageUri;Ljava/lang/String;Ljava/lang/String;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_uri = JNIEnv.NewString (uri);
			IntPtr native_title = JNIEnv.NewString (title);
			IntPtr native_subtitle = JNIEnv.NewString (subtitle);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_uri);
				__args [2] = new JniArgumentValue ((imageUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageUri).Handle);
				__args [3] = new JniArgumentValue (native_title);
				__args [4] = new JniArgumentValue (native_subtitle);
				__args [5] = new JniArgumentValue (playable);
				__args [6] = new JniArgumentValue (hasChildren);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native_title);
				JNIEnv.DeleteLocalRef (native_subtitle);
			}
		}

	}
}
