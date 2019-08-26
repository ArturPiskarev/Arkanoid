using MG.MANAGER;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MG.BUTTON
{
    public class ButtonPause : MonoBehaviour
    {
        [SerializeField] private Button buttonPause;
        [Inject] private Manager _manager;


        void Start()
        {
            buttonPause.onClick.AddListener(PauseCLick);


        }


        public void PauseCLick()
        {
#if UNITY_EDITOR

            EditorApplication.isPaused = true;

#endif
            _manager.Pause = !_manager.Pause;
            Time.timeScale = _manager.Pause ? 1 : 0;



        }
    }
}