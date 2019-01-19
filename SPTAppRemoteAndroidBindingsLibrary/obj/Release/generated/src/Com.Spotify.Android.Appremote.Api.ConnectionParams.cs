using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Android.Appremote.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']"
	[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ConnectionParams", DoNotGenerateAcw=true)]
	public partial class ConnectionParams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.AuthMethod']"
		[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ConnectionParams$AuthMethod", DoNotGenerateAcw=true)]
		public sealed partial class AuthMethod : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.AuthMethod']/field[@name='APP_ID']"
			[Register ("APP_ID")]
			public static global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod AppId {
				get {
					const string __id = "APP_ID.Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.AuthMethod']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod None {
				get {
					const string __id = "NONE.Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/ConnectionParams$AuthMethod", typeof (AuthMethod));
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

			internal AuthMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.AuthMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;", "")]
			public static unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.AuthMethod']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;", "")]
			public static unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod[] Values ()
			{
				const string __id = "values.()[Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']"
		[global::Android.Runtime.Register ("com/spotify/android/appremote/api/ConnectionParams$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/ConnectionParams$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/constructor[@name='ConnectionParams.Builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder (string clientId)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientId = JNIEnv.NewString (clientId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_clientId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientId);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/android/appremote/api/ConnectionParams;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams Build ()
			{
				const string __id = "build.()Lcom/spotify/android/appremote/api/ConnectionParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_;
#pragma warning disable 0169
			static Delegate GetSetAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_Handler ()
			{
				if (cb_setAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_ == null)
					cb_setAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_);
				return cb_setAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_;
			}

			static IntPtr n_SetAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authMethod)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod authMethod = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod> (native_authMethod, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthMethod (authMethod));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='setAuthMethod' and count(parameter)=1 and parameter[1][@type='com.spotify.android.appremote.api.ConnectionParams.AuthMethod']]"
			[Register ("setAuthMethod", "(Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetSetAuthMethod_Lcom_spotify_android_appremote_api_ConnectionParams_AuthMethod_Handler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder SetAuthMethod (global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod authMethod)
			{
				const string __id = "setAuthMethod.(Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((authMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authMethod).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_;
#pragma warning disable 0169
			static Delegate GetSetJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_Handler ()
			{
				if (cb_setJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_ == null)
					cb_setJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_);
				return cb_setJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_;
			}

			static IntPtr n_SetJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Protocol.Mappers.IJsonMapper mapper = (global::Com.Spotify.Protocol.Mappers.IJsonMapper)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonMapper> (native_mapper, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetJsonMapper (mapper));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='setJsonMapper' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.mappers.JsonMapper']]"
			[Register ("setJsonMapper", "(Lcom/spotify/protocol/mappers/JsonMapper;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetSetJsonMapper_Lcom_spotify_protocol_mappers_JsonMapper_Handler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder SetJsonMapper (global::Com.Spotify.Protocol.Mappers.IJsonMapper mapper)
			{
				const string __id = "setJsonMapper.(Lcom/spotify/protocol/mappers/JsonMapper;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPreferredImageSize_I;
#pragma warning disable 0169
			static Delegate GetSetPreferredImageSize_IHandler ()
			{
				if (cb_setPreferredImageSize_I == null)
					cb_setPreferredImageSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPreferredImageSize_I);
				return cb_setPreferredImageSize_I;
			}

			static IntPtr n_SetPreferredImageSize_I (IntPtr jnienv, IntPtr native__this, int size)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPreferredImageSize (size));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='setPreferredImageSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreferredImageSize", "(I)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetSetPreferredImageSize_IHandler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder SetPreferredImageSize (int size)
			{
				const string __id = "setPreferredImageSize.(I)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPreferredThumbnailImageSize_I;
#pragma warning disable 0169
			static Delegate GetSetPreferredThumbnailImageSize_IHandler ()
			{
				if (cb_setPreferredThumbnailImageSize_I == null)
					cb_setPreferredThumbnailImageSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPreferredThumbnailImageSize_I);
				return cb_setPreferredThumbnailImageSize_I;
			}

			static IntPtr n_SetPreferredThumbnailImageSize_I (IntPtr jnienv, IntPtr native__this, int size)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPreferredThumbnailImageSize (size));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='setPreferredThumbnailImageSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreferredThumbnailImageSize", "(I)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetSetPreferredThumbnailImageSize_IHandler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder SetPreferredThumbnailImageSize (int size)
			{
				const string __id = "setPreferredThumbnailImageSize.(I)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetRedirectUri_Ljava_lang_String_Handler ()
			{
				if (cb_setRedirectUri_Ljava_lang_String_ == null)
					cb_setRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRedirectUri_Ljava_lang_String_);
				return cb_setRedirectUri_Ljava_lang_String_;
			}

			static IntPtr n_SetRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirectUri)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string redirectUri = JNIEnv.GetString (native_redirectUri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRedirectUri (redirectUri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUri", "(Ljava/lang/String;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetSetRedirectUri_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder SetRedirectUri (string redirectUri)
			{
				const string __id = "setRedirectUri.(Ljava/lang/String;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_redirectUri);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_redirectUri);
				}
			}

			static Delegate cb_setRequiredFeatures_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetRequiredFeatures_Ljava_util_List_Handler ()
			{
				if (cb_setRequiredFeatures_Ljava_util_List_ == null)
					cb_setRequiredFeatures_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequiredFeatures_Ljava_util_List_);
				return cb_setRequiredFeatures_Ljava_util_List_;
			}

			static IntPtr n_SetRequiredFeatures_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requiredFeatures)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var requiredFeatures = global::Android.Runtime.JavaList<string>.FromJniHandle (native_requiredFeatures, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequiredFeatures (requiredFeatures));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='setRequiredFeatures' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setRequiredFeatures", "(Ljava/util/List;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetSetRequiredFeatures_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder SetRequiredFeatures (global::System.Collections.Generic.IList<string> requiredFeatures)
			{
				const string __id = "setRequiredFeatures.(Ljava/util/List;)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				IntPtr native_requiredFeatures = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (requiredFeatures);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_requiredFeatures);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_requiredFeatures);
				}
			}

			static Delegate cb_showAuthView_Z;
#pragma warning disable 0169
			static Delegate GetShowAuthView_ZHandler ()
			{
				if (cb_showAuthView_Z == null)
					cb_showAuthView_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowAuthView_Z);
				return cb_showAuthView_Z;
			}

			static IntPtr n_ShowAuthView_Z (IntPtr jnienv, IntPtr native__this, bool showAuthView)
			{
				global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ShowAuthView (showAuthView));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams.Builder']/method[@name='showAuthView' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("showAuthView", "(Z)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;", "GetShowAuthView_ZHandler")]
			public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder ShowAuthView (bool showAuthView)
			{
				const string __id = "showAuthView.(Z)Lcom/spotify/android/appremote/api/ConnectionParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (showAuthView);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/android/appremote/api/ConnectionParams", typeof (ConnectionParams));
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

		protected ConnectionParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageSize;
#pragma warning disable 0169
		static Delegate GetGetImageSizeHandler ()
		{
			if (cb_getImageSize == null)
				cb_getImageSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageSize);
			return cb_getImageSize;
		}

		static int n_GetImageSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageSize;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getImageSize' and count(parameter)=0]"
			[Register ("getImageSize", "()I", "GetGetImageSizeHandler")]
			get {
				const string __id = "getImageSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getJsonMapper;
#pragma warning disable 0169
		static Delegate GetGetJsonMapperHandler ()
		{
			if (cb_getJsonMapper == null)
				cb_getJsonMapper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonMapper);
			return cb_getJsonMapper;
		}

		static IntPtr n_GetJsonMapper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsonMapper);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Spotify.Protocol.Mappers.IJsonMapper JsonMapper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getJsonMapper' and count(parameter)=0]"
			[Register ("getJsonMapper", "()Lcom/spotify/protocol/mappers/JsonMapper;", "GetGetJsonMapperHandler")]
			get {
				const string __id = "getJsonMapper.()Lcom/spotify/protocol/mappers/JsonMapper;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonMapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				const string __id = "getRedirectUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredFeatures;
#pragma warning disable 0169
		static Delegate GetGetRequiredFeaturesHandler ()
		{
			if (cb_getRequiredFeatures == null)
				cb_getRequiredFeatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequiredFeatures);
			return cb_getRequiredFeatures;
		}

		static IntPtr n_GetRequiredFeatures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RequiredFeatures);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> RequiredFeatures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getRequiredFeatures' and count(parameter)=0]"
			[Register ("getRequiredFeatures", "()Ljava/util/List;", "GetGetRequiredFeaturesHandler")]
			get {
				const string __id = "getRequiredFeatures.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShowAuthView;
#pragma warning disable 0169
		static Delegate GetGetShowAuthViewHandler ()
		{
			if (cb_getShowAuthView == null)
				cb_getShowAuthView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShowAuthView);
			return cb_getShowAuthView;
		}

		static bool n_GetShowAuthView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowAuthView;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowAuthView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getShowAuthView' and count(parameter)=0]"
			[Register ("getShowAuthView", "()Z", "GetGetShowAuthViewHandler")]
			get {
				const string __id = "getShowAuthView.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getThumbnailImageSize;
#pragma warning disable 0169
		static Delegate GetGetThumbnailImageSizeHandler ()
		{
			if (cb_getThumbnailImageSize == null)
				cb_getThumbnailImageSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThumbnailImageSize);
			return cb_getThumbnailImageSize;
		}

		static int n_GetThumbnailImageSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThumbnailImageSize;
		}
#pragma warning restore 0169

		public virtual unsafe int ThumbnailImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getThumbnailImageSize' and count(parameter)=0]"
			[Register ("getThumbnailImageSize", "()I", "GetGetThumbnailImageSizeHandler")]
			get {
				const string __id = "getThumbnailImageSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAuthMethod;
#pragma warning disable 0169
		static Delegate GetGetAuthMethodHandler ()
		{
			if (cb_getAuthMethod == null)
				cb_getAuthMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthMethod);
			return cb_getAuthMethod;
		}

		static IntPtr n_GetAuthMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Android.Appremote.Api.ConnectionParams __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAuthMethod ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.android.appremote.api']/class[@name='ConnectionParams']/method[@name='getAuthMethod' and count(parameter)=0]"
		[Register ("getAuthMethod", "()Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;", "GetGetAuthMethodHandler")]
		public virtual unsafe global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod GetAuthMethod ()
		{
			const string __id = "getAuthMethod.()Lcom/spotify/android/appremote/api/ConnectionParams$AuthMethod;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Android.Appremote.Api.ConnectionParams.AuthMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
