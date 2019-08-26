using UnityEngine.UI;
using UnityEngine;

namespace MG.MANAGER
{
    public class Manager : MonoBehaviour
    {
        [Header("Player Score")]
        [SerializeField]
        private int score = 0;
        [Header("Win Game or Not")]
        [SerializeField]
        private bool win = false;
        [Header("Loose Game or Not")]
        [SerializeField]
        private bool lose = false;
        [Header("Choose the Lvl")]
        [SerializeField]
        private bool choseLvl = false;
        [Header("Is choose the Lvl")]
        [SerializeField]
        private bool isChoseLvl = false;
        [Header("Pause Game")]
        [SerializeField]
        private bool pause = false;
        [Header("Pause Game")]
        [SerializeField]
        private bool isMainMenu = false;
        [Header("Player Life")]
        [SerializeField]
        private int playerLife = 0;
        [Header("Button Win")]
        [SerializeField]
        private GameObject winButton = null;
        [Header("Button Loose")]
        [SerializeField]
        private GameObject loseButton = null;
        [Header("Button Choose")]
        [SerializeField]
        private GameObject chooseButton = null;
        [Header("Button Pause")]
        [SerializeField]
        private GameObject pauseButton = null;
        [Header("info Text")]
        [SerializeField]
        private Text infoText = null;
        [Header("Canvas Pause")]
        [SerializeField]
        private GameObject canvasChoose = null;
        private int sceneLoad = 0;

        public GameObject CanvasChoose
        {
            get { return canvasChoose; }
            set { canvasChoose = value; }
        }
        public int SceneLoad
        {
            get { return sceneLoad; }
            set { sceneLoad = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public bool Pause
        {
            get{ return pause; }
            set { pause = value; }
        }
        public bool IsMainMenu
        {
            get { return isMainMenu; }
            set { isMainMenu= value; }
        }
        public bool ChooseLvl
        {
            get { return choseLvl; }
            set { choseLvl = value; }
        }
        public bool IsChooseLvl
        {
            get { return isChoseLvl; }
            set { isChoseLvl = value; }
        }
        public bool Win
        {
            get { return win; }
            set { win = value; }
        }
        public bool Lose
        {
            get { return lose; }
            set { lose = value; }
        }

        public Text InfoText
        {
            get { return infoText; }
            set { infoText = value; }
        }
        public GameObject WinButton
        {
            get { return winButton; }
            set { winButton = value; }
        }
        public GameObject LoseButton
        {
            get { return loseButton; }
            set { loseButton = value; }
        }
        public GameObject ChooseButton
        {
            get { return chooseButton; }
            set { chooseButton = value; }
        }
        public GameObject PauseButton
        {
            get { return pauseButton; }
            set { pauseButton = value; }
        }
       
        //link pickup automatic
#if UNITY_EDITOR
        void OnValidate()
        {

            infoText = transform.Find("Text").GetComponent<Text>();
            chooseButton = transform.Find("Choose").gameObject;
            pauseButton = transform.Find("Pause").gameObject;
            canvasChoose = transform.Find("Canvas").gameObject;
          
        }
#endif
    }
} 