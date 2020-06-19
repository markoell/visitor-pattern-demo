using System.IO;
using System.Linq;
using VisitorPatternDemo.Interface;
using VisitorPatternDemo.Model;

namespace visitor_pattern_demo
{
    internal class EmptyElementRemoveVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            //Do Nothing
        }

        public void Visit(ArchiveElement element)
        {
            CheckAndDeleteElement(element);
        }

        public void Visit(DirectoryElement element)
        {
            element.Children = element.Children.Where(item => Directory.Exists(item.FullName) || File.Exists(item.FullName)).ToArray();
            
            if (!element.Children.Any() && !Directory.EnumerateFileSystemEntries(element.FullName).Any())
            {
                System.Console.WriteLine($"Delete Directory {element.FullName}");
                Directory.Delete(element.FullName);
            }
        }

        public void Visit(DocumentElement element)
        {
            CheckAndDeleteElement(element);

        }

        public void Visit(PictureElement element)
        {
            CheckAndDeleteElement(element);
        }

        private static void CheckAndDeleteElement(Element element)
        {
            if (File.Exists(element.FullName) && new FileInfo(element.FullName).Length == 0)
            {
                System.Console.WriteLine($"Delete Element {element.FullName}");
                File.Delete(element.FullName);
            }
        }
    }
}