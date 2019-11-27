using System.IO;
using System.IO.Compression;

namespace FileSearchCompression.FileServices
{
    internal class FileService : IFileService
    {
        /// <summary> Current file. </summary>
        private string _file;


        /// <inheritdoc />
        public bool SearchFile(string targetDriver, string fileName)
        {
            var driverInfo = new DirectoryInfo(targetDriver);

            if (!driverInfo.Exists)
            {
                return false;
            }

            var fileInfo = driverInfo.GetFiles(fileName);

            if (fileInfo.Length == 0)
            {
                var directoryInfo = driverInfo.GetDirectories();

                if (directoryInfo.Length == 0)
                {
                    return false;
                }

                foreach (var item in directoryInfo)
                {
                    if (item.Attributes.Equals(FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory))
                    {
                        continue;
                    }

                    if (SearchFile(item.FullName, fileName))
                    {
                        return true;
                    }
                }

                return false;
            }

            _file = fileInfo[0].FullName;
            return true;
        }

        /// <inheritdoc />
        public void Compression(string fileName)
        {
            var source = File.OpenRead(_file);
            var destination = File.Create($@"{fileName}.zip");

            var compressor = new GZipStream(destination, CompressionMode.Compress);

            var theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }

            compressor.Close();
        }
    }
}