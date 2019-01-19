using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ImagesApiImpl']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/ImagesApiImpl", DoNotGenerateAcw=true)]
	public partial class ImagesApiImpl : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Api.IImagesApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/ImagesApiImpl", typeof (ImagesApiImpl));
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

		protected ImagesApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ImagesApiImpl']/constructor[@name='ImagesApiImpl' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe ImagesApiImpl (global::Com.Spotify.Protocol.Client.IRemoteClient remoteClient)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/client/RemoteClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((remoteClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteClient).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getImage_Lcom_spotify_protocol_types_ImageUri_;
#pragma warning disable 0169
		static Delegate GetGetImage_Lcom_spotify_protocol_types_ImageUri_Handler ()
		{
			if (cb_getImage_Lcom_spotify_protocol_types_ImageUri_ == null)
				cb_getImage_Lcom_spotify_protocol_types_ImageUri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImage_Lcom_spotify_protocol_types_ImageUri_);
			return cb_getImage_Lcom_spotify_protocol_types_ImageUri_;
		}

		static IntPtr n_GetImage_Lcom_spotify_protocol_types_ImageUri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageUri)
		{
			global::Com.Spotify.Android.Appremote.Internal.ImagesApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.ImagesApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.ImageUri imageUri = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ImageUri> (native_imageUri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImage (imageUri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ImagesApiImpl']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.ImageUri']]"
		[Register ("getImage", "(Lcom/spotify/protocol/types/ImageUri;)Lcom/spotify/protocol/client/CallResult;", "GetGetImage_Lcom_spotify_protocol_types_ImageUri_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult GetImage (global::Com.Spotify.Protocol.Types.ImageUri imageUri)
		{
			const string __id = "getImage.(Lcom/spotify/protocol/types/ImageUri;)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageUri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
