using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='MotionStateApiImpl']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/MotionStateApiImpl", DoNotGenerateAcw=true)]
	public partial class MotionStateApiImpl : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Api.IMotionStateApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/MotionStateApiImpl", typeof (MotionStateApiImpl));
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

		protected MotionStateApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='MotionStateApiImpl']/constructor[@name='MotionStateApiImpl' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe MotionStateApiImpl (global::Com.Spotify.Protocol.Client.IRemoteClient client)
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

		static Delegate cb_subscribeToMotionState;
#pragma warning disable 0169
		static Delegate GetSubscribeToMotionStateHandler ()
		{
			if (cb_subscribeToMotionState == null)
				cb_subscribeToMotionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SubscribeToMotionState);
			return cb_subscribeToMotionState;
		}

		static IntPtr n_SubscribeToMotionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Internal.MotionStateApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.MotionStateApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToMotionState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='MotionStateApiImpl']/method[@name='subscribeToMotionState' and count(parameter)=0]"
		[Register ("subscribeToMotionState", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToMotionStateHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToMotionState ()
		{
			const string __id = "subscribeToMotionState.()Lcom/spotify/protocol/client/Subscription;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
