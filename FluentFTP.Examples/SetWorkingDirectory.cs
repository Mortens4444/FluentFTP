﻿using System;
using System.Net;
using FluentFTP;
using System.IO;

namespace Examples {
	internal static class SetWorkingDirectoryExample {
		public static void SetWorkingDirectory() {
			using (var conn = new FtpClient()) {
				conn.Host = "localhost";
				conn.Credentials = new NetworkCredential("ftptest", "ftptest");
				conn.SetWorkingDirectory("/full/or/relative/path");
			}
		}
	}
}