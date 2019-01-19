using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampCallsOrchestrator']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/WampCallsOrchestrator", DoNotGenerateAcw=true)]
	public partial class WampCallsOrchestrator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampCallsOrchestrator.CallRecord']"
		[global::Android.Runtime.Register ("com/spotify/protocol/client/WampCallsOrchestrator$CallRecord", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class CallRecord : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/WampCallsOrchestrator$CallRecord", typeof (CallRecord));
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

			protected CallRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_deliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_;
#pragma warning disable 0169
			static Delegate GetDeliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_Handler ()
			{
				if (cb_deliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_ == null)
					cb_deliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_);
				return cb_deliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_;
			}

			static void n_DeliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
			{
				global::Com.Spotify.Protocol.Client.WampCallsOrchestrator.CallRecord __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.WampCallsOrchestrator.CallRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Protocol.Mappers.IJsonObject payload = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_payload, JniHandleOwnership.DoNotTransfer);
				__this.DeliverResultWithPayload (payload);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampCallsOrchestrator.CallRecord']/method[@name='deliverResultWithPayload' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.mappers.JsonObject']]"
			[Register ("deliverResultWithPayload", "(Lcom/spotify/protocol/mappers/JsonObject;)V", "GetDeliverResultWithPayload_Lcom_spotify_protocol_mappers_JsonObject_Handler")]
			public virtual unsafe void DeliverResultWithPayload (global::Com.Spotify.Protocol.Mappers.IJsonObject payload)
			{
				const string __id = "deliverResultWithPayload.(Lcom/spotify/protocol/mappers/JsonObject;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((payload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) payload).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampCallsOrchestrator.SubscriptionRecord']"
		[global::Android.Runtime.Register ("com/spotify/protocol/client/WampCallsOrchestrator$SubscriptionRecord", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class SubscriptionRecord : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/WampCallsOrchestrator$SubscriptionRecord", typeof (SubscriptionRecord));
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

			protected SubscriptionRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_deliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_;
#pragma warning disable 0169
			static Delegate GetDeliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_Handler ()
			{
				if (cb_deliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_ == null)
					cb_deliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_);
				return cb_deliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_;
			}

			static void n_DeliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
			{
				global::Com.Spotify.Protocol.Client.WampCallsOrchestrator.SubscriptionRecord __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.WampCallsOrchestrator.SubscriptionRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Protocol.Mappers.IJsonObject payload = (global::Com.Spotify.Protocol.Mappers.IJsonObject)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Mappers.IJsonObject> (native_payload, JniHandleOwnership.DoNotTransfer);
				__this.DeliverEventWithPayload (payload);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampCallsOrchestrator.SubscriptionRecord']/method[@name='deliverEventWithPayload' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.mappers.JsonObject']]"
			[Register ("deliverEventWithPayload", "(Lcom/spotify/protocol/mappers/JsonObject;)V", "GetDeliverEventWithPayload_Lcom_spotify_protocol_mappers_JsonObject_Handler")]
			public virtual unsafe void DeliverEventWithPayload (global::Com.Spotify.Protocol.Mappers.IJsonObject payload)
			{
				const string __id = "deliverEventWithPayload.(Lcom/spotify/protocol/mappers/JsonObject;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((payload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) payload).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/WampCallsOrchestrator", typeof (WampCallsOrchestrator));
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

		protected WampCallsOrchestrator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampCallsOrchestrator']/constructor[@name='WampCallsOrchestrator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WampCallsOrchestrator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
