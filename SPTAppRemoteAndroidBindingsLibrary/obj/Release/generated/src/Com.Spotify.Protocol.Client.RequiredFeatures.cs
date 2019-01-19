using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RequiredFeatures']"
	[global::Android.Runtime.Register ("com/spotify/protocol/client/RequiredFeatures", DoNotGenerateAcw=true)]
	public partial class RequiredFeatures : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RequiredFeatures']/field[@name='FEATURES']"
		[Register ("FEATURES")]
		public static global::System.Collections.IList Features {
			get {
				const string __id = "FEATURES.Ljava/util/List;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RequiredFeatures']/field[@name='FEATURES_V1']"
		[Register ("FEATURES_V1")]
		public const string FeaturesV1 = (string) "com.spotify.features.v1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RequiredFeatures']/field[@name='FEATURES_V2']"
		[Register ("FEATURES_V2")]
		public const string FeaturesV2 = (string) "com.spotify.features.v2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RequiredFeatures']/field[@name='FEATURES_V3']"
		[Register ("FEATURES_V3")]
		public const string FeaturesV3 = (string) "com.spotify.features.v3";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.client']/class[@name='RequiredFeatures']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::System.Collections.IList None {
			get {
				const string __id = "NONE.Ljava/util/List;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/client/RequiredFeatures", typeof (RequiredFeatures));
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

		protected RequiredFeatures (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
