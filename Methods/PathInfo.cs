namespace Methods
{

    public class PathInfo
    {
        public string DirectoryName;
        public string FileName;
        public string Extension;

        public PathInfo(string directoryName, string fileName, string extension)
        {
            DirectoryName = directoryName;
            FileName = fileName;
            Extension = extension;
        }
        public void Deconstruct(
          out string directoryName, out string fileName, out string extension)
        {
            directoryName = DirectoryName;
            fileName = FileName;
            extension = Extension;
        }

        public int A(int i)
        {
            return m(i);

            int m(int j)
            {
                return j + 1;

            }
        }
        
    }



}