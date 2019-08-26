using MG.MANAGER;
using MG.RACKET;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace MG.MANAGER
{
    public class ManagerView : MonoBehaviour
    {
        [Inject]
        private Manager manager;
        [Inject]
        private Racket racket;
        [Inject]
        private ManagerSingletone managerSingletone;

        void Start()
        {
            manager.SceneLoad = SceneManager.GetActiveScene().buildIndex;
            if (manager.SceneLoad == 0)
            {
                manager.IsMainMenu = true;
            }
            else
            {
                manager.IsMainMenu = false;
            }
            manager.WinButton.SetActive(false);
            manager.LoseButton.SetActive(false);
            manager.ChooseButton.SetActive(false);
            if (manager.IsMainMenu)
            {
                manager.WinButton.SetActive(true);
                manager.LoseButton.SetActive(true);
                manager.ChooseButton.SetActive(true);
            }
        }
        //UI mapping
        void Update()
        {
            if (manager.Win)
            {
                manager.WinButton.SetActive(true);
                manager.ChooseButton.SetActive(true);
            }

            if (manager.Lose)
            {
                manager.LoseButton.SetActive(true);
                manager.ChooseButton.SetActive(true);
            }

            if (manager.ChooseLvl)
            {
                manager.WinButton.SetActive(false);
                manager.LoseButton.SetActive(false);
                manager.ChooseButton.SetActive(false);
                manager.PauseButton.SetActive(false);
            }

            if (manager.Pause)
            {
                manager.WinButton.SetActive(true);
                manager.LoseButton.SetActive(true);
                manager.ChooseButton.SetActive(true);
            }

            if (!manager.ChooseLvl && manager.IsChooseLvl)
            {
                manager.WinButton.SetActive(true);
                manager.LoseButton.SetActive(true);
                manager.ChooseButton.SetActive(true);
                manager.PauseButton.SetActive(true);
                manager.IsChooseLvl = false;
            }

            if (manager.IsMainMenu)
            {
                manager.WinButton.SetActive(true);
                manager.LoseButton.SetActive(true);
                manager.ChooseButton.SetActive(true);
                manager.PauseButton.SetActive(false);
            }

        }

        private void OnGUI()
        {
            if (manager.Win)
            {
                manager.InfoText.text = "!! YOU WIN ,Your Score:" + managerSingletone.Score + "!!";
                manager.WinButton.SetActive(true);
            }
            else if (manager.Lose)
            {
                manager.InfoText.text = "!! YOU LOSE ,Your Score:" + managerSingletone.Score + "!!";
                manager.LoseButton.SetActive(true);
            }
            else
            {
                manager.InfoText.text = "Score: " + managerSingletone.Score + " / Life: " + racket.Life.ToString();
            }
        }
    }
}