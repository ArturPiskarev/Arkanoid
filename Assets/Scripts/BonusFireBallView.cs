using MG.BALL;
using MG.RACKET;
using UnityEngine;
using Zenject;
/// <summary>
/// Not working on 100%
/// </summary>
public class BonusFireBallView : MonoBehaviour
{
    [Inject]
    private Ball ball;
    [Inject]
    private Racket racket;
    [Inject]
    private RacketController racketController;
    [Inject]
    private BonusFireBall bonusFireBall;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "racket")
        {
            bonusFireBall.TransformParentOldBall = ball.TransformParent;
            bonusFireBall.VectorOldBall = ball.transform.position;
            Destroy(ball.gameObject);
            bonusFireBall.TransformNewBall = Instantiate(bonusFireBall.FireBall, bonusFireBall.VectorOldBall,
                Quaternion.identity, bonusFireBall.TransformParentOldBall).transform;
            bonusFireBall.TransformNewBall.transform.parent = bonusFireBall.TransformParentOldBall;
            bonusFireBall.NewBall = bonusFireBall.TransformNewBall.gameObject;
            bonusFireBall.IsGetBonus = true;

        }
    }
    void FixedUpdate()
    {
        //if (bonusFireBall.IsGetBonus)
        //{
        //    bonusFireBall.NewBall.transform.position = new Vector2(racket.PositionOfBall.position.x, racket.PositionOfBall.position.y);
        //    bonusFireBall.NewBall.GetComponent<Ball>().BallRigidbody.isKinematic = true;

        //}
    }
}
