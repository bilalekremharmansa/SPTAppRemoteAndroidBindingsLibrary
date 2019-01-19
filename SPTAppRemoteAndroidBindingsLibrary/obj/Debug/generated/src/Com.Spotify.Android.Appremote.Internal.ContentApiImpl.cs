using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ContentApiImpl']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/internal/ContentApiImpl", DoNotGenerateAcw=true)]
	public partial class ContentApiImpl : global::Java.Lang.Object, global::Com.Spotify.Android.Appremote.Api.IContentApi {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/internal/ContentApiImpl", typeof (ContentApiImpl));
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

		protected ContentApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ContentApiImpl']/constructor[@name='ContentApiImpl' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.client.RemoteClient']]"
		[Register (".ctor", "(Lcom/spotify/protocol/client/RemoteClient;)V", "")]
		public unsafe ContentApiImpl (global::Com.Spotify.Protocol.Client.IRemoteClient remoteClient)
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

		static Delegate cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II;
#pragma warning disable 0169
		static Delegate GetGetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_IIHandler ()
		{
			if (cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II == null)
				cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II);
			return cb_getChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II;
		}

		static IntPtr n_GetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_II (IntPtr jnienv, IntPtr native__this, IntPtr native_item, int perpage, int offset)
		{
			global::Com.Spotify.Android.Appremote.Internal.ContentApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.ContentApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.ListItem item = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ListItem> (native_item, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChildrenOfItem (item, perpage, offset));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ContentApiImpl']/method[@name='getChildrenOfItem' and count(parameter)=3 and parameter[1][@type='com.spotify.protocol.types.ListItem'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getChildrenOfItem", "(Lcom/spotify/protocol/types/ListItem;II)Lcom/spotify/protocol/client/CallResult;", "GetGetChildrenOfItem_Lcom_spotify_protocol_types_ListItem_IIHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult GetChildrenOfItem (global::Com.Spotify.Protocol.Types.ListItem item, int perpage, int offset)
		{
			const string __id = "getChildrenOfItem.(Lcom/spotify/protocol/types/ListItem;II)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				__args [1] = new JniArgumentValue (perpage);
				__args [2] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_;
#pragma warning disable 0169
		static Delegate GetGetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_Handler ()
		{
			if (cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ == null)
				cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_);
			return cb_getRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_;
		}

		static IntPtr n_GetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Spotify.Android.Appremote.Internal.ContentApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.ContentApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Android.Appremote.Api.ContentApiContentType type = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ContentApiContentType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRecommendedContentItems (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ContentApiImpl']/method[@name='getRecommendedContentItems' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.ContentApi.ContentType']]"
		[Register ("getRecommendedContentItems", "(Lcom/spotify/android/appremote/api/ContentApi$ContentType;)Lcom/spotify/protocol/client/CallResult;", "GetGetRecommendedContentItems_Lcom_spotify_android_appremote_api_ContentApi_ContentType_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult GetRecommendedContentItems (global::Com.Spotify.Android.Appremote.Api.ContentApiContentType type)
		{
			const string __id = "getRecommendedContentItems.(Lcom/spotify/android/appremote/api/ContentApi$ContentType;)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_playContentItem_Lcom_spotify_protocol_types_ListItem_;
#pragma warning disable 0169
		static Delegate GetPlayContentItem_Lcom_spotify_protocol_types_ListItem_Handler ()
		{
			if (cb_playContentItem_Lcom_spotify_protocol_types_ListItem_ == null)
				cb_playContentItem_Lcom_spotify_protocol_types_ListItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PlayContentItem_Lcom_spotify_protocol_types_ListItem_);
			return cb_playContentItem_Lcom_spotify_protocol_types_ListItem_;
		}

		static IntPtr n_PlayContentItem_Lcom_spotify_protocol_types_ListItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			global::Com.Spotify.Android.Appremote.Internal.ContentApiImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Internal.ContentApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.Types.ListItem item = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ListItem> (native_item, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PlayContentItem (item));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.internal']/class[@name='ContentApiImpl']/method[@name='playContentItem' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.types.ListItem']]"
		[Register ("playContentItem", "(Lcom/spotify/protocol/types/ListItem;)Lcom/spotify/protocol/client/CallResult;", "GetPlayContentItem_Lcom_spotify_protocol_types_ListItem_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Client.CallResult PlayContentItem (global::Com.Spotify.Protocol.Types.ListItem item)
		{
			const string __id = "playContentItem.(Lcom/spotify/protocol/types/ListItem;)Lcom/spotify/protocol/client/CallResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.CallResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
