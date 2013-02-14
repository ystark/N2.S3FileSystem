using System.Configuration;

namespace N2.S3FileSystem {
	using System.Web.Mvc;

	public static class HtmlHelperExtensions {

		public static string N2Image(this HtmlHelper helper, string virtualPath) {
			if (virtualPath.StartsWith("http")) return virtualPath;
			return string.IsNullOrWhiteSpace(virtualPath) ? null : string.Format("//s3.amazonaws.com/{0}/{1}", ConfigurationManager.AppSettings["AWSBucketName"], virtualPath.TrimStart('/'));
		}

	}
}
