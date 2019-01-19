using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/HelloDetails", DoNotGenerateAcw=true)]
	public partial class HelloDetails : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']/field[@name='authid']"
		[Register ("authid")]
		public string Authid {
			get {
				const string __id = "authid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "authid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']/field[@name='authmethods']"
		[Register ("authmethods")]
		public IList<string> Authmethods {
			get {
				const string __id = "authmethods.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "authmethods.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']/field[@name='extras']"
		[Register ("extras")]
		public global::System.Collections.IDictionary Extras {
			get {
				const string __id = "extras.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "extras.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']/field[@name='info']"
		[Register ("info")]
		public global::Com.Spotify.Protocol.Types.Info Info {
			get {
				const string __id = "info.Lcom/spotify/protocol/types/Info;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Info> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "info.Lcom/spotify/protocol/types/Info;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']/field[@name='roles']"
		[Register ("roles")]
		public global::Com.Spotify.Protocol.Types.Roles Roles {
			get {
				const string __id = "roles.Lcom/spotify/protocol/types/Roles;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Roles> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "roles.Lcom/spotify/protocol/types/Roles;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/HelloDetails", typeof (HelloDetails));
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

		protected HelloDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='HelloDetails']/constructor[@name='HelloDetails' and count(parameter)=5 and parameter[1][@type='com.spotify.protocol.types.Roles'] and parameter[2][@type='com.spotify.protocol.types.Info'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Roles;Lcom/spotify/protocol/types/Info;[Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe HelloDetails (global::Com.Spotify.Protocol.Types.Roles roles, global::Com.Spotify.Protocol.Types.Info info, string[] authmethods, string authid, global::System.Collections.Generic.IDictionary<string, string> extras)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Roles;Lcom/spotify/protocol/types/Info;[Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_authmethods = JNIEnv.NewArray (authmethods);
			IntPtr native_authid = JNIEnv.NewString (authid);
			IntPtr native_extras = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (extras);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((roles == null) ? IntPtr.Zero : ((global::Java.Lang.Object) roles).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				__args [2] = new JniArgumentValue (native_authmethods);
				__args [3] = new JniArgumentValue (native_authid);
				__args [4] = new JniArgumentValue (native_extras);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (authmethods != null) {
					JNIEnv.CopyArray (native_authmethods, authmethods);
					JNIEnv.DeleteLocalRef (native_authmethods);
				}
				JNIEnv.DeleteLocalRef (native_authid);
				JNIEnv.DeleteLocalRef (native_extras);
			}
		}

	}
}
