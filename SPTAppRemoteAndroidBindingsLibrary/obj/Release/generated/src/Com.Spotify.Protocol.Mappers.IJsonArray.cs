using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Mappers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonArray']"
	[Register ("com/spotify/protocol/mappers/JsonArray", "", "Com.Spotify.Protocol.Mappers.IJsonArrayInvoker")]
	public partial interface IJsonArray : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonArray']/method[@name='getIntAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIntAt", "(I)I", "GetGetIntAt_IHandler:Com.Spotify.Protocol.Mappers.IJsonArrayInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		int GetIntAt (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonArray']/method[@name='getObjectAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObjectAt", "(I)Lcom/spotify/protocol/mappers/JsonObject;", "GetGetObjectAt_IHandler:Com.Spotify.Protocol.Mappers.IJsonArrayInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		global::Com.Spotify.Protocol.Mappers.IJsonObject GetObjectAt (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.mappers']/interface[@name='JsonArray']/method[@name='getStringAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStringAt", "(I)Ljava/lang/String;", "GetGetStringAt_IHandler:Com.Spotify.Protocol.Mappers.IJsonArrayInvoker, SPTAppRemoteAndroidBindingsLibrary")]
		string GetStringAt (int p0);

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/mappers/JsonArray", DoNotGenerateAcw=true)]
	internal class IJsonArrayInvoker : global::Java.Lang.Object, IJsonArray {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/mappers/JsonArray", typeof (IJsonArrayInvoker));

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

		public static IJsonArray GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonArray> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.mappers.JsonArray"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonArrayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIntAt_I;
#pragma warning disable 0169
		static Delegate GetGetIntAt_IHandler ()
		{
			if (cb_getIntAt_I == null)
				cb_getIntAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIntAt_I);
			return cb_getIntAt_I;
		}

		static int n_GetIntAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonArray __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIntAt (p0);
		}
#pragma warning restore 0169

		IntPtr id_getIntAt_I;
		public unsafe int GetIntAt (int p0)
		{
			if (id_getIntAt_I == IntPtr.Zero)
				id_getIntAt_I = JNIEnv.GetMethodID (class_ref, "getIntAt", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIntAt_I, __args);
		}

		static Delegate cb_getObjectAt_I;
#pragma warning disable 0169
		static Delegate GetGetObjectAt_IHandler ()
		{
			if (cb_getObjectAt_I == null)
				cb_getObjectAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetObjectAt_I);
			return cb_getObjectAt_I;
		}

		static IntPtr n_GetObjectAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonArray __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObjectAt (p0));
		}
#pragma warning restore 0169

		IntPtr id_getObjectAt_I;
		public unsafe global::Com.Spotify.Protocol.Mappers.IJsonObject GetObjectAt (int p0)
		{
			if (id_getObjectAt_I == IntPtr.Zero)
				id_getObjectAt_I = JNIEnv.GetMethodID (class_ref, "getObjectAt", "(I)Lcom/spotify/protocol/mappers/JsonObject;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectAt_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getStringAt_I;
#pragma warning disable 0169
		static Delegate GetGetStringAt_IHandler ()
		{
			if (cb_getStringAt_I == null)
				cb_getStringAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetStringAt_I);
			return cb_getStringAt_I;
		}

		static IntPtr n_GetStringAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Spotify.Protocol.Mappers.IJsonArray __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetStringAt (p0));
		}
#pragma warning restore 0169

		IntPtr id_getStringAt_I;
		public unsafe string GetStringAt (int p0)
		{
			if (id_getStringAt_I == IntPtr.Zero)
				id_getStringAt_I = JNIEnv.GetMethodID (class_ref, "getStringAt", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStringAt_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
