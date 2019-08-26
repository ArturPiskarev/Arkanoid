using System.Collections;
using MG.RACKET;
using UnityEngine;

namespace MG.BONUS
{
    public class BonusSpeedOfRacketView : MonoBehaviour
    {
        [SerializeField] private BonusSpeedOfRacket bonusSpeedOfRacket;

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.name == "racket")
            {
                bonusSpeedOfRacket.Racket = col.gameObject.GetComponent<Racket>();
                bonusSpeedOfRacket.Racket.Speed += bonusSpeedOfRacket.SpeedBonus;
                bonusSpeedOfRacket.Sprite.enabled = false;
            }
        }

        //Change speed after delay
        IEnumerator Delay(float timeToPause)
        {
            bonusSpeedOfRacket.IsGetBonus = true;
            yield return new WaitForSeconds(timeToPause);
            bonusSpeedOfRacket.Racket.Speed -= bonusSpeedOfRacket.SpeedBonus;
            bonusSpeedOfRacket.IsGetBonus = false;
            Destroy(this.gameObject);
        }

        void Update()
        {
            if (bonusSpeedOfRacket.IsGetBonus)
            {
                return;
            }

            StartCoroutine(Delay(bonusSpeedOfRacket.TimeActive));
        }
    }
}