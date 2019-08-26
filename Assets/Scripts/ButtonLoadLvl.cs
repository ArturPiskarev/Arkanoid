using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MG.BUTTON
{
    public class ButtonLoadLvl : MonoBehaviour
    {
        [Header("Number of lvl")] [SerializeField]
        private int numberOfLvl;

        [Header("Button of loadLvl")] [SerializeField]
        private Button loadLvl;

        void Start()
        {
            loadLvl.onClick.AddListener(LoadScene);

        }

        private void LoadScene()
        {
            SceneManager.LoadScene(numberOfLvl);
        }
    }
}