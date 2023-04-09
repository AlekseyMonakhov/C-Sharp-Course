using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{

    public class Folder
    {
        public string Name { get; set; }
       
        public List<Folder> SubFolders = new List<Folder>();

        public Document Document { get; set; } = new Document();
        public void AddSubFolder(string path)
        {
            // якщо шлях пустий, то повертаємо назад
            if (string.IsNullOrEmpty(path)) return;

            // перевірка, чи є ще підпапки
            // та чи потрібна рекурсія
            if (!path.Contains('/', StringComparison.CurrentCulture))
            {
                if (!IsFolderExists(path))
                {
                    SubFolders.Add(new Folder() { Name = path });
                }
               
                Document =  new Document(path);
               
                return;
            }
            

            // забираємо перше ім'я до слешу
            string folderName = path.Substring(0, path.IndexOf("/"));

            Folder folder;

            if (IsFolderExists(folderName))
            {
                // якщо така папка вже є, то забираємо її
                folder = SubFolders.Where(x => x.Name == folderName).First();
            }
            else
            {
                // інакше створюємо нову та додаємо до підпапок
                folder = new Folder() { Name = folderName };
                SubFolders.Add(folder);
            }
            
           
            

            // викликаємо рекурсію для наступних папок із обраної
            folder.AddSubFolder(path.Substring(path.IndexOf("/") + 1, path.Length - path.IndexOf("/") - 1));
           
        }
       

        // перевірка, чи є вже така папка 
        private bool IsFolderExists(string folderName) =>
            SubFolders.Where(x => x.Name == folderName).Any();
    }

   
}
