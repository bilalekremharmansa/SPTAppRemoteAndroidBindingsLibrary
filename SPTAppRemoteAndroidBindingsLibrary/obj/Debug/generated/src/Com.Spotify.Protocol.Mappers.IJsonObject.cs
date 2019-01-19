using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Mappers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonObject']"
	[Register ("com/spotify/protocol/mappers/JsonObject", "", "Com.Spotify.Protocol.Mappers.IJsonObjectInvoker")]
	public partial interface IJsonObject : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonObject']/method[@name='getAs' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAs", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetAs_Ljava_lang_Class_Handler:Com.Spotify.Protocol.Mappers.IJsonObjectInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object GetAs (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonObject']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Ljava/lang/String;", "GetToJsonHandler:Com.Spotify.Protocol.Mappers.IJsonObjectInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		string ToJson ();

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/mappers/JsonObject", DoNotGenerateAcw=true)]
	internal class IJsonObjectInvoker : global::Java.Lang.Object, IJsonObject {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/mappers/JsonObject", typeof (IJsonObjectInvoker));

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

		public static IJsonObject GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonObject> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.mappers.JsonObject"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAs_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAs_Ljava_lang_Class_Handler ()
		{
			if (cb_getAs_Ljava_lang_Class_ == null)
				cb_getAs_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAs_Ljava_lang_Class_);
			return cb_getAs_Ljava_lang_Class_;
		}

		static IntPtr n_GetAs_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonObject __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAs (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAs_Ljava_lang_Class_;
		public unsafe global::Java.Lang.Object GetAs (global::Java.Lang.Class p0)
		{
			if (id_getAs_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAs_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getAs", "(Ljava/lang/Class;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAs_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonObject __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		IntPtr id_toJson;
		public unsafe string ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
		}

	}

}
