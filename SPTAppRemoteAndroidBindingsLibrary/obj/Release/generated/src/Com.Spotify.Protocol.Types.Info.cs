using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Protocol.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']"
	[global::Android.Runtime.Register ("com/spotify/protocol/types/Info", DoNotGenerateAcw=true)]
	public partial class Info : global::Java.Lang.Object, global::Com.Spotify.Protocol.Types.IItem {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='category']"
		[Register ("category")]
		public string Category {
			get {
				const string __id = "category.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "category.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='defaultImageHeight']"
		[Register ("defaultImageHeight")]
		public int DefaultImageHeight {
			get {
				const string __id = "defaultImageHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "defaultImageHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='defaultImageWidth']"
		[Register ("defaultImageWidth")]
		public int DefaultImageWidth {
			get {
				const string __id = "defaultImageWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "defaultImageWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='defaultThumbnailImageHeight']"
		[Register ("defaultThumbnailImageHeight")]
		public int DefaultThumbnailImageHeight {
			get {
				const string __id = "defaultThumbnailImageHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "defaultThumbnailImageHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='defaultThumbnailImageWidth']"
		[Register ("defaultThumbnailImageWidth")]
		public int DefaultThumbnailImageWidth {
			get {
				const string __id = "defaultThumbnailImageWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "defaultThumbnailImageWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				const string __id = "id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='imageType']"
		[Register ("imageType")]
		public string ImageType {
			get {
				const string __id = "imageType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "imageType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='model']"
		[Register ("model")]
		public string Model {
			get {
				const string __id = "model.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "model.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='name']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='protocolVersion']"
		[Register ("protocolVersion")]
		public int ProtocolVersion {
			get {
				const string __id = "protocolVersion.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "protocolVersion.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='requiredFeatures']"
		[Register ("requiredFeatures")]
		public global::System.Collections.IList RequiredFeatures {
			get {
				const string __id = "requiredFeatures.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "requiredFeatures.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/field[@name='version']"
		[Register ("version")]
		public string Version {
			get {
				const string __id = "version.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "version.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/protocol/types/Info", typeof (Info));
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

		protected Info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.protocol.types']/class[@name='Info']/constructor[@name='Info' and count(parameter)=12 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register (".ctor", "(ILjava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIII)V", "")]
		public unsafe Info (int protocolVersion, global::System.Collections.Generic.IList<string> requiredFeatures, string id, string name, string model, string category, string version, string imageType, int defaultImageWidth, int defaultImageHeight, int defaultThumbnailImageWidth, int defaultThumbnailImageHeight)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_requiredFeatures = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (requiredFeatures);
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_model = JNIEnv.NewString (model);
			IntPtr native_category = JNIEnv.NewString (category);
			IntPtr native_version = JNIEnv.NewString (version);
			IntPtr native_imageType = JNIEnv.NewString (imageType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue (protocolVersion);
				__args [1] = new JniArgumentValue (native_requiredFeatures);
				__args [2] = new JniArgumentValue (native_id);
				__args [3] = new JniArgumentValue (native_name);
				__args [4] = new JniArgumentValue (native_model);
				__args [5] = new JniArgumentValue (native_category);
				__args [6] = new JniArgumentValue (native_version);
				__args [7] = new JniArgumentValue (native_imageType);
				__args [8] = new JniArgumentValue (defaultImageWidth);
				__args [9] = new JniArgumentValue (defaultImageHeight);
				__args [10] = new JniArgumentValue (defaultThumbnailImageWidth);
				__args [11] = new JniArgumentValue (defaultThumbnailImageHeight);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requiredFeatures);
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_model);
				JNIEnv.DeleteLocalRef (native_category);
				JNIEnv.DeleteLocalRef (native_version);
				JNIEnv.DeleteLocalRef (native_imageType);
			}
		}

	}
}
