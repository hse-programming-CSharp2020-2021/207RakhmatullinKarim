using System; // Для доступа к классу Console

using System.IO; // Для работы с файлами и директориями

namespace Directories
{

    class Program
    {

        public static void DirectoryOverview(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileSystemInfo[] SubDirecories = dir.GetFileSystemInfos();
            for(int i = 0; i < SubDirecories.Length; i++)
            {
                Console.WriteLine(SubDirecories[i].Name);
                Console.WriteLine(SubDirecories[i].Attributes);
                Console.WriteLine(SubDirecories[i].CreationTime);
                Console.WriteLine(SubDirecories[i].LastWriteTime);
                DirectoryOverview(SubDirecories[i].Name);
            }
        }

        static void Main(string[] args)
        {

            // Блок try-catch при работе с файлами обязателен!

            try
            {
                DirectoryOverview(@"../../../");

            }

            catch (Exception) {

                Console.WriteLine("error");

            }

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");

            Console.ReadLine();

            }

        }

    }
