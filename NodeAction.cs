using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class NodeAction : Node
    {
        /// <summary>
        /// Делегат узла
        /// </summary>
        public delegate NodeStates ActionNodeDelegate();

        /// <summary>
        /// Делегат, который вызывается для оценки этого узла
        /// </summary>
        private ActionNodeDelegate _action;

        public NodeAction(ActionNodeDelegate action)
        {
            _action = action;
        }

        /// <summary>
        ///  Оценивает значение делегата
        /// </summary>
        public override NodeStates Evaluate()
        {
            switch (_action())
            {
                case NodeStates.SUCCESS:
                _nodeState = NodeStates.SUCCESS;
                return _nodeState;
                case NodeStates.FAILURE:
                _nodeState = NodeStates.FAILURE;
                return _nodeState;
                case NodeStates.RUNNING:
                _nodeState = NodeStates.RUNNING;
                return _nodeState;
                default:
                _nodeState = NodeStates.FAILURE;
                return _nodeState;
            }
        }
    }
}
