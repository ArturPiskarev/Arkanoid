using MG.MANAGER;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MG.BUTTON
{
    public class ButtonBackChoose : MonoBehaviour
    {
        [Inject]
        private Manager manager;
        [SerializeField]
        private Button choseButton;

        void Start()
        {
            choseButton.onClick.AddListener(BackChoseMenu);
        }

        private void BackChoseMenu()
        {
            manager.CanvasChoose.SetActive(false);
            manager.WinButton.SetActive(true);
            manager.LoseButton.SetActive(true);
            manager.ChooseButton.SetActive(true);
            manager.PauseButton.SetActive(true);
            manager.ChooseLvl = false;
            manager.IsChooseLvl = true;
        }
    }
}