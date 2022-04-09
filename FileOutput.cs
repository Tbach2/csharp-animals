namespace csharp_animals
{
    public class FileOutput
    {
        StreamWriter output = null;
        private String fileName;

        public FileOutput(String fileName)
        {
            this.fileName = fileName;
            try
            {
                output = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileWrite(String line)
        {
            try
            {
                output.Write(line + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void fileClose()
        {
            if (output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}