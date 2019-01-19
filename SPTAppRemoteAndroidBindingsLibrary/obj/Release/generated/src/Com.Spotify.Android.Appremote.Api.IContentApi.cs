using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ContentApi$ContentType", DoNotGenerateAcw=true)]
	public sealed partial class ContentApiContentType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='AUTOMOTIVE']"
		[Register ("AUTOMOTIVE")]
		public static global::Com.Spotify.Android.Appremote.Api.ContentApiContentType Automotive {
			get {
				const string __id = "AUTOMOTIVE.Lcom/spotify/android/appremote/api/ContentApi$ContentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Spotify.Android.Appremote.Api.ContentApiContentType Default {
			get {
				const string __id = "DEFAULT.Lcom/spotify/android/appremote/api/ContentApi$ContentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='FITNESS']"
		[Register ("FITNESS")]
		public static global::Com.Spotify.Android.Appremote.Api.ContentApiContentType Fitness {
			get {
				const string __id = "FITNESS.Lcom/spotify/android/appremote/api/ContentApi$ContentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='NAVIGATION']"
		[Register ("NAVIGATION")]
		public static global::Com.Spotify.Android.Appremote.Api.ContentApiContentType Navigation {
			get {
				const string __id = "NAVIGATION.Lcom/spotify/android/appremote/api/ContentApi$ContentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='SLEEP']"
		[Register ("SLEEP")]
		public static global::Com.Spotify.Android.Appremote.Api.ContentApiContentType Sleep {
			get {
				const string __id = "SLEEP.Lcom/spotify/android/appremote/api/ContentApi$ContentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='WAKE']"
		[Register ("WAKE")]
		public static global::Com.Spotify.Android.Appremote.Api.ContentApiContentType Wake {
			get {
				const string __id = "WAKE.Lcom/spotify/android/appremote/api/ContentApi$ContentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/ContentApi$ContentType", typeof (ContentApiContentType));
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

		internal ContentApiContentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/android/appremote/api/ContentApi$ContentType;", "")]
		public static unsafe global::Com.Spotify.Android.Appremote.Api.ContentApiContentType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/spotify/android/appremote/api/ContentApi$ContentType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ContentApi.ContentType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/spotify/android/appremote/api/ContentApi$ContentType;", "")]
		public static unsafe global::Com.Spotify.Android.Appremote.Api.ContentApiContentType[] Values ()
		{
			const string __id = "values.()[Lcom/spotify/android/appremote/api/ContentApi$ContentType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Spotify.Android.Appremote.Api.ContentApiContentType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Android.Appremote.Api.ContentApiContentType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ContentApi']"
	[Register ("com/spotify/android/appremote/api/ContentApi", "", "Com.Spotify.Android.Appremote.Api.IContentApiInvoker")]
	public partial interface IContentApi : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ContentApi']/method[@name='getChildrenOfItem' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.types.ListItem'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getChildrenOfItem", "(Lcom/spotify/protocol/types/ListItem;II)Lcom/spotify/protocol/client/CallResult;", "GetGetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_IIHandler:Com.Spotify.Android.Appremote.Api.IContentApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult GetChildrenOfItem (global::Com.Spotify.Protocol.Types.ListItem p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ContentApi']/method[@name='getRecommendedContentItems' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.ContentApi.ContentType']]"
		[Register ("getRecommendedContentItems", "(Lcom/spotify/android/appremote/api/ContentApi$ContentType;)Lcom/spotify/protocol/client/CallResult;", "GetGetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_Handler:Com.Spotify.Android.Appremote.Api.IContentApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult GetRecommendedContentItems (global::Com.Spotify.Android.Appremote.Api.ContentApiContentType p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/interface[@name='ContentApi']/method[@name='playContentItem' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.ListItem']]"
		[Register ("playContentItem", "(Lcom/spotify/protocol/types/ListItem;)Lcom/spotify/protocol/client/CallResult;", "GetPlayContentItem_Lcom_spotify_protocol_types_ListItem_Handler:Com.Spotify.Android.Appremote.Api.IContentApiInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Client.CallResult PlayContentItem (global::Com.Spotify.Protocol.Types.ListItem p0);

	}

	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ContentApi", DoNotGenerateAcw=true)]
	internal class IContentApiInvoker : global::Java.Lang.Object, IContentApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/android/appremote/api/ContentApi", typeof (IContentApiInvoker));

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

		public static IContentApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContentApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.android.appremote.api.ContentApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContentApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II;
#pragma warning disable 0169
		static Delegate GetGetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_IIHandler ()
		{
			if (cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II == null)
				cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II);
			return cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II;
		}

		static IntPtr n_GetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Spotify.Android.Appremote.Api.IContentApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IContentApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.ListItem p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ListItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChildrenOfItem (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult GetChildrenOfItem (global::Com.Spotify.Protocol.Types.ListItem p0, int p1, int p2)
		{
			if (id_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II == IntPtr.Zero)
				id_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II = JNIEnv.GetMethodID (class_ref, "getChildrenOfItem", "(Lcom/spotify/protocol/types/ListItem;II)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_;
#pragma warning disable 0169
		static Delegate GetGetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_Handler ()
		{
			if (cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ == null)
				cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_);
			return cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_;
		}

		static IntPtr n_GetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IContentApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IContentApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.ContentApiContentType p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRecommendedContentItems (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult GetRecommendedContentItems (global::Com.Spotify.Android.Appremote.Api.ContentApiContentType p0)
		{
			if (id_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ == IntPtr.Zero)
				id_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ = JNIEnv.GetMethodID (class_ref, "getRecommendedContentItems", "(Lcom/spotify/android/appremote/api/ContentApi$ContentType;)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_playContentItem_Lcom_spotify_protocol_types_ListItem_;
#pragma warning disable 0169
		static Delegate GetPlayContentItem_Lcom_spotify_protocol_types_ListItem_Handler ()
		{
			if (cb_playContentItem_Lcom_spotify_protocol_types_ListItem_ == null)
				cb_playContentItem_Lcom_spotify_protocol_types_ListItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PlayContentItem_Lcom_spotify_protocol_types_ListItem_);
			return cb_playContentItem_Lcom_spotify_protocol_types_ListItem_;
		}

		static IntPtr n_PlayContentItem_Lcom_spotify_protocol_types_ListItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Android.Appremote.Api.IContentApi __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.IContentApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.ListItem p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ListItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PlayContentItem (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_playContentItem_Lcom_spotify_protocol_types_ListItem_;
		public unsafe global::Com.Spotify.Protocol.Client.CallResult PlayContentItem (global::Com.Spotify.Protocol.Types.ListItem p0)
		{
			if (id_playContentItem_Lcom_spotify_protocol_types_ListItem_ == IntPtr.Zero)
				id_playContentItem_Lcom_spotify_protocol_types_ListItem_ = JNIEnv.GetMethodID (class_ref, "playContentItem", "(Lcom/spotify/protocol/types/ListItem;)Lcom/spotify/protocol/client/CallResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Spotify.Protocol.Client.CallResult __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_playContentItem_Lcom_spotify_protocol_types_ListItem_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
