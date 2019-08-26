using UnityEngine;

namespace MG.MANAGER
{
    public class ManagerSingletone : MonoBehaviour
    {
        public static ManagerSingletone Instance { get; private set; }

        [Header("Score of player")] [SerializeField]
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public void Update()
        {


        }

        private void Start()
        {
            Instance = this;


            DontDestroyOnLoad(gameObject);

        }
    }
}
