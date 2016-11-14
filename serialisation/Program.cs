using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DirectoryInfo dossier = new DirectoryInfo("."); Console.WriteLine(dossier.FullName);
            //dossier = new DirectoryInfo(@"C:\Windows"); Console.WriteLine(dossier.FullName);
            //dossier = new DirectoryInfo(@"\Exemple"); Console.WriteLine(dossier.FullName); dossier.Create();
            //dossier = new DirectoryInfo(@".\Exemple"); Console.WriteLine(dossier.FullName);
            //Console.ReadLine();


            //   DirectoryInfo dossier = new DirectoryInfo(@"\Exemple");
            //Console.WriteLine("Chemin complet:" + dossier.FullName); Console.WriteLine("Nom:" + dossier.Name); Console.WriteLine("Dossier parent:" + dossier.Parent); Console.WriteLine("Date de création:" + dossier.CreationTime); Console.WriteLine("Attributs:" + dossier.Attributes); Console.WriteLine("Racine:" + dossier.Root);
            //Console.ReadLine();

            // DirectoryInfo dossier = new DirectoryInfo(@"C:\Windows\Web\Wallpaper\Scenes"); FileInfo[] fichiers = dossier.GetFiles();
            //Console.WriteLine("Ce dossier contient {0} fichiers:", fichiers.Length);
            //foreach (FileInfo f in fichiers) Console.WriteLine("\t" + f.Name);
            //Console.ReadLine();


            //DirectoryInfo dossier = new DirectoryInfo(@"C:\Windows\Web\Wallpaper"); FileInfo[] fichiers = dossier.GetFiles("*.jpg", SearchOption.AllDirectories);
            //Console.WriteLine("Ce dossier contient {0} fichiers de type JPG à travers tous les sous-dossiers:", fichiers.Length);
            //foreach (FileInfo f in fichiers) Console.WriteLine("\t" + f.Name);
            //Console.ReadLine();


            //  Console.WriteLine("Voici les unités logiques de votre machines:");
            //foreach (String u in Directory.GetLogicalDrives()) Console.WriteLine("\t" + u);
            //try { Directory.Delete(@"C:\Exemple", true); } catch (IOException e) { Console.WriteLine(e.Message); }
            //Console.ReadLine();

            //    Console.WriteLine("Voici les unités logiques de votre machines:");
            // foreach (DriveInfo di in DriveInfo.GetDrives())
            //{
            // Console.WriteLine("\nNom: " + di.Name);
            //Console.WriteLine("Type: " + di.DriveType);
            //if (di.IsReady) // si l'unité est "montée" { Console.WriteLine("Espace disponible: " + di.AvailableFreeSpace); Console.WriteLine("Espace total: " + di.TotalSize); Console.WriteLine("Format: " + di.DriveFormat); Console.WriteLine("Étiquette: " + di.VolumeLabel); }
            //Console.ReadLine();
            //   }

            using (StreamWriter writer = File.CreateText(@"C:\Exemple\memos.txt"))
            {
                writer.WriteLine("Terminer le travail pratique #2 en INF1035");
                writer.WriteLine("Demander à mon frère un coup de main pour déménager"); writer.WriteLine("Appeler pour mes assurances");
                writer.Write(writer.NewLine);
                for (int i = 0; i < 20; i += 2) writer.Write(i + " ");
            }
            Console.ReadLine();
        }
}
}

