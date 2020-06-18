using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class ArchiveElement : Element
    {
        private string path;

        public ArchiveElement(string path)
        {
            this.path = path;
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}