using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Mappers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonMapper']"
	[Register ("com/spotify/protocol/mappers/JsonMapper", "", "Com.Spotify.Protocol.Mappers.IJsonMapperInvoker")]
	public partial interface IJsonMapper : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonMapper']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "GetToJson_Ljava_lang_Object_Handler:Com.Spotify.Protocol.Mappers.IJsonMapperInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		string ToJson (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonMapper']/method[@name='toJsonArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toJsonArray", "(Ljava/lang/String;)Lcom/spotify/protocol/mappers/JsonArray;", "GetToJsonArray_Ljava_lang_String_Handler:Com.Spotify.Protocol.Mappers.IJsonMapperInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Mappers.IJsonArray ToJsonArray (string p0);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/mappers/JsonMapper", DoNotGenerateAcw=true)]
	internal class IJsonMapperInvoker : global::Java.Lang.Object, IJsonMapper {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/mappers/JsonMapper", typeof (IJsonMapperInvoker));

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

		public static IJsonMapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonMapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.mappers.JsonMapper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonMapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_toJson_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToJson_Ljava_lang_Object_Handler ()
		{
			if (cb_toJson_Ljava_lang_Object_ == null)
				cb_toJson_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJson_Ljava_lang_Object_);
			return cb_toJson_Ljava_lang_Object_;
		}

		static IntPtr n_ToJson_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonMapper __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToJson (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toJson_Ljava_lang_Object_;
		public unsafe string ToJson (global::Java.Lang.Object p0)
		{
			if (id_toJson_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toJsonArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToJsonArray_Ljava_lang_String_Handler ()
		{
			if (cb_toJsonArray_Ljava_lang_String_ == null)
				cb_toJsonArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJsonArray_Ljava_lang_String_);
			return cb_toJsonArray_Ljava_lang_String_;
		}

		static IntPtr n_ToJsonArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonMapper __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToJsonArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toJsonArray_Ljava_lang_String_;
		public unsafe global::Com.Spotify.Protocol.Mappers.IJsonArray ToJsonArray (string p0)
		{
			if (id_toJsonArray_Ljava_lang_String_ == IntPtr.Zero)
				id_toJsonArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toJsonArray", "(Ljava/lang/String;)Lcom/spotify/protocol/mappers/JsonArray;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Spotify.Protocol.Mappers.IJsonArray __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
