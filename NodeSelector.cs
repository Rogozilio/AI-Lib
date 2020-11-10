using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class NodeSelector : Node
    {
        /// <summary>
        /// Список дочерних узлов выборки
        /// </summary>
        protected List<Node> _nodes = new List<Node>();

        /// <summary>
        /// Начальный набор дочерних узлов
        /// </summary>
        public NodeSelector(List<Node> nodes)
        {
            _nodes = nodes;
        }

        /// <summary>
        /// Если какой-либо из потомков сообщает об успехе, селектор немедленно сообщать об успехе вверх.Если все дети проиграют, вместо этого он сообщит об ошибке.
        /// </summary>
        public override NodeStates Evaluate()
        {
            foreach (Node node in _nodes)
            {
                switch (node.Evaluate())
                {
                    case NodeStates.FAILURE:
                    continue;
                    case NodeStates.SUCCESS:
                    _nodeState = NodeStates.SUCCESS;
                    return _nodeState;
                    case NodeStates.RUNNING:
                    _nodeState = NodeStates.RUNNING;
                    return _nodeState;
                    default:
                    continue;
                }
            }
            _nodeState = NodeStates.FAILURE;
            return _nodeState;
        }
    }
}
