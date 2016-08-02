using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FileSystemReceiverUtil
    {
        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }

        //could easily implement a Factory here
        public static IFileSystemReceiver getUnderlyingFileSystem()
        {
            string osName = GetOSFriendlyName();
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            string osName1 = osInfo.VersionString;
            if (osName.Contains("Windows"))
                return new WindowsFileSystemReceiver();
            return new UnixFileSystemReceiver();

        }
    }
}
