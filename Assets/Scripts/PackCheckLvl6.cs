using MG.MANAGER;
using UnityEngine;
using Zenject;

namespace MG.BLOCK
{
    /// <summary>
    /// Class special for 6 level because it's easier
    /// </summary>
    public class PackCheckLvl6 : MonoBehaviour
    {
        [Inject]
        private Manager _manager;

        void Start()
        {

        }

        void Update()
        {

            if (transform.childCount == 5)
            {
                _manager.Win = true;
                Destroy(gameObject);
                Debug.Log("You win!!!!!");
            }
        }
    }
}