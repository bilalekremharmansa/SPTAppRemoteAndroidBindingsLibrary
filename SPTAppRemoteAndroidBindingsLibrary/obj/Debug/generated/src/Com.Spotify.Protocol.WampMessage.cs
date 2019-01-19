using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol']/class[@name='WampMessage']"
	[global::Android.Runtime.Register ("com/spotify/protocol/WampMessage", DoNotGenerateAcw=true)]
	public partial class WampMessage : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/WampMessage", typeof (WampMessage));
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

		protected WampMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol']/class[@name='WampMessage']/constructor[@name='WampMessage' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.mappers.JsonArray']]"
		[Register (".ctor", "(Lcom/spotify/protocol/mappers/JsonArray;)V", "")]
		public unsafe WampMessage (global::Com.Spotify.Protocol.Mappers.IJsonArray jsonArray)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/mappers/JsonArray;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonArray).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAction;
#pragma warning disable 0169
		static Delegate GetGetActionHandler ()
		{
			if (cb_getAction == null)
				cb_getAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAction);
			return cb_getAction;
		}

		static int n_GetAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.WampMessage __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.WampMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Action;
		}
#pragma warning restore 0169

		public virtual unsafe int Action {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/class[@name='WampMessage']/method[@name='getAction' and count(parameter)=0]"
			[Register ("getAction", "()I", "GetGetActionHandler")]
			get {
				const string __id = "getAction.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIntAt_I;
#pragma warning disable 0169
		static Delegate GetGetIntAt_IHandler ()
		{
			if (cb_getIntAt_I == null)
				cb_getIntAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIntAt_I);
			return cb_getIntAt_I;
		}

		static int n_GetIntAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Spotify.Protocol.WampMessage __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.WampMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIntAt (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/class[@name='WampMessage']/method[@name='getIntAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIntAt", "(I)I", "GetGetIntAt_IHandler")]
		public virtual unsafe int GetIntAt (int index)
		{
			const string __id = "getIntAt.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getObjectAt_I;
#pragma warning disable 0169
		static Delegate GetGetObjectAt_IHandler ()
		{
			if (cb_getObjectAt_I == null)
				cb_getObjectAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetObjectAt_I);
			return cb_getObjectAt_I;
		}

		static IntPtr n_GetObjectAt_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::Com.Spotify.Protocol.WampMessage __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.WampMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObjectAt (i));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/class[@name='WampMessage']/method[@name='getObjectAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObjectAt", "(I)Lcom/spotify/protocol/mappers/JsonObject;", "GetGetObjectAt_IHandler")]
		public virtual unsafe global::Com.Spotify.Protocol.Mappers.IJsonObject GetObjectAt (int i)
		{
			const string __id = "getObjectAt.(I)Lcom/spotify/protocol/mappers/JsonObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStringAt_I;
#pragma warning disable 0169
		static Delegate GetGetStringAt_IHandler ()
		{
			if (cb_getStringAt_I == null)
				cb_getStringAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetStringAt_I);
			return cb_getStringAt_I;
		}

		static IntPtr n_GetStringAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Spotify.Protocol.WampMessage __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.WampMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetStringAt (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol']/class[@name='WampMessage']/method[@name='getStringAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStringAt", "(I)Ljava/lang/String;", "GetGetStringAt_IHandler")]
		public virtual unsafe string GetStringAt (int index)
		{
			const string __id = "getStringAt.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
