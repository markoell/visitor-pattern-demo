using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class DocumentElement : Element
    {
        private string path;

        public DocumentElement(string path)
        {
            this.path = path;
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}