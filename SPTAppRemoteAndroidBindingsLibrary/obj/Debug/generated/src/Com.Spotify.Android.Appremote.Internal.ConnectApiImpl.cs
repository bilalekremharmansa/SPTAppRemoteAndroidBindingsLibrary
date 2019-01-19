using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ConnectApiImpl']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/ConnectApiImpl", DoNotGenerateAcw=true)]
	public partial class ConnectApiImpl : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Api.IConnectApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/ConnectApiImpl", typeof (ConnectApiImpl));
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

		protected ConnectApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ConnectApiImpl']/constructor[@name='ConnectApiImpl' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe ConnectApiImpl (global::Com.Spotify.Protocol.Client.IRemoteClient client)
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

		static Delegate cb_connectSwitchToLocalDevice;
#pragma warning disable 0169
		static Delegate GetConnectSwitchToLocalDeviceHandler ()
		{
			if (cb_connectSwitchToLocalDevice == null)
				cb_connectSwitchToLocalDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConnectSwitchToLocalDevice);
			return cb_connectSwitchToLocalDevice;
		}

		static IntPtr n_ConnectSwitchToLocalDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.ConnectApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.ConnectApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectSwitchToLocalDevice ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ConnectApiImpl']/method[@name='connectSwitchToLocalDevice' and count(parameter)=0]"
		[Register ("connectSwitchToLocalDevice", "()Lcom/spotify/protocol/client/CallResult;", "GetConnectSwitchToLocalDeviceHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult ConnectSwitchToLocalDevice ()
		{
			const string __id = "connectSwitchToLocalDevice.()Lcom/spotify/protocol/client/CallResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
