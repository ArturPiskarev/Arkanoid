using MG.BALL;
using MG.BONUS;
using MG.RACKET;
using UnityEngine;
using Zenject;
/// <summary>
/// Not working on 100%
/// </summary>
public class BonusFireBall : BonusBase
{
    [Header("Prefab of bonus")]
    [SerializeField]
    private GameObject fireBall;
    private Transform transformNewBall = null;
    private Transform transformParentOfOldBall = null;
    private Vector3 vectorOldBall;
    private GameObject newBall = null;

    [Inject] private Ball ball;
    [Inject] private Racket racket;
    [Inject] private RacketController racketController;

    public GameObject FireBall
    {
        get { return fireBall; }
        set { fireBall = value; }
    }

    public Transform TransformNewBall
    {
        get { return transformNewBall; }
        set { transformNewBall = value; }
    }
    public Transform TransformParentOldBall
    {
        get { return transformParentOfOldBall; }
        set { transformParentOfOldBall = value; }
    }

    public Vector3 VectorOldBall
    {
        get { return vectorOldBall; }
        set { vectorOldBall = value; }
    }

    public GameObject NewBall
    {
        get { return newBall; }
        set { newBall = value; }
    }
}
