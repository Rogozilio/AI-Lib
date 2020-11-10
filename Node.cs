using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    /// <summary>
    /// Узел дерева поведений
    /// </summary>
    public abstract class  Node
    {
        /// <summary>
        /// Состояние текущего узла
        /// </summary>
        protected NodeStates _nodeState;

        public NodeStates nodeState
        {
            get { return _nodeState; }
        }

        /// <summary>
        /// Оценка узла
        /// </summary>
        /// <returns></returns>
        public abstract NodeStates Evaluate();
    }
}
