using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class ArchiveElement : Element
    {
        public ArchiveElement(string path) : base(path)
        {
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}