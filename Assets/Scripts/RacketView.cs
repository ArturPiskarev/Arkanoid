using UnityEngine;
using Zenject;
using MG.MANAGER;

namespace MG.RACKET
{
    public class RacketView : MonoBehaviour
    {
        [Inject] private Racket racket;
        [Inject] private RacketController racketController;
        [Inject] private Manager _manager;

        private void FixedUpdate()
        {

            // Set Velocity (movement direction * speed)

            racket.Rigidbody2d.velocity = Vector2.right * racketController.HorizontalAxis * racket.Speed;


        }

        private void Update()
        {
            if (racket.Life < 0)
            {
                _manager.Lose = true;
            }
        }
    }
}
