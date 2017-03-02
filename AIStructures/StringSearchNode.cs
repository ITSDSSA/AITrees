using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class StringSearchNode : INode<StringSearchNode>
    {
        public int Cost { get; set; }
        public string Val { get; set; }
        public List<StringSearchNode> successors;

        public int Evaluate(StringSearchNode Node)
        {
            return Node.Cost;
        }

        public List<StringSearchNode> getSuccessors(StringSearchNode node)
        {
            return successors;
        }

    }
}
