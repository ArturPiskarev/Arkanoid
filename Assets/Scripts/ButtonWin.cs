using MG.MANAGER;
using MG.RACKET;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace MG.BUTTON
{
    public class ButtonWin : MonoBehaviour
    {
        [SerializeField]
        private Button buttonWin=null;
        [Inject]
        private Manager manager = null;
        [Inject]
        private Racket racket=null;

        void Start()
        {
            buttonWin.onClick.AddListener(ButtonWinCLick);
        }

        public void ButtonWinCLick()
        {
            if (manager.SceneLoad < 7&&manager.SceneLoad!=0)
            {
                SceneManager.LoadScene(manager.SceneLoad + 1);
                racket.Life = 3;
            }
            else
            {
                SceneManager.LoadScene(1);
                
            }
        }
    }
}
