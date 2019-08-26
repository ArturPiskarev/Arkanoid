using MG.MANAGER;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace MG.BUTTON
{
    public class ButtonLose : MonoBehaviour
    {
        [SerializeField] private Button buttonLose;
        [Inject] private Manager _manager;

        void Start()
        {
            buttonLose.onClick.AddListener(ButtonLoseCLick);
        }

        public void ButtonLoseCLick()
        {
            SceneManager.LoadScene(_manager.SceneLoad);
        }
    }
}