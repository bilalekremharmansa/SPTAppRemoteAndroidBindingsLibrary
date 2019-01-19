using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='MotionStateApi']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/spotify/android/appremote/api/MotionStateApi", "", "Com.Spotify.Android.Appremote.Api.IMotionStateApiInvoker")]
	public partial interface IMotionStateApi : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='MotionStateApi']/method[@name='subscribeToMotionState' and count(parameter)=0]"
		[Register ("subscribeToMotionState", "()Lcom/spotify/protocol/client/Subscription;", "GetSubscribeToMotionStateHandler:Com.Spotify.Android.Appremote.Api.IMotionStateApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.Subscription SubscribeToMotionState ();

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/MotionStateApi", DoNotGenerateAcw=true)]
	internal class IMotionStateApiInvoker : global::Java.Lang.Object, IMotionStateApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/MotionStateApi", typeof (IMotionStateApiInvoker));

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

		public static IMotionStateApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMotionStateApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.MotionStateApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMotionStateApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Spotify.Android.Appremote.Api.IMotionStateApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IMotionStateApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubscribeToMotionState ());
		}
#pragma warning restore 0169

		IntPtr id_subscribeToMotionState;
		public unsafe global::Com.Spotify.Protocol.Client.Subscription SubscribeToMotionState ()
		{
			if (id_subscribeToMotionState == IntPtr.Zero)
				id_subscribeToMotionState = JNIEnv.GetMethodID (class_ref, "subscribeToMotionState", "()Lcom/spotify/protocol/client/Subscription;");
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.Subscription> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToMotionState), JniHandleOwnership.TransferLocalRef);
		}

	}

}
