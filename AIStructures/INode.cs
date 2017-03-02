using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public interface INode<T>
    {
        List<T> getSuccessors(T node);
        int Evaluate(T node);
    }
}
