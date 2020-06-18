using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class PictureElement : Element
    {
        private string path;

        public PictureElement(string path)
        {
            this.path = path;
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}