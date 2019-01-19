using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol']"
	[global::Android.Runtime.Register ("com/spotify/protocol/AppProtocol", DoNotGenerateAcw=true)]
	public partial class AppProtocol : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Com.Spotify.Protocol.Types.Empty Empty {
			get {
				const string __id = "EMPTY.Lcom/spotify/protocol/types/Empty;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Empty> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']"
		[global::Android.Runtime.Register ("com/spotify/protocol/AppProtocol$CallUri", DoNotGenerateAcw=true)]
		public partial class CallUri : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='CAPABILITIES']"
			[Register ("CAPABILITIES")]
			public const string Capabilities = (string) "com.spotify.get_capabilities";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='CONNECT_SWITCH_TO_LOCAL_DEVICE']"
			[Register ("CONNECT_SWITCH_TO_LOCAL_DEVICE")]
			public const string ConnectSwitchToLocalDevice = (string) "com.spotify.connect_switch_to_local_device";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='GET_CHILDREN_OF_ITEM']"
			[Register ("GET_CHILDREN_OF_ITEM")]
			public const string GetChildrenOfItem = (string) "com.spotify.get_children_of_item";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='GET_IMAGE']"
			[Register ("GET_IMAGE")]
			public const string GetImage = (string) "com.spotify.get_image";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='GET_PLAYER_STATE']"
			[Register ("GET_PLAYER_STATE")]
			public const string GetPlayerState = (string) "com.spotify.get_player_state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='GET_RECOMMENDED_ROOT_ITEMS']"
			[Register ("GET_RECOMMENDED_ROOT_ITEMS")]
			public const string GetRecommendedRootItems = (string) "com.spotify.get_recommended_root_items";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='GET_SAVED']"
			[Register ("GET_SAVED")]
			public const string GetSaved = (string) "com.spotify.get_saved";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='GET_THUMBNAIL_IMAGE']"
			[Register ("GET_THUMBNAIL_IMAGE")]
			public const string GetThumbnailImage = (string) "com.spotify.get_thumbnail_image";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='PLAY_ITEM']"
			[Register ("PLAY_ITEM")]
			public const string PlayItem = (string) "com.spotify.play_item";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='PLAY_QUEUE']"
			[Register ("PLAY_QUEUE")]
			public const string PlayQueue = (string) "com.spotify.queue_spotify_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='PLAY_URI']"
			[Register ("PLAY_URI")]
			public const string PlayUri = (string) "com.spotify.play_spotify_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='PLAY_URI_WITH_OPTION_EXTRAS']"
			[Register ("PLAY_URI_WITH_OPTION_EXTRAS")]
			public const string PlayUriWithOptionExtras = (string) "com.spotify.play_spotify_uri_option_extras";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SET_PLAYBACK_POSITION']"
			[Register ("SET_PLAYBACK_POSITION")]
			public const string SetPlaybackPosition = (string) "com.spotify.set_playback_position";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SET_PLAYBACK_SPEED']"
			[Register ("SET_PLAYBACK_SPEED")]
			public const string SetPlaybackSpeed = (string) "com.spotify.set_playback_speed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SET_REPEAT']"
			[Register ("SET_REPEAT")]
			public const string SetRepeat = (string) "com.spotify.set_repeat";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SET_SAVED']"
			[Register ("SET_SAVED")]
			public const string SetSaved = (string) "com.spotify.set_saved";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SET_SHUFFLE']"
			[Register ("SET_SHUFFLE")]
			public const string SetShuffle = (string) "com.spotify.set_shuffle";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SKIP_NEXT']"
			[Register ("SKIP_NEXT")]
			public const string SkipNext = (string) "com.spotify.skip_next";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='SKIP_PREVIOUS']"
			[Register ("SKIP_PREVIOUS")]
			public const string SkipPrevious = (string) "com.spotify.skip_previous";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='TOGGLE_REPEAT']"
			[Register ("TOGGLE_REPEAT")]
			public const string ToggleRepeat = (string) "com.spotify.toggle_repeat";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.CallUri']/field[@name='TOGGLE_SHUFFLE']"
			[Register ("TOGGLE_SHUFFLE")]
			public const string ToggleShuffle = (string) "com.spotify.toggle_shuffle";
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/AppProtocol$CallUri", typeof (CallUri));
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

			protected CallUri (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[Register ("com/spotify/protocol/AppProtocol$ErrorUri", DoNotGenerateAcw=true)]
		public abstract class ErrorUri : Java.Lang.Object {

			internal ErrorUri ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_AUTHENTICATION_FAILED']"
			[Register ("ERROR_AUTHENTICATION_FAILED")]
			public const string ErrorAuthenticationFailed = (string) "com.spotify.error.client_authentication_failed";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_FEATURE_VERSION_MISMATCH']"
			[Register ("ERROR_FEATURE_VERSION_MISMATCH")]
			public const string ErrorFeatureVersionMismatch = (string) "com.spotify.error.unsupported_version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_INVALID_ARGUMENT']"
			[Register ("ERROR_INVALID_ARGUMENT")]
			public const string ErrorInvalidArgument = (string) "wamp.error.invalid_argument";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_INVALID_URI']"
			[Register ("ERROR_INVALID_URI")]
			public const string ErrorInvalidUri = (string) "wamp.error.invalid_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_NOT_LOGGED_IN']"
			[Register ("ERROR_NOT_LOGGED_IN")]
			public const string ErrorNotLoggedIn = (string) "com.spotify.error.not_logged_in";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_OFFLINE_MODE_ACTIVE']"
			[Register ("ERROR_OFFLINE_MODE_ACTIVE")]
			public const string ErrorOfflineModeActive = (string) "com.spotify.error.offline_mode_active";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='ERROR_USER_NOT_AUTHORIZED']"
			[Register ("ERROR_USER_NOT_AUTHORIZED")]
			public const string ErrorUserNotAuthorized = (string) "com.spotify.error.user_not_authorized";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='WAMP_ERROR']"
			[Register ("WAMP_ERROR")]
			public const string WampError = (string) "wamp.error";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='WAMP_ERROR_NOT_AUTHORIZED']"
			[Register ("WAMP_ERROR_NOT_AUTHORIZED")]
			public const string WampErrorNotAuthorized = (string) "wamp.error.not_authorized";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/interface[@name='AppProtocol.ErrorUri']/field[@name='WAMP_ERROR_SYSTEM_SHUTDOWN']"
			[Register ("WAMP_ERROR_SYSTEM_SHUTDOWN")]
			public const string WampErrorSystemShutdown = (string) "wamp.error.system_shutdown";
		}

		[Register ("com/spotify/protocol/AppProtocol$ErrorUri", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ErrorUri' type. This type will be removed in a future release.")]
		public abstract class ErrorUriConsts : ErrorUri {

			private ErrorUriConsts ()
			{
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.ItemId']"
		[global::Android.Runtime.Register ("com/spotify/protocol/AppProtocol$ItemId", DoNotGenerateAcw=true)]
		public partial class ItemId : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.ItemId']/field[@name='RECENTLY_PLAYED']"
			[Register ("RECENTLY_PLAYED")]
			public const string RecentlyPlayed = (string) "com.spotify.recently-played";
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/AppProtocol$ItemId", typeof (ItemId));
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

			protected ItemId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.Topic']"
		[global::Android.Runtime.Register ("com/spotify/protocol/AppProtocol$Topic", DoNotGenerateAcw=true)]
		public partial class Topic : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.Topic']/field[@name='CAPABILITIES']"
			[Register ("CAPABILITIES")]
			public const string Capabilities = (string) "com.spotify.capabilities";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.Topic']/field[@name='PLAYER_CONTEXT']"
			[Register ("PLAYER_CONTEXT")]
			public const string PlayerContext = (string) "com.spotify.current_context";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.Topic']/field[@name='PLAYER_STATE']"
			[Register ("PLAYER_STATE")]
			public const string PlayerState = (string) "com.spotify.player_state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.Topic']/field[@name='STATUS']"
			[Register ("STATUS")]
			public const string Status = (string) "com.spotify.status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol']/class[@name='AppProtocol.Topic']/field[@name='TEMPO_DETECTION_STATE']"
			[Register ("TEMPO_DETECTION_STATE")]
			public const string TempoDetectionState = (string) "com.spotify.running_tempo_detection_state";
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/AppProtocol$Topic", typeof (Topic));
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

			protected Topic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/AppProtocol", typeof (AppProtocol));
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

		protected AppProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
