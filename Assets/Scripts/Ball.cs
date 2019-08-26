using MG.INTERFACE;
using UnityEngine;

namespace MG.BALL
{
    public class Ball : MonoBehaviour, ISpeed, IDamage
    {
        [Header("Rigidbody2D of Ball")] [SerializeField]
        private Rigidbody2D ballRigidbody = null;

        [Header("Speed of Ball")] [SerializeField]
        private float speed = 0;

        [Header("Damage of Ball")] [SerializeField]
        private int damage = 0;

        [Header("Ball is Active and add force?")] [SerializeField]
        private bool isActiveBall = false;

        [Header("Transform parent")] [SerializeField]
        private Transform transformParent = null;

        private GameObject[] bonus;
        [SerializeField] private AudioSource audioHitRacket;


        public AudioSource AudioHitRacket
        {
            get { return audioHitRacket; }
        }

        public GameObject[] Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Transform TransformParent
        {
            get { return transformParent; }
            set { transformParent = value; }
        }

        public bool IsActiveBall
        {
            get { return isActiveBall; }
            set { isActiveBall = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Rigidbody2D BallRigidbody
        {
            get { return ballRigidbody; }
            set { ballRigidbody = value; }
        }

        /// <summary>
        /// Load all bonus
        /// </summary>
        void Awake()
        {
            bonus = Resources.LoadAll<GameObject>("Bonus");

        }
    }
}