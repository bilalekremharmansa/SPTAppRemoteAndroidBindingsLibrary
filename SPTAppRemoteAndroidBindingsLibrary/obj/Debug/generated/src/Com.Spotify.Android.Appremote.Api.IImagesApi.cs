using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ImagesApi']"
	[Register ("com/spotify/android/appremote/api/ImagesApi", "", "Com.Spotify.Android.Appremote.Api.IImagesApiInvoker")]
	public partial interface IImagesApi : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ImagesApi']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.ImageUri']]"
		[Register ("getImage", "(Lcom/spotify/protocol/types/ImageUri;)Lcom/spotify/protocol/client/CallResult;", "GetGetImage_Lcom_spotify_protocol_types_ImageUri_Handler:Com.Spotify.Android.Appremote.Api.IImagesApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult GetImage (global::Com.Spotify.Protocol.Types.ImageUri p0);

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ImagesApi", DoNotGenerateAcw=true)]
	internal class IImagesApiInvoker : global::Java.Lang.Object, IImagesApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/ImagesApi", typeof (IImagesApiInvoker));

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

		public static IImagesApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImagesApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.ImagesApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImagesApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getImage_Lcom_spotify_protocol_types_ImageUri_;
#pragma warning disable 0169
		static Delegate GetGetImage_Lcom_spotify_protocol_types_ImageUri_Handler ()
		{
			if (cb_getImage_Lcom_spotify_protocol_types_ImageUri_ == null)
				cb_getImage_Lcom_spotify_protocol_types_ImageUri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImage_Lcom_spotify_protocol_types_ImageUri_);
			return cb_getImage_Lcom_spotify_protocol_types_ImageUri_;
		}

		static IntPtr n_GetImage_Lcom_spotify_protocol_types_ImageUri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IImagesApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IImagesApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.ImageUri p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ImageUri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getImage_Lcom_spotify_protocol_types_ImageUri_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult GetImage (global::Com.Spotify.Protocol.Types.ImageUri p0)
		{
			if (id_getImage_Lcom_spotify_protocol_types_ImageUri_ == IntPtr.Zero)
				id_getImage_Lcom_spotify_protocol_types_ImageUri_ = JNIEnv.GetMethodID (class_ref, "getImage", "(Lcom/spotify/protocol/types/ImageUri;)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage_Lcom_spotify_protocol_types_ImageUri_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
