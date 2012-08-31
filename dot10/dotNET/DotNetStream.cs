﻿using System;
using System.IO;
using dot10.IO;

namespace dot10.dotNET {
	/// <summary>
	/// .NET metadata stream
	/// </summary>
	public class DotNetStream : IDisposable {
		/// <summary>
		/// Reader that can access the whole stream
		/// </summary>
		protected IImageStream imageStream;
		StreamHeader streamHeader;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="imageStream">Stream data</param>
		/// <param name="streamHeader">The stream header</param>
		public DotNetStream(IImageStream imageStream, StreamHeader streamHeader) {
			this.imageStream = imageStream;
			this.streamHeader = streamHeader;
		}

		/// <inheritdoc/>
		public override string ToString() {
			return string.Format("{0:X8} {1}", imageStream.Length, streamHeader.Name);
		}

		/// <inheritdoc/>
		public virtual void Dispose() {
			if (imageStream != null) {
				imageStream.Dispose();
				imageStream = null;
			}
		}
	}
}