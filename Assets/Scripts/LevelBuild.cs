using UnityEngine;
/// <summary>
/// Create simple grid our Levels
/// </summary>
public class LevelBuild : MonoBehaviour
{
    
    [Header("Block Blue")]
    [SerializeField]
    private GameObject blockBlue = null;
    [Header("Block Green")]
    [SerializeField]
    private GameObject blockGreen = null;
    [Header("Block Pink")]
    [SerializeField]
    private GameObject blockPink = null;
    [Header("Block Yelow")]
    [SerializeField]
    private GameObject blockYelow = null;
    [Header("Block Grey")]
    [SerializeField]
    private GameObject blockGrey = null;
    [Header("Block Dark Grey")]
    [SerializeField]
    private GameObject blockDarkGrey = null;
    [Header("Start X position first block")] [SerializeField]
    private float startPosX=0.0f;
    [Header("tart Y position first block")] [SerializeField]
    private float startPosY=0.0f;
    [Header("Count block on X axis")] [SerializeField]
    private int countX=0;
    [Header("Count block on Y axis")] [SerializeField]
    private int countY=0;
    [Header("Shift on X axis between blocks")] [SerializeField]
    private float outX=0.0f;
    [Header("Shift on Y axis between blocks")] [SerializeField]
    private float outY = 0.0f;
    [Header("Name of block")] [SerializeField]
    private string objName = "Block_";
    [Header("")] [SerializeField]
    private int id=0;
    [Header("")] [SerializeField]
    private GameObject[,] grid=null;

    void Start()
    {
        id = 0;
        float posXreset = startPosX;
        grid = new GameObject[countX, countY];
        for (int y = 0; y < 1; y++)
        {
            startPosY -= outY;
            for (int x = 0; x < 13; x++)
            {
                id++;
                startPosX += outX;
                grid[x, y] = Instantiate(blockBlue, new Vector2(startPosX, startPosY), Quaternion.identity) as GameObject;
                grid[x, y].name = objName + id;
                grid[x, y].transform.parent = transform;
            }
            startPosX = posXreset;
        }
        for (int y = 0; y < 1; y++)
        {
            startPosY -= outY;
            for (int x = 0; x < 13; x++)
            {
                id++;
                startPosX += outX;
                grid[x, y] = Instantiate(blockGreen, new Vector2(startPosX, startPosY), Quaternion.identity) as GameObject;
                grid[x, y].name = objName + id;
                grid[x, y].transform.parent = transform;
            }
            startPosX = posXreset;
        }
        for (int y = 0; y < 1; y++)
        {
            startPosY -= outY;
            for (int x = 0; x < 13; x++)
            {
                id++;
                startPosX += outX;
                grid[x, y] = Instantiate(blockPink, new Vector2(startPosX, startPosY), Quaternion.identity) as GameObject;
                grid[x, y].name = objName + id;
                grid[x, y].transform.parent = transform;
            }
            startPosX = posXreset;
        }
        for (int y = 0; y < 1; y++)
        {
            startPosY -= outY;
            for (int x = 0; x < 13; x++)
            {
                id++;
                startPosX += outX;
                grid[x, y] = Instantiate(blockYelow, new Vector2(startPosX, startPosY), Quaternion.identity) as GameObject;
                grid[x, y].name = objName + id;
                grid[x, y].transform.parent = transform;
            }
            startPosX = posXreset;
        }
        for (int y = 0; y < 1; y++)
        {
            startPosY -= outY;
            for (int x = 0; x < 13; x++)
            {
                id++;
                startPosX += outX;
                grid[x, y] = Instantiate(blockGrey, new Vector2(startPosX, startPosY), Quaternion.identity) as GameObject;
                grid[x, y].name = objName + id;
                grid[x, y].transform.parent = transform;
            }
            startPosX = posXreset;
        }
        for (int y = 0; y < 1; y++)
        {
            startPosY -= outY;
            for (int x = 0; x < 13; x++)
            {
                id++;
                startPosX += outX;
                grid[x, y] = Instantiate(blockDarkGrey, new Vector2(startPosX, startPosY), Quaternion.identity) as GameObject;
                grid[x, y].name = objName + id;
                grid[x, y].transform.parent = transform;
            }
            startPosX = posXreset;
        }
    }
}
