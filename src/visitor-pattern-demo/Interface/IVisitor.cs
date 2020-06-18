using VisitorPatternDemo.Model;

namespace VisitorPatternDemo.Interface
{
    public interface IVisitor
    {
        void Visit(Element element);
        void Visit(ArchiveElement element);
        void Visit(DirectoryElement element);
        void Visit(DocumentElement element);
        void Visit(PictureElement element);
    }
}