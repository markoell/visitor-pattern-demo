using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class DocumentElement : Element
    {
        public DocumentElement(string path) : base(path)
        {
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}