using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ConnectApi']"
	[Register ("com/spotify/android/appremote/api/ConnectApi", "", "Com.Spotify.Android.Appremote.Api.IConnectApiInvoker")]
	public partial interface IConnectApi : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ConnectApi']/method[@name='connectSwitchToLocalDevice' and count(parameter)=0]"
		[Register ("connectSwitchToLocalDevice", "()Lcom/spotify/protocol/client/CallResult;", "GetConnectSwitchToLocalDeviceHandler:Com.Spotify.Android.Appremote.Api.IConnectApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult ConnectSwitchToLocalDevice ();

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ConnectApi", DoNotGenerateAcw=true)]
	internal class IConnectApiInvoker : global::Java.Lang.Object, IConnectApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/ConnectApi", typeof (IConnectApiInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConnectApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.ConnectApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Spotify.Android.Appremote.Api.IConnectApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IConnectApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectSwitchToLocalDevice ());
		}
#pragma warning restore 0169

		IntPtr id_connectSwitchToLocalDevice;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult ConnectSwitchToLocalDevice ()
		{
			if (id_connectSwitchToLocalDevice == IntPtr.Zero)
				id_connectSwitchToLocalDevice = JNIEnv.GetMethodID (class_ref, "connectSwitchToLocalDevice", "()Lcom/spotify/protocol/client/CallResult;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectSwitchToLocalDevice), JniHandleOwnership.TransferLocalRef);
		}

	}

}
