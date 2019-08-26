using MG.Controller;
using UnityEngine;
using Zenject;

namespace MG.RACKET
{
    public class RacketController : BaseController
    {
        [Inject] private Racket racket;
        private float horizontalAxis = 0.0f;
        private bool inputSpace = false;

        public bool InputSpace
        {
            get { return inputSpace; }
        }

        public float HorizontalAxis
        {
            get { return horizontalAxis; }
        }

        private void FixedUpdate()
        {
            // Get Horizontal Input
            horizontalAxis = Input.GetAxisRaw("Horizontal");
            inputSpace = Input.GetKeyDown(KeyCode.Space);
            racket.PositionOfBall = racket.PositionOfBall;
        }


    }
}
