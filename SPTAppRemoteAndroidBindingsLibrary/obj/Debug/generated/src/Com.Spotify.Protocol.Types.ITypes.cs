using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.RequestId']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/Types$RequestId", DoNotGenerateAcw=true)]
	public partial class TypesRequestId : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.RequestId']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Spotify.Protocol.Types.TypesRequestId None {
			get {
				const string __id = "NONE.Lcom/spotify/protocol/types/Types$RequestId;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/Types$RequestId", typeof (TypesRequestId));
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

		protected TypesRequestId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getRaw;
#pragma warning disable 0169
		static Delegate GetGetRawHandler ()
		{
			if (cb_getRaw == null)
				cb_getRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRaw);
			return cb_getRaw;
		}

		static int n_GetRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Types.TypesRequestId __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Raw;
		}
#pragma warning restore 0169

		public virtual unsafe int Raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.RequestId']/method[@name='getRaw' and count(parameter)=0]"
			[Register ("getRaw", "()I", "GetGetRawHandler")]
			get {
				const string __id = "getRaw.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.RequestId']/method[@name='from' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("from", "(I)Lcom/spotify/protocol/types/Types$RequestId;", "")]
		public static unsafe global::Com.Spotify.Protocol.Types.TypesRequestId From (int value)
		{
			const string __id = "from.(I)Lcom/spotify/protocol/types/Types$RequestId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesRequestId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.SubscriptionId']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/Types$SubscriptionId", DoNotGenerateAcw=true)]
	public partial class TypesSubscriptionId : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.SubscriptionId']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Spotify.Protocol.Types.TypesSubscriptionId None {
			get {
				const string __id = "NONE.Lcom/spotify/protocol/types/Types$SubscriptionId;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesSubscriptionId> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/Types$SubscriptionId", typeof (TypesSubscriptionId));
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

		protected TypesSubscriptionId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getRaw;
#pragma warning disable 0169
		static Delegate GetGetRawHandler ()
		{
			if (cb_getRaw == null)
				cb_getRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRaw);
			return cb_getRaw;
		}

		static int n_GetRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Protocol.Types.TypesSubscriptionId __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesSubscriptionId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Raw;
		}
#pragma warning restore 0169

		public virtual unsafe int Raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.SubscriptionId']/method[@name='getRaw' and count(parameter)=0]"
			[Register ("getRaw", "()I", "GetGetRawHandler")]
			get {
				const string __id = "getRaw.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Types.SubscriptionId']/method[@name='from' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("from", "(I)Lcom/spotify/protocol/types/Types$SubscriptionId;", "")]
		public static unsafe global::Com.Spotify.Protocol.Types.TypesSubscriptionId From (int value)
		{
			const string __id = "from.(I)Lcom/spotify/protocol/types/Types$SubscriptionId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.TypesSubscriptionId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.protocol.types']/interface[@name='Types']"
	[Register ("com/spotify/protocol/types/Types", "", "Com.Spotify.Protocol.Types.ITypesInvoker")]
	public partial interface ITypes : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/spotify/protocol/types/Types", DoNotGenerateAcw=true)]
	internal class ITypesInvoker : global::Java.Lang.Object, ITypes {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/protocol/types/Types", typeof (ITypesInvoker));

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

		public static ITypes GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypes> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.protocol.types.Types"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
