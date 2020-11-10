using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    /// <summary>
    /// Машина состояний
    /// </summary>
    public class StateMachine
    {
        /// <summary>
        /// Текущие состояние
        /// </summary>
        public State CurrentState;
        /// <summary>
        /// Включение машины состояний
        /// </summary>
        /// <param name="startingState">Начальное состояние</param>
        public void Initialize(State startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }
        /// <summary>
        /// Переключение между состояниями
        /// </summary>
        /// <param name="newState">Новое состояние</param>
        public void ChangeState(State newState)
        {
            CurrentState.Exit();

            CurrentState = newState;
            newState.Enter();
        }
    }
}
