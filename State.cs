using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AI
{
    /// <summary>
    /// Состояния машины состояний
    /// </summary>
    public abstract class  State : MonoBehaviour
    {
        /// <summary>
        /// Машина состояний определяющая ее состояния
        /// </summary>
        protected StateMachine _movementSM;
        public State(StateMachine movementSM)
        {
            _movementSM = movementSM;
        }
        /// <summary>
        /// Срабатывает первым. Для определения переменных.
        /// </summary>
        public virtual void Enter()
        {

        }
        /// <summary>
        /// Обработка ввода игрока
        /// </summary>
        public virtual void HandleInput()
        {

        }
        /// <summary>
        /// обработка логики
        /// </summary>
        public virtual void LogicUpdate()
        {

        }
        /// <summary>
        /// обработка физики
        /// </summary>
        public virtual void PhysicsUpdate()
        {

        }
        /// <summary>
        /// Срабатывает последним. Для очистки данных
        /// </summary>
        public virtual void Exit()
        {

        }
    }
}
