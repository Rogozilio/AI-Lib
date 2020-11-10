using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AI
{
    /// <summary>
    /// Возвращает расстояние между объектами
    /// </summary>
    static public class Distance 
    {
        /// <summary>
        /// Расстояние между двумя игровыми объекатми
        /// </summary>
        static public float GameObj(GameObject obj1, GameObject obj2)
        {
            float distance = Vector2.Distance(obj1.transform.position
                , obj2.transform.position);
            return distance;
        }
        /// <summary>
        /// Расстояние между двумя вектарами
        /// </summary>
        /// <returns></returns>
        static public float GameObj(Vector3 obj1, Vector3 obj2)
        {
            return Vector3.Distance(obj1, obj2);
        }
        /// <summary>
        /// Расстояние obj до ближайшего объекта из списка objs
        /// </summary>
        static public float GameObjs(GameObject obj, params GameObject[] objs)
        {
            float[] distanceObj = new float[objs.Length];
            for(int i = 0; i < objs.Length;i++)
            {
                distanceObj[i] = GameObj(obj, objs[i]);
            }
            float distance = Mathf.Min(distanceObj);
            return distance;
        }
    }
}
