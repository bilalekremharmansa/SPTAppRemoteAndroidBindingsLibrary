using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/spotify/android/appremote/api",
						"com/spotify/protocol/types",
					},
					new Converter<string, Type>[]{
						lookup_com_spotify_android_appremote_api_package,
						lookup_com_spotify_protocol_types_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_spotify_android_appremote_api_mappings;
		static Type lookup_com_spotify_android_appremote_api_package (string klass)
		{
			if (package_com_spotify_android_appremote_api_mappings == null) {
				package_com_spotify_android_appremote_api_mappings = new string[]{
					"com/spotify/android/appremote/api/ContentApi$ContentType:Com.Spotify.Android.Appremote.Api.ContentApiContentType",
					"com/spotify/android/appremote/api/PlayerApi$StreamType:Com.Spotify.Android.Appremote.Api.PlayerApiStreamType",
				};
			}

			return Lookup (package_com_spotify_android_appremote_api_mappings, klass);
		}

		static string[] package_com_spotify_protocol_types_mappings;
		static Type lookup_com_spotify_protocol_types_package (string klass)
		{
			if (package_com_spotify_protocol_types_mappings == null) {
				package_com_spotify_protocol_types_mappings = new string[]{
					"com/spotify/protocol/types/Types$RequestId:Com.Spotify.Protocol.Types.TypesRequestId",
					"com/spotify/protocol/types/Types$SubscriptionId:Com.Spotify.Protocol.Types.TypesSubscriptionId",
				};
			}

			return Lookup (package_com_spotify_protocol_types_mappings, klass);
		}
	}
}
