using System.Linq;
using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class DirectoryElement : Element
    {
        public Element[] Children { get; set; }

        public DirectoryElement(string path) : base(path)
        {
            Children = Helper.BuildElementTree(path).ToArray();
        }

        public override void Accept(IVisitor visitor){
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
            visitor?.Visit(this);
        }
    }
}