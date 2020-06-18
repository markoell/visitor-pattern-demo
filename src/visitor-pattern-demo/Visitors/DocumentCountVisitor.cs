
using System;
using VisitorPatternDemo.Interface;
using VisitorPatternDemo.Model;

namespace VisitorPatternDemo.Visitors
{
    public class DocumentCountVisitor : IVisitor
    {
        public int DocumentCount { get; private set; } = 0;
        public Type DocumentType { get; set; }

        public DocumentCountVisitor(Type typeToCount)
        {
            DocumentType = typeToCount;
        } 
        public void Visit(Element element)
        {
            if(DocumentType == typeof(Element)){
                DocumentCount++;
            }
        }

        public void Visit(ArchiveElement archiveElement)
        {
            if(DocumentType == typeof(ArchiveElement)){
                DocumentCount++;
            }
        }

        public void Visit(DirectoryElement element)
        {
            if(DocumentType == typeof(DirectoryElement)){
                DocumentCount++;
            }
        }

        public void Visit(DocumentElement element)
        {
            if(DocumentType == typeof(DocumentElement)){
                DocumentCount++;
            }
        }

        public void Visit(PictureElement element)
        {
            if(DocumentType == typeof(PictureElement)){
                DocumentCount++;
            }
        }
    }
}