using MG.BALL;
using MG.RACKET;
using UnityEngine;

namespace MG.BONUS
{
    public class BonusBase : MonoBehaviour
    {
        protected Racket racket;
        protected Ball ball;
        [SerializeField] protected string bonusName;
        [SerializeField] protected bool isGetBonus;
        [SerializeField] protected float timeActive = 0.0f;
        [SerializeField] protected SpriteRenderer sprite = null;

        public SpriteRenderer Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public float TimeActive
        {
            get { return timeActive; }
            set { timeActive = value; }
        }

        public string BonusName
        {
            get { return bonusName; }
            set { bonusName = value; }
        }

        public bool IsGetBonus
        {
            get { return isGetBonus; }
            set { isGetBonus = value; }
        }

        public Racket Racket
        {
            get { return racket; }
            set { racket = value; }
        }

        public Ball Ball
        {
            get { return ball; }
            set { ball = value; }
        }
    }
}
