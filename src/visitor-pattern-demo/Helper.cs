using System.Collections.Generic;
using VisitorPatternDemo.Model;

namespace VisitorPatternDemo
{
 public static class Helper 
{
    public static IEnumerable<Element> BuildElementTree(string path)
    {
        var results = new List<Element>();

        if (!string.IsNullOrEmpty(path))
        {
            foreach(var folder in System.IO.Directory.GetDirectories(path))
            {
                //string folderName = new System.IO.DirectoryInfo(folder);
                var element = new DirectoryElement(folder);
                results.Add(element);
            }

            foreach(var file in System.IO.Directory.GetFiles(path))
            {
                //var fileName = System.IO.Path.GetFileName(file);
                var element = GetLeafElement(file);
                results.Add(element);
            }
        }
            return results;
        }

        private static Element GetLeafElement(string path)
        {
            switch(System.IO.Path.GetExtension(path))
            {
                case ".zip":
                    return new ArchiveElement(path);
                case ".jpg":
                    return new PictureElement(path);
                default:
                    return new DocumentElement(path);
            } 
        }
}   
}