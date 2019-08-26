using UnityEngine;

/// <summary>
/// not use yet
/// </summary>
[CreateAssetMenu(fileName = "GameConfig",menuName = "Create Game Config")]
public class GameConfig : ScriptableObject
{
    public int lifeRacket;
    public Vector2 startPosition;
    public Vector2 nowPosition;
    public int Level;
    public int SpeedRacket;
    public GameObject Block;
    public Transform BlockStartPosition;
}
