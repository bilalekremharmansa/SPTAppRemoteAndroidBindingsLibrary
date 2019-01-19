using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/ConnectionDetails", DoNotGenerateAcw=true)]
	public partial class ConnectionDetails : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']"
		[global::Android.Runtime.Register ("com/spotify/protocol/client/ConnectionDetails$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/ConnectionDetails$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/constructor[@name='ConnectionDetails.Builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder (string id)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			static Delegate cb_getModel;
#pragma warning disable 0169
			static Delegate GetGetModelHandler ()
			{
				if (cb_getModel == null)
					cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
				return cb_getModel;
			}

			static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Model);
			}
#pragma warning restore 0169

			public virtual unsafe string Model {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='getModel' and count(parameter)=0]"
				[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
				get {
					const string __id = "getModel.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
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
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/protocol/client/ConnectionDetails;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails Build ()
			{
				const string __id = "build.()Lcom/spotify/protocol/client/ConnectionDetails;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAuthId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAuthId_Ljava_lang_String_Handler ()
			{
				if (cb_setAuthId_Ljava_lang_String_ == null)
					cb_setAuthId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAuthId_Ljava_lang_String_);
				return cb_setAuthId_Ljava_lang_String_;
			}

			static IntPtr n_SetAuthId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authId)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string authId = JNIEnv.GetString (native_authId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthId (authId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setAuthId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthId", "(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetAuthId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetAuthId (string authId)
			{
				const string __id = "setAuthId.(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_authId = JNIEnv.NewString (authId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_authId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_authId);
				}
			}

			static Delegate cb_setAuthMethods_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAuthMethods_arrayLjava_lang_String_Handler ()
			{
				if (cb_setAuthMethods_arrayLjava_lang_String_ == null)
					cb_setAuthMethods_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAuthMethods_arrayLjava_lang_String_);
				return cb_setAuthMethods_arrayLjava_lang_String_;
			}

			static IntPtr n_SetAuthMethods_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authMethods)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] authMethods = (string[]) JNIEnv.GetArray (native_authMethods, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthMethods (authMethods));
				if (authMethods != null)
					JNIEnv.CopyArray (authMethods, native_authMethods);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setAuthMethods' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("setAuthMethods", "([Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetAuthMethods_arrayLjava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetAuthMethods (string[] authMethods)
			{
				const string __id = "setAuthMethods.([Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_authMethods = JNIEnv.NewArray (authMethods);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_authMethods);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (authMethods != null) {
						JNIEnv.CopyArray (native_authMethods, authMethods);
						JNIEnv.DeleteLocalRef (native_authMethods);
					}
				}
			}

			static Delegate cb_setCategory_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCategory_Ljava_lang_String_Handler ()
			{
				if (cb_setCategory_Ljava_lang_String_ == null)
					cb_setCategory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCategory_Ljava_lang_String_);
				return cb_setCategory_Ljava_lang_String_;
			}

			static IntPtr n_SetCategory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_category)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string category = JNIEnv.GetString (native_category, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCategory (category));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCategory", "(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetCategory_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetCategory (string category)
			{
				const string __id = "setCategory.(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_category = JNIEnv.NewString (category);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_category);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_category);
				}
			}

			static Delegate cb_setExtras_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetExtras_Ljava_util_Map_Handler ()
			{
				if (cb_setExtras_Ljava_util_Map_ == null)
					cb_setExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExtras_Ljava_util_Map_);
				return cb_setExtras_Ljava_util_Map_;
			}

			static IntPtr n_SetExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var extras = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_extras, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExtras (extras));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setExtras", "(Ljava/util/Map;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetExtras_Ljava_util_Map_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetExtras (global::System.Collections.Generic.IDictionary<string, string> extras)
			{
				const string __id = "setExtras.(Ljava/util/Map;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_extras = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (extras);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_extras);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_extras);
				}
			}

			static Delegate cb_setImageSize_I;
#pragma warning disable 0169
			static Delegate GetSetImageSize_IHandler ()
			{
				if (cb_setImageSize_I == null)
					cb_setImageSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetImageSize_I);
				return cb_setImageSize_I;
			}

			static IntPtr n_SetImageSize_I (IntPtr jnienv, IntPtr native__this, int size)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetImageSize (size));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setImageSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setImageSize", "(I)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetImageSize_IHandler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetImageSize (int size)
			{
				const string __id = "setImageSize.(I)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setModel_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetModel_Ljava_lang_String_Handler ()
			{
				if (cb_setModel_Ljava_lang_String_ == null)
					cb_setModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetModel_Ljava_lang_String_);
				return cb_setModel_Ljava_lang_String_;
			}

			static IntPtr n_SetModel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_model)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string model = JNIEnv.GetString (native_model, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetModel (model));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setModel", "(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetModel_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetModel (string model)
			{
				const string __id = "setModel.(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_model = JNIEnv.NewString (model);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_model);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_model);
				}
			}

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (name));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetName (string name)
			{
				const string __id = "setName.(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
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
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var requiredFeatures = global::Android.Runtime.JavaList<string>.FromJniHandle (native_requiredFeatures, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequiredFeatures (requiredFeatures));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setRequiredFeatures' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setRequiredFeatures", "(Ljava/util/List;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetRequiredFeatures_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetRequiredFeatures (global::System.Collections.Generic.IList<string> requiredFeatures)
			{
				const string __id = "setRequiredFeatures.(Ljava/util/List;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_requiredFeatures = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (requiredFeatures);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_requiredFeatures);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_requiredFeatures);
				}
			}

			static Delegate cb_setThumbnailSize_I;
