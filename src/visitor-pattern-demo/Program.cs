using System;
using System.Collections.Generic;
using VisitorPatternDemo;
using VisitorPatternDemo.Model;
using VisitorPatternDemo.Visitors;

namespace visitor_pattern_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var root = new DirectoryElement(".\testdata");

            var visitor = new DocumentCountVisitor(typeof(PictureElement));
            root.Accept(visitor);

            Console.WriteLine($"Hello {visitor.DocumentType.Name} counted: {visitor.DocumentCount}");

            var visitor2 = new FileListGeneratorVisitor();
            root.Accept(visitor2);

            foreach(var file in visitor2.FileNames){
                Console.WriteLine(file);
            }
        }
    }
}
