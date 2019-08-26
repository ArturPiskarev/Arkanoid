using MG.RACKET;
using UnityEngine;
using Zenject;

namespace MG.BALL
{
    public class BallView : MonoBehaviour
    {
        [Inject]
        private Ball ball;
        [Inject]
        private Racket racket;
        [Inject]
        private RacketController racketController;
    
        private void FixedUpdate()
        {
            //Position of ball when not punish him
            if (!ball.IsActiveBall)
            {
                ball.transform.position = new Vector2(racket.PositionOfBall.position.x, racket.PositionOfBall.position.y);
                ball.BallRigidbody.isKinematic = true;

            }
            //Punish ball
            if (racketController.InputSpace&&!ball.IsActiveBall)
            {
                ball.IsActiveBall = true;

                if (ball.IsActiveBall)
                {

                    ball.BallRigidbody.isKinematic = false;
                    Debug.Log("You punish ball");
                    ball.BallRigidbody.velocity = Vector2.up * ball.Speed;
                    
                }
            }
        }

     
        private void OnCollisionEnter2D(Collision2D col)
        {
            // Hit the Racket?
            if (col.gameObject.name == "racket")
            {
                // Calculate hit Factor
                float x = HitFactor(transform.position,
                    col.transform.position,
                    col.collider.bounds.size.x);

                // Calculate direction, set length to 1
                Vector2 dir = new Vector2(x, 1).normalized;

                // Set Velocity with dir * speed
                ball.BallRigidbody.velocity = dir * ball.Speed;
                ball.AudioHitRacket.Play();
            }
        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.name == "Death")
            {
                racket.Life -= 1;
                ball.IsActiveBall = false;
                
            }
        }

        public float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
        {
            // ascii art:
            //
            // 1  -0.5  0  0.5   1  <- x value
            // ===================  <- racket
            //
            return (ballPos.x - racketPos.x) / racketWidth;
        }

    }

}