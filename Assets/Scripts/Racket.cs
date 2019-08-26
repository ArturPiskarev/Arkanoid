using MG.INTERFACE;
using MG.Model;
using UnityEngine;

namespace MG.RACKET
{
    public class Racket : BaseObjectScene,ISpeed,IRigidbody2d,ILife
    {
        [Header("Speed of Racket")] [SerializeField]
        private float speed = 0;
        [Header("Rigidbody of Racket")] [SerializeField]
        private Rigidbody2D rigidbody;
        [Header("Life of Racket")] [SerializeField]
        private int life = 0;
        [Header("Position of ball")] [SerializeField]
        private Transform positionOfBall ;

        public Transform PositionOfBall
        {
            get { return positionOfBall; }
            set { positionOfBall = value; }
        }
        public float Speed
        {
            get { return speed;}
            set { speed = value; }
        }
        
        public Rigidbody2D Rigidbody2d
        {
            get { return rigidbody; }
            set { rigidbody = value; }
        }
       
        public int Life
        {
            get { return life; }
            set { life = value; }
        }

    }
    
}

