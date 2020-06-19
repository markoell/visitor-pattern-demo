using System;
using VisitorPatternDemo.Model;
using VisitorPatternDemo.Visitors;

namespace visitor_pattern_demo
{
    class Program
    {
        public static void Main(string[] args)
        {

            var root = new DirectoryElement(@".\testdata");

            CountElementByType(typeof(ArchiveElement), root);
            CountElementByType(typeof(PictureElement), root);
            CountElementByType(typeof(DocumentElement), root);
            CountElementByType(typeof(DirectoryElement), root);
            
            Console.WriteLine();
            ListFilesFromStructure(root);

            Console.WriteLine();
            var fileRemover = new EmptyElementRemoveVisitor();
            root.Accept(fileRemover);

            Console.WriteLine();
            ListFilesFromStructure(root);
        }

        private static void CountElementByType(Type elementType, Element element)
        {
            var counterVisitor = new DocumentCountVisitor(elementType);
            element.Accept(counterVisitor);

            Console.WriteLine($"{counterVisitor.DocumentCount} {counterVisitor.DocumentType.Name} counted in structure.");
        }

        private static void ListFilesFromStructure(DirectoryElement root)
        {
            var fileListVisitor = new FileListGeneratorVisitor();
            root.Accept(fileListVisitor);

            Console.WriteLine();
            Console.WriteLine($"{fileListVisitor.FileNames.Count} Files found in Structure:");
            foreach (var file in fileListVisitor.FileNames)
            {
                Console.WriteLine(file);
            }
        }
    }
}
