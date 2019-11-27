namespace FileSearchCompression.FileServices
{
    public interface IFileService
    {
        /// <summary> Search file in target driver. </summary>
        /// <param name="targetDriver"> Target driver. </param>
        /// <param name="fileName"> Name of target file. </param>
        /// <returns> Result of search. </returns>
        bool SearchFile(string targetDriver, string fileName);

        /// <summary> Compression target file. </summary>
        /// <param name="fileName"> Name  of target dile. </param>
        void Compression(string fileName);
    }
}