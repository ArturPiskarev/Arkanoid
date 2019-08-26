using UnityEngine;

namespace MG.Model
{
    public class BaseObjectScene : MonoBehaviour
    {
        private string nameGameObj;
        private GameObject gameObj;
        private Transform transformGameObj;
        private Vector2 position;
        private bool isDestroy;
        
        public string Name
        {
            get { return nameGameObj; }
            set
            {
                nameGameObj = value;
                GetGameObj.name = nameGameObj;
            }
        }

        public GameObject GetGameObj
        {
            get { return gameObj; }
        }

    
        public Transform GetTransformGameObj
        {
            get { return transformGameObj; }
        }

        public Vector2 Position
        {
            get
            {
                if (GetGameObj != null)
                {
                    position = GetTransformGameObj.position;
                }
                return position;
            }
            set
            {
                position = value;
                if (GetGameObj != null)
                {
                    GetTransformGameObj.position = position;
                }
            }
        }

        public bool IsDestroy
        {
            get { return isDestroy; }
            set
            {
                isDestroy = value;
            }
        }
        protected virtual void Awake()
        {
            gameObj = gameObject;
            nameGameObj = GetGameObj.name;
            transformGameObj = transform;
        }
    }
}