#pragma warning disable 0169
			static Delegate GetSetThumbnailSize_IHandler ()
			{
				if (cb_setThumbnailSize_I == null)
					cb_setThumbnailSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetThumbnailSize_I);
				return cb_setThumbnailSize_I;
			}

			static IntPtr n_SetThumbnailSize_I (IntPtr jnienv, IntPtr native__this, int size)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetThumbnailSize (size));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setThumbnailSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setThumbnailSize", "(I)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetThumbnailSize_IHandler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetThumbnailSize (int size)
			{
				const string __id = "setThumbnailSize.(I)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetVersion_Ljava_lang_String_Handler ()
			{
				if (cb_setVersion_Ljava_lang_String_ == null)
					cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
				return cb_setVersion_Ljava_lang_String_;
			}

			static IntPtr n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
			{
				global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string version = JNIEnv.GetString (native_version, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVersion (version));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails.Builder']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;", "GetSetVersion_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder SetVersion (string version)
			{
				const string __id = "setVersion.(Ljava/lang/String;)Lcom/spotify/protocol/client/ConnectionDetails$Builder;";
				IntPtr native_version = JNIEnv.NewString (version);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_version);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_version);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/ConnectionDetails", typeof (ConnectionDetails));
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

		protected ConnectionDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAuthId;
#pragma warning disable 0169
		static Delegate GetGetAuthIdHandler ()
		{
			if (cb_getAuthId == null)
				cb_getAuthId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthId);
			return cb_getAuthId;
		}

		static IntPtr n_GetAuthId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthId);
		}
#pragma warning restore 0169

		public virtual unsafe string AuthId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getAuthId' and count(parameter)=0]"
			[Register ("getAuthId", "()Ljava/lang/String;", "GetGetAuthIdHandler")]
			get {
				const string __id = "getAuthId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCategory;
#pragma warning disable 0169
		static Delegate GetGetCategoryHandler ()
		{
			if (cb_getCategory == null)
				cb_getCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategory);
			return cb_getCategory;
		}

		static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Category);
		}
#pragma warning restore 0169

		public virtual unsafe string Category {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getCategory' and count(parameter)=0]"
			[Register ("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
			get {
				const string __id = "getCategory.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtras;
#pragma warning disable 0169
		static Delegate GetGetExtrasHandler ()
		{
			if (cb_getExtras == null)
				cb_getExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtras);
			return cb_getExtras;
		}

		static IntPtr n_GetExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Extras);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/util/Map;", "GetGetExtrasHandler")]
			get {
				const string __id = "getExtras.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageHeight;
#pragma warning disable 0169
		static Delegate GetGetImageHeightHandler ()
		{
			if (cb_getImageHeight == null)
				cb_getImageHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageHeight);
			return cb_getImageHeight;
		}

		static int n_GetImageHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getImageHeight' and count(parameter)=0]"
			[Register ("getImageHeight", "()I", "GetGetImageHeightHandler")]
			get {
				const string __id = "getImageHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageWidth;
#pragma warning disable 0169
		static Delegate GetGetImageWidthHandler ()
		{
			if (cb_getImageWidth == null)
				cb_getImageWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageWidth);
			return cb_getImageWidth;
		}

		static int n_GetImageWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getImageWidth' and count(parameter)=0]"
			[Register ("getImageWidth", "()I", "GetGetImageWidthHandler")]
			get {
				const string __id = "getImageWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model);
		}
#pragma warning restore 0169

		public virtual unsafe string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get {
				const string __id = "getModel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
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
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RequiredFeatures);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> RequiredFeatures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getRequiredFeatures' and count(parameter)=0]"
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

		static Delegate cb_getThumbnailImageHeight;
#pragma warning disable 0169
		static Delegate GetGetThumbnailImageHeightHandler ()
		{
			if (cb_getThumbnailImageHeight == null)
				cb_getThumbnailImageHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThumbnailImageHeight);
			return cb_getThumbnailImageHeight;
		}

		static int n_GetThumbnailImageHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThumbnailImageHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int ThumbnailImageHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getThumbnailImageHeight' and count(parameter)=0]"
			[Register ("getThumbnailImageHeight", "()I", "GetGetThumbnailImageHeightHandler")]
			get {
				const string __id = "getThumbnailImageHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getThumbnailImageWidth;
#pragma warning disable 0169
		static Delegate GetGetThumbnailImageWidthHandler ()
		{
			if (cb_getThumbnailImageWidth == null)
				cb_getThumbnailImageWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThumbnailImageWidth);
			return cb_getThumbnailImageWidth;
		}

		static int n_GetThumbnailImageWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThumbnailImageWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int ThumbnailImageWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getThumbnailImageWidth' and count(parameter)=0]"
			[Register ("getThumbnailImageWidth", "()I", "GetGetThumbnailImageWidthHandler")]
			get {
				const string __id = "getThumbnailImageWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthMethods;
#pragma warning disable 0169
		static Delegate GetGetAuthMethodsHandler ()
		{
			if (cb_getAuthMethods == null)
				cb_getAuthMethods = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthMethods);
			return cb_getAuthMethods;
		}

		static IntPtr n_GetAuthMethods (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Client.ConnectionDetails __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.ConnectionDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAuthMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='ConnectionDetails']/method[@name='getAuthMethods' and count(parameter)=0]"
		[Register ("getAuthMethods", "()[Ljava/lang/String;", "GetGetAuthMethodsHandler")]
		public virtual unsafe string[] GetAuthMethods ()
		{
			const string __id = "getAuthMethods.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
