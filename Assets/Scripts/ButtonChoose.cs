using MG.MANAGER;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MG.BUTTON
{
    public class ButtonChoose : MonoBehaviour
    {
        [Inject]
        private Manager manager;
        [SerializeField]
        private Button choseButton;

        void Start()
        {
            choseButton.onClick.AddListener(ChoseMenu);
        }

        private void ChoseMenu()
        {
            manager.CanvasChoose.SetActive(true);
            manager.WinButton.SetActive(false);
            manager.LoseButton.SetActive(false);
            manager.ChooseButton.SetActive(false);
            manager.PauseButton.SetActive(false);

        }
    }
}