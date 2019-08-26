using MG.Controller;
using MG.MANAGER;
using UnityEngine;
using Zenject;

namespace MG.BLOCK
{
    public class PackCheckController : BaseController
    {
        [Inject]
        private Manager _manager;

        void Start()
        {
           
        }
        void Update()
        {
            
            if (transform.childCount==1)
            {
                _manager.Win = true;
                Destroy(gameObject);
                Debug.Log("You win!!!!!");
            }
        }
    }
}
