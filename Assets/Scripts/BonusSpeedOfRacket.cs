using UnityEngine;

namespace MG.BONUS
{
    public class BonusSpeedOfRacket : BonusBase
    {

        [Header("Bonus speed for Racket")] [SerializeField]
        private float speedBonus = 0.0f;

        public float SpeedBonus
        {
            get { return speedBonus; }
            set { speedBonus = value; }
        }


    }
}