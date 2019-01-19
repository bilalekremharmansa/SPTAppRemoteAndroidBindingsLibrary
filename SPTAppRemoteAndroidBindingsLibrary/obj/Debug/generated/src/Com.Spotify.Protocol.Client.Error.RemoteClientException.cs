using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client.error']/class[@name='RemoteClientException']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/error/RemoteClientException", DoNotGenerateAcw=true)]
	public partial class RemoteClientException : global::Com.Spotify.Protocol.Error.SpotifyAppRemoteException {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/error/RemoteClientException", typeof (RemoteClientException));
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

		protected RemoteClientException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client.error']/class[@name='RemoteClientException']/constructor[@name='RemoteClientException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RemoteClientException (string detailMessage, string reasonUri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			IntPtr native_reasonUri = JNIEnv.NewString (reasonUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_detailMessage);
				__args [1] = new JniArgumentValue (native_reasonUri);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_detailMessage);
				JNIEnv.DeleteLocalRef (native_reasonUri);
			}
		}

		static Delegate cb_getReasonUri;
#pragma warning disable 0169
		static Delegate GetGetReasonUriHandler ()
		{
			if (cb_getReasonUri == null)
				cb_getReasonUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReasonUri);
			return cb_getReasonUri;
		}

		static IntPtr n_GetReasonUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.Error.RemoteClientException __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Error.RemoteClientException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReasonUri);
		}
#pragma warning restore 0169

		public virtual unsafe string ReasonUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client.error']/class[@name='RemoteClientException']/method[@name='getReasonUri' and count(parameter)=0]"
			[Register ("getReasonUri", "()Ljava/lang/String;", "GetGetReasonUriHandler")]
			get {
				const string __id = "getReasonUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
