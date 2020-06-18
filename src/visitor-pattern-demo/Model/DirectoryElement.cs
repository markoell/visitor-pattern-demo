using System.Linq;
using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public class DirectoryElement : Element
    {
        private Element[] _children;
        private string _path;

        public DirectoryElement(string path)
        {
            _path = path;
            _children = Helper.BuildElementTree(path).ToArray();
        }

        public override void Accept(IVisitor visitor){
            visitor?.Visit(this);
            foreach (var child in _children)
            {
                child.Accept(visitor);
            }
        }
    }
}