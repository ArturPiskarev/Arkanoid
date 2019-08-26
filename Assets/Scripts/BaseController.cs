using UnityEngine;

namespace MG.Controller
{
    public abstract class BaseController : MonoBehaviour
    {
        [Header("Destroy or Not")]
        private bool isDestroy;

        public bool IsDestroy
        {
            get { return isDestroy; }
            set { isDestroy = value; }
        }

    }
}