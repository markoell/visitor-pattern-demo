using VisitorPatternDemo.Interface;

namespace VisitorPatternDemo.Model
{
    public abstract class Element {

        public string FullName { get; internal set; }

        public virtual void Accept(IVisitor visitor){
            visitor?.Visit(this);
        }
    }
}