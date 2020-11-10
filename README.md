# AI-Lib
## 1) static Distance.cs
- float GameObj(GameObject obj1, GameObject obj2)
- float GameObj(Vector3 obj1, Vector3 obj2)
- float GameObjs(GameObject obj, params GameObject[] objs)
## 2) static GO.cs
- GameObject Close(GameObject obj, params GameObject[] objs)
- GameObject Close(GameObject obj, List<GameObject> objs)
- GameObject CrossingRay(GameObject obj1, GameObject obj2)
- GameObject CrossingRay(Vector3 vec1, Vector3 vec2)
## 3) Машина состояний
- StateMachine.cs
- abstuct State.cs
## 4) Дерево поведений
- Enum NodeState.cs
- abstruct Node.cs
- NodeSelector.cs
- NodeSequence.cs
- NodeAction.cs
