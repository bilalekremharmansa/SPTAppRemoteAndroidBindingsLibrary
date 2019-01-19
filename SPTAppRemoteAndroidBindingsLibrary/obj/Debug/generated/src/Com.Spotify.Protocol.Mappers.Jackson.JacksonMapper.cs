using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Mappers.Jackson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.mappers.jackson']/class[@name='JacksonMapper']"
	[global::Android.Runtime.Register ("com/spotify/protocol/mappers/jackson/JacksonMapper", DoNotGenerateAcw=true)]
	public partial class JacksonMapper : global::Java.Lang.Object, global::Com.Spotify.Protocol.Mappers.IJsonMapper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/mappers/jackson/JacksonMapper", typeof (JacksonMapper));
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

		protected JacksonMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers.jackson']/class[@name='JacksonMapper']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/spotify/protocol/mappers/jackson/JacksonMapper;", "")]
		public static unsafe global::Com.Spotify.Protocol.Mappers.Jackson.JacksonMapper Create ()
		{
			const string __id = "create.()Lcom/spotify/protocol/mappers/jackson/JacksonMapper;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.Jackson.JacksonMapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toJson_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToJson_Ljava_lang_Object_Handler ()
		{
			if (cb_toJson_Ljava_lang_Object_ == null)
				cb_toJson_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJson_Ljava_lang_Object_);
			return cb_toJson_Ljava_lang_Object_;
		}

		static IntPtr n_ToJson_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Spotify.Protocol.Mappers.Jackson.JacksonMapper __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.Jackson.JacksonMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToJson (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers.jackson']/class[@name='JacksonMapper']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "GetToJson_Ljava_lang_Object_Handler")]
		public virtual unsafe string ToJson (global::Java.Lang.Object value)
		{
			const string __id = "toJson.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toJsonArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToJsonArray_Ljava_lang_String_Handler ()
		{
			if (cb_toJsonArray_Ljava_lang_String_ == null)
				cb_toJsonArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJsonArray_Ljava_lang_String_);
			return cb_toJsonArray_Ljava_lang_String_;
		}

		static IntPtr n_ToJsonArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_json)
		{
			global::Com.Spotify.Protocol.Mappers.Jackson.JacksonMapper __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.Jackson.JacksonMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string json = JNIEnv.GetString (native_json, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToJsonArray (json));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers.jackson']/class[@name='JacksonMapper']/method[@name='toJsonArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toJsonArray", "(Ljava/lang/String;)Lcom/spotify/protocol/mappers/JsonArray;", "GetToJsonArray_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Spotify.Protocol.Mappers.IJsonArray ToJsonArray (string json)
		{
			const string __id = "toJsonArray.(Ljava/lang/String;)Lcom/spotify/protocol/mappers/JsonArray;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

	}
}
