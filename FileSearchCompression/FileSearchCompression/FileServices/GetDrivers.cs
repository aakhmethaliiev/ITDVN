using System.Collections;
using System.IO;

namespace FileSearchCompression.FileServices
{
    public static class GetDrivers
    {
        /// <summary> Get list of drivers in local machine. </summary>
        /// <returns> List of drivers. </returns>
        public static ArrayList GetListOfDrivers()
        {
            var driveInfo = DriveInfo.GetDrives();
            var listOfDrivers = new ArrayList();
            foreach (var info in driveInfo)
            {
                if (info.DriveType == DriveType.CDRom)
                {
                    continue;
                }

                listOfDrivers.Add(info.Name);
            }

            return listOfDrivers;
        }
    }
}