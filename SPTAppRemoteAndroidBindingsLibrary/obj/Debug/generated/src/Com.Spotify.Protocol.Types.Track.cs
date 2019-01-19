using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/Track", DoNotGenerateAcw=true)]
	public partial class Track : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='album']"
		[Register ("album")]
		public global::Com.Spotify.Protocol.Types.Album Album {
			get {
				const string __id = "album.Lcom/spotify/protocol/types/Album;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Album> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "album.Lcom/spotify/protocol/types/Album;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='artist']"
		[Register ("artist")]
		public global::Com.Spotify.Protocol.Types.Artist Artist {
			get {
				const string __id = "artist.Lcom/spotify/protocol/types/Artist;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.Artist> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "artist.Lcom/spotify/protocol/types/Artist;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='artists']"
		[Register ("artists")]
		public global::System.Collections.IList Artists {
			get {
				const string __id = "artists.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "artists.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='duration']"
		[Register ("duration")]
		public long Duration {
			get {
				const string __id = "duration.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "duration.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='imageUri']"
		[Register ("imageUri")]
		public global::Com.Spotify.Protocol.Types.ImageUri ImageUri {
			get {
				const string __id = "imageUri.Lcom/spotify/protocol/types/ImageUri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Protocol.Types.ImageUri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "imageUri.Lcom/spotify/protocol/types/ImageUri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/field[@name='uri']"
		[Register ("uri")]
		public string Uri {
			get {
				const string __id = "uri.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/Track", typeof (Track));
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

		protected Track (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Track']/constructor[@name='Track' and count(parameter)=7 and parameter[1][@type='com.spotify.protocol.types.Artist'] and parameter[2][@type='java.util.List&lt;com.spotify.protocol.types.Artist&gt;'] and parameter[3][@type='com.spotify.protocol.types.Album'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.spotify.protocol.types.ImageUri']]"
		[Register (".ctor", "(Lcom/spotify/protocol/types/Artist;Ljava/util/List;Lcom/spotify/protocol/types/Album;JLjava/lang/String;Ljava/lang/String;Lcom/spotify/protocol/types/ImageUri;)V", "")]
		public unsafe Track (global::Com.Spotify.Protocol.Types.Artist artist, global::System.Collections.Generic.IList<global::Com.Spotify.Protocol.Types.Artist> artists, global::Com.Spotify.Protocol.Types.Album album, long duration, string name, string uri, global::Com.Spotify.Protocol.Types.ImageUri imageUri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/spotify/protocol/types/Artist;Ljava/util/List;Lcom/spotify/protocol/types/Album;JLjava/lang/String;Ljava/lang/String;Lcom/spotify/protocol/types/ImageUri;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_artists = global::Android.Runtime.JavaList<global::Com.Spotify.Protocol.Types.Artist>.ToLocalJniHandle (artists);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((artist == null) ? IntPtr.Zero : ((global::Java.Lang.Object) artist).Handle);
				__args [1] = new JniArgumentValue (native_artists);
				__args [2] = new JniArgumentValue ((album == null) ? IntPtr.Zero : ((global::Java.Lang.Object) album).Handle);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue (native_name);
				__args [5] = new JniArgumentValue (native_uri);
				__args [6] = new JniArgumentValue ((imageUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageUri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_artists);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

	}
}
