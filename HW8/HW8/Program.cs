// See https://aka.ms/new-console-template for more information
using HW8;


public class MainClass
{
    internal static void Main(string[] args)
    {
        Folder basefolder = new Folder();

        string path = "folder1/folder1/folder1/abc.txt1";
        string path2 = "folder1/folder1/folder1/abc.txt2123123123sd";



        basefolder.AddSubFolder(path);
        basefolder.AddSubFolder(path2);
        Console.WriteLine(basefolder.SubFolders.First().SubFolders.First().SubFolders.First().Document.Name);
       
    }
}