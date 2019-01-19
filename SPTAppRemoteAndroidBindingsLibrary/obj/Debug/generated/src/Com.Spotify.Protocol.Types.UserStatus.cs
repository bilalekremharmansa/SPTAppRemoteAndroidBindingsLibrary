using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/UserStatus", DoNotGenerateAcw=true)]
	public partial class UserStatus : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/field[@name='STATUS_CODE_NOT_LOGGED_IN']"
		[Register ("STATUS_CODE_NOT_LOGGED_IN")]
		public const int StatusCodeNotLoggedIn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/field[@name='STATUS_CODE_OK']"
		[Register ("STATUS_CODE_OK")]
		public const int StatusCodeOk = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				const string __id = "code.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "code.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/field[@name='longMessage']"
		[Register ("longMessage")]
		public string LongMessage {
			get {
				const string __id = "longMessage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "longMessage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/field[@name='shortMessage']"
		[Register ("shortMessage")]
		public string ShortMessage {
			get {
				const string __id = "shortMessage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortMessage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/UserStatus", typeof (UserStatus));
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

		protected UserStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/constructor[@name='UserStatus' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe UserStatus (int statusCode, string shortMessage, string longMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_shortMessage = JNIEnv.NewString (shortMessage);
			IntPtr native_longMessage = JNIEnv.NewString (longMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (statusCode);
				__args [1] = new JniArgumentValue (native_shortMessage);
				__args [2] = new JniArgumentValue (native_longMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_shortMessage);
				JNIEnv.DeleteLocalRef (native_longMessage);
			}
		}

		static Delegate cb_isLoggedIn;
#pragma warning disable 0169
		static Delegate GetIsLoggedInHandler ()
		{
			if (cb_isLoggedIn == null)
				cb_isLoggedIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoggedIn);
			return cb_isLoggedIn;
		}

		static bool n_IsLoggedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Types.UserStatus __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.UserStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggedIn;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLoggedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='UserStatus']/method[@name='isLoggedIn' and count(parameter)=0]"
			[Register ("isLoggedIn", "()Z", "GetIsLoggedInHandler")]
			get {
				const string __id = "isLoggedIn.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
