using MG.BALL;
using MG.MANAGER;
using UnityEngine;
using Zenject;

namespace MG.BLOCK
{
    public class Block : MonoBehaviour
    {
        [Header("Block Life")] [SerializeField]
        private int blockHp = 0;

        [Header("Block ID")] [SerializeField] private int blockId = 0;

        [Header("Block Vector2")] [SerializeField]
        private Vector2 position;

        [Header("Block Score")] [SerializeField]
        private int blockScore = 0;

        [Header("GreyBlock or not?")] [SerializeField]
        private bool isGreyBlock = false;

        [Header("Dark Grey Block or not?")] [SerializeField]
        private bool isDarkGreyBlock = false;

        [SerializeField] private Animator animation;
        [Inject] private Ball ball;
        [Inject] private Manager manager;
        [Inject] private ManagerSingletone managerMain;
        [SerializeField] private GameObject parentOfBonus = null;
        [SerializeField] private AudioSource audioHitBlock;
        private int random;

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.name == "ball")
            {
                audioHitBlock.Play();
                //is check the ruined block?
                if (!isDarkGreyBlock)
                {
                    blockHp -= ball.Damage;
                    if (blockHp <= 0)
                    {

                        managerMain.Score += blockScore;
                        Destroy(gameObject,0.1f);
                        if (ball.Bonus.Length != 0)
                        {
                            random = Random.Range(0, ball.Bonus.Length);
                            if (parentOfBonus.transform.childCount < 1)
                            {
                                //instantiate bonus on transform destroyed block
                                Instantiate(ball.Bonus[random], col.transform.position, Quaternion.identity).transform
                                    .parent = parentOfBonus.transform;
                            }




                        }
                    }

                    if (isGreyBlock)
                    {

                        if (blockHp.Equals(1))
                        {
                            animation.enabled = true;
                        }
                        else
                        {
                            Destroy(gameObject);
                        }
                    }
                }

            }
        }
    }
}
