using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class PictureElement : Element
    {

        public PictureElement(string path) : base(path)
        {
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}