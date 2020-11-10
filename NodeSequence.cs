using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class NodeSequence : Node
    {
        /// <summary>
        /// Список дочерних узлов последовательности
        /// </summary>
        private List<Node> _nodes = new List<Node>();

        /// <summary>
        /// Начальный набор дочерних узлов
        /// </summary>
        public NodeSequence(List<Node> nodes)
        {
            _nodes = nodes;
        }

        /// <summary>
        /// Если какой-либо дочерний узел возвращает FAIL, выходит из строя весь узел. Если все возвращают SUCCESS, узел сообщает об успехе
        /// </summary>
        public override NodeStates Evaluate()
        {
            bool anyChildRunning = false;

            foreach (Node node in _nodes)
            {
                switch (node.Evaluate())
                {
                    case NodeStates.FAILURE:
                    _nodeState = NodeStates.FAILURE;
                    return _nodeState;
                    case NodeStates.SUCCESS:
                    continue;
                    case NodeStates.RUNNING:
                    anyChildRunning = true;
                    continue;
                    default:
                    _nodeState = NodeStates.SUCCESS;
                    return _nodeState;
                }
            }
            _nodeState = anyChildRunning ? NodeStates.RUNNING : NodeStates.SUCCESS;
            return _nodeState;
        }
    }
}
