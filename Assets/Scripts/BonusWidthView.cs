using System.Collections;
using MG.RACKET;
using UnityEngine;

namespace MG.BONUS
{
    public class BonusWidthView : MonoBehaviour
    {
        [SerializeField] private BonusWidth bonusWidth;

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.name == "racket")
            {
                bonusWidth.Racket = col.gameObject.GetComponent<Racket>();
                bonusWidth.Racket.gameObject.transform.localScale += new Vector3(0.5f, 0.1f, 0);
                bonusWidth.Sprite.enabled = false;
            }
        }

        void Update()
        {
            if (bonusWidth.IsGetBonus)
            {
                return;
            }

            StartCoroutine(Delay(bonusWidth.TimeActive));
        }

        //change width of racket after delay
        IEnumerator Delay(float timeToPause)
        {
            bonusWidth.IsGetBonus = true;
            yield return new WaitForSeconds(timeToPause);
            bonusWidth.Racket.gameObject.transform.localScale += new Vector3(-0.5f, -0.1f, 0);
            bonusWidth.IsGetBonus = false;
            Destroy(this.gameObject);
        }



    }
}
