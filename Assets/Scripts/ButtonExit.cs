
using UnityEngine;
using UnityEngine.UI;

namespace MG.BUTTON
{
    public class ButtonExit : MonoBehaviour
    {
        [SerializeField] private Button exitButton;

        private void Start()
        {
            exitButton.onClick.AddListener(Exit);
        }

        private void Exit()
        {
            Application.Quit();
        }
    }
}