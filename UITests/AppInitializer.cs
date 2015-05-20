using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace testcloudciexample.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			if (platform == Platform.Android) {
				return ConfigureApp.Android.ApkFile("../../../Droid/bin/Release/com.xamarin.ci_example.apk").StartApp ();
			}

			return ConfigureApp.iOS.StartApp ();
		}
	}
}

