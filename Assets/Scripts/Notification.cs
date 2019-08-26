using UnityEngine;
/// <summary>
/// not use
/// </summary>
public class Notification : MonoBehaviour
    {
        private string racketSpeedPlus = "racket.speed.plus";
        private string racketLifeMinus = "racket.life.minus";
        private string racketLifePlus = "racket.life.plus";
        private string startGame = "start.game";
        private string winGame = "win.game";
        private string loseGame = "lose.game";

        public string RacketSpeedPlus
        {
            get { return racketSpeedPlus; }

        }

        public string WinGame
        {
            get { return winGame; }
        }
    }
