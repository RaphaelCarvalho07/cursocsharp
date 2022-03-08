using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);

        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("Esse é");
                    Console.WriteLine("o nosso");
                    Console.WriteLine("primeiro");
                    Console.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("");
                Console.WriteLine("É possível");
                Console.WriteLine("adicionar");
                Console.WriteLine("mais texto!");
            }
        }
    }
}
