
using System;
using System.Collections.Generic;
using VisitorPatternDemo.Interface;
using VisitorPatternDemo.Model;

namespace VisitorPatternDemo.Visitors
{
    public class FileListGeneratorVisitor : IVisitor
    {
        public List<string> FileNames { get; private set; } = new List<string>();
        public Type DocumentType { get; set; }

        public FileListGeneratorVisitor()
        {
        } 
        public void Visit(Element element)
        {
            //Do Nothing
        }

        public void Visit(ArchiveElement element)
        {
            FileNames.Add(element.FullName);
        }

        public void Visit(DirectoryElement element)
        {
            //Do Nothing
        }

        public void Visit(DocumentElement element)
        {
            FileNames.Add(element.FullName);
        }

        public void Visit(PictureElement element)
        {
            FileNames.Add(element.FullName);
        }
    }
}