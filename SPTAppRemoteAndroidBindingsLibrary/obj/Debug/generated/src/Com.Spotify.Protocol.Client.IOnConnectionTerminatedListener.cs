using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='OnConnectionTerminatedListener']"
	[Register ("com/spotify/protocol/client/OnConnectionTerminatedListener", "", "Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerInvoker")]
	public partial interface IOnConnectionTerminatedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/interface[@name='OnConnectionTerminatedListener']/method[@name='onConnectionTerminated' and count(parameter)=0]"
		[Register ("onConnectionTerminated", "()V", "GetOnConnectionTerminatedHandler:Com.Spotify.Protocol.Client.IOnConnectionTerminatedListenerInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		void OnConnectionTerminated ();

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/client/OnConnectionTerminatedListener", DoNotGenerateAcw=true)]
	internal class IOnConnectionTerminatedListenerInvoker : global::Java.Lang.Object, IOnConnectionTerminatedListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/client/OnConnectionTerminatedListener", typeof (IOnConnectionTerminatedListenerInvoker));

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

		public static IOnConnectionTerminatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnConnectionTerminatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.client.OnConnectionTerminatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnConnectionTerminatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectionTerminated;
#pragma warning disable 0169
		static Delegate GetOnConnectionTerminatedHandler ()
		{
			if (cb_onConnectionTerminated == null)
				cb_onConnectionTerminated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionTerminated);
			return cb_onConnectionTerminated;
		}

		static void n_OnConnectionTerminated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.IOnConnectionTerminatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionTerminated ();
		}
#pragma warning restore 0169

		IntPtr id_onConnectionTerminated;
		public unsafe void OnConnectionTerminated ()
		{
			if (id_onConnectionTerminated == IntPtr.Zero)
				id_onConnectionTerminated = JNIEnv.GetMethodID (class_ref, "onConnectionTerminated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionTerminated);
		}

	}

	[global::Android.Runtime.Register ("mono/com/spotify/protocol/client/OnConnectionTerminatedListenerImplementor")]
	internal sealed partial class IOnConnectionTerminatedListenerImplementor : global::Java.Lang.Object, IOnConnectionTerminatedListener {

		object sender;

		public IOnConnectionTerminatedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/spotify/protocol/client/OnConnectionTerminatedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnConnectionTerminated ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnConnectionTerminatedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
