using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampRouterImpl']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/WampRouterImpl", DoNotGenerateAcw=true)]
	public partial class WampRouterImpl : global::Java.Lang.Object, global::Com.Spotify.Protocol.IWampClientRouter {


		public static class InterfaceConsts {

			// The following are fields from: com.spotify.protocol.WampClient.RequestType

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='ABORT']"
			[Register ("ABORT")]
			public const int Abort = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='CALL']"
			[Register ("CALL")]
			public const int Call = (int) 48;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='CANCEL']"
			[Register ("CANCEL")]
			public const int Cancel = (int) 49;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const int Error = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='EVENT']"
			[Register ("EVENT")]
			public const int Event = (int) 36;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='GOODBYE']"
			[Register ("GOODBYE")]
			public const int Goodbye = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='HELLO']"
			[Register ("HELLO")]
			public const int Hello = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='RESULT']"
			[Register ("RESULT")]
			public const int Result = (int) 50;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='SUBSCRIBE']"
			[Register ("SUBSCRIBE")]
			public const int Subscribe = (int) 32;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='SUBSCRIBED']"
			[Register ("SUBSCRIBED")]
			public const int Subscribed = (int) 33;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='UNSUBSCRIBE']"
			[Register ("UNSUBSCRIBE")]
			public const int Unsubscribe = (int) 34;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='UNSUBSCRIBED']"
			[Register ("UNSUBSCRIBED")]
			public const int Unsubscribed = (int) 35;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='WampClient.RequestType']/field[@name='WELCOME']"
			[Register ("WELCOME")]
			public const int Welcome = (int) 2;
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/WampRouterImpl", typeof (WampRouterImpl));
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

		protected WampRouterImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampRouterImpl']/constructor[@name='WampRouterImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WampRouterImpl ()
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

		static Delegate cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
#pragma warning disable 0169
		static Delegate GetAddReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler ()
		{
			if (cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == null)
				cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddReceiver_Lcom_spotify_protocol_WampClient_Receiver_);
			return cb_addReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		}

		static void n_AddReceiver_Lcom_spotify_protocol_WampClient_Receiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			global::Com.Spotify.Protocol.Client.WampRouterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.WampRouterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.IWampClientReceiver receiver = (global::Com.Spotify.Protocol.IWampClientReceiver)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			__this.AddReceiver (receiver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampRouterImpl']/method[@name='addReceiver' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampClient.Receiver']]"
		[Register ("addReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V", "GetAddReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler")]
		public virtual unsafe void AddReceiver (global::Com.Spotify.Protocol.IWampClientReceiver receiver)
		{
			const string __id = "addReceiver.(Lcom/spotify/protocol/WampClient$Receiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
#pragma warning disable 0169
		static Delegate GetRemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler ()
		{
			if (cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_ == null)
				cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_);
			return cb_removeReceiver_Lcom_spotify_protocol_WampClient_Receiver_;
		}

		static void n_RemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			global::Com.Spotify.Protocol.Client.WampRouterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.WampRouterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.IWampClientReceiver receiver = (global::Com.Spotify.Protocol.IWampClientReceiver)global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.IWampClientReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			__this.RemoveReceiver (receiver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampRouterImpl']/method[@name='removeReceiver' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampClient.Receiver']]"
		[Register ("removeReceiver", "(Lcom/spotify/protocol/WampClient$Receiver;)V", "GetRemoveReceiver_Lcom_spotify_protocol_WampClient_Receiver_Handler")]
		public virtual unsafe void RemoveReceiver (global::Com.Spotify.Protocol.IWampClientReceiver receiver)
		{
			const string __id = "removeReceiver.(Lcom/spotify/protocol/WampClient$Receiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_route_Lcom_spotify_protocol_WampMessage_;
#pragma warning disable 0169
		static Delegate GetRoute_Lcom_spotify_protocol_WampMessage_Handler ()
		{
			if (cb_route_Lcom_spotify_protocol_WampMessage_ == null)
				cb_route_Lcom_spotify_protocol_WampMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Route_Lcom_spotify_protocol_WampMessage_);
			return cb_route_Lcom_spotify_protocol_WampMessage_;
		}

		static bool n_Route_Lcom_spotify_protocol_WampMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Com.Spotify.Protocol.Client.WampRouterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Client.WampRouterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Protocol.WampMessage message = global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.WampMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Route (message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='WampRouterImpl']/method[@name='route' and count(parameter)=1 and parameter[1][@type='com.spotify.protocol.WampMessage']]"
		[Register ("route", "(Lcom/spotify/protocol/WampMessage;)Z", "GetRoute_Lcom_spotify_protocol_WampMessage_Handler")]
		public virtual unsafe bool Route (global::Com.Spotify.Protocol.WampMessage message)
		{
			const string __id = "route.(Lcom/spotify/protocol/WampMessage;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
