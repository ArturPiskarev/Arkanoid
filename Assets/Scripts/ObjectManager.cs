using MG.BALL;
using MG.RACKET;
using UnityEngine;

/// <summary>
/// not use
/// </summary>
public class ObjectManager : MonoBehaviour {

	[SerializeField] private Racket[] rackets=new Racket[3];
    [SerializeField] private BallView[] _ballsView = new BallView[5];

    public Racket[] GetWeaponses
    {
        get { return rackets; }
    }

    public BallView[] GetAmmunitions
    {
        get { return _ballsView; }
    }
}
