using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AI
{
    /// <summary>
    /// Возвращает игровые объекты
    /// </summary>
    static public class GO
    {
        /// <summary>
        /// Возвращает ближайший объект к obj из params objs
        /// </summary>
        static public GameObject Close(GameObject obj, params GameObject[] objs)
        {
            GameObject gameObjClose = objs[0];

            for (int i = 0; i < objs.Length; i++)
            {
                if (Distance.GameObj(obj, objs[i]) < 
                    Distance.GameObj(obj, gameObjClose))
                {
                    gameObjClose = objs[i + 1];
                }
            }
            return gameObjClose;
        }

        /// <summary>
        /// Возвращает ближайший объект к obj из списка objs
        /// </summary>
        static public GameObject Close(GameObject obj, List<GameObject> objs)
        {
            GameObject gameObjClose = objs[0];

            foreach (var iObj in objs)
            {
                if (Distance.GameObj(obj, iObj) <
                    Distance.GameObj(obj, gameObjClose))
                {
                    gameObjClose = iObj;
                }
            }
            return gameObjClose;
        }

        /// <summary>
        /// Возвращает obj между объектами obj1 и obj2
        /// </summary>
        static public GameObject CrossingRay(GameObject obj1, GameObject obj2)
        {
            Ray ray = new Ray(obj1.transform.position, obj2.transform.position - obj1.transform.position);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10f);
            return hit.collider.gameObject;
        }

        /// <summary>
        /// Возвращает obj между вектарами vec1 и vec2
        /// </summary>
        static public GameObject CrossingRay(Vector3 vec1, Vector3 vec2)
        {
            Ray ray = new Ray(vec1, vec2 - vec1);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10f);
            return hit.collider.gameObject;
        }
    }
}
