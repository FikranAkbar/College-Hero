using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour
{

    [SerializeField] static GameObject player;
    public static ChangeSceneManager changeSceneManagerInstance;
    public static string toPos = "default";
    public static Dictionary<string, Vector2> spawnLocation = new Dictionary<string, Vector2>() { };

    private void Awake()
    {
        if(changeSceneManagerInstance == null)
        {
            changeSceneManagerInstance = this;
            DontDestroyOnLoad(gameObject);
        } else if (changeSceneManagerInstance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation.Add("default", new Vector2(-6.36f, 5.52f));
        spawnLocation.Add("1To2", new Vector2(-12.39f, -0.53f));
        spawnLocation.Add("1To3", new Vector2(-13.68f, 9.47f));
        spawnLocation.Add("2To1", new Vector2(11.5f, -0.86f));
        spawnLocation.Add("2To3", new Vector2(13.94f, 9.47f));
        spawnLocation.Add("3To1", new Vector2(-2.08f, -7.07f));
        spawnLocation.Add("3To2", new Vector2(-5.8f, -7.28f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void ChangeArea_OutdoorToOutdoor(int from, int to)
    {
        if(from == 1)
        {
            if(to == 2)
            {
                Initiate.Fade("Maps_AreaTaman", Color.black, 2.0f);
                toPos = "1To2";
            }
            else if (to == 3)
            {
                Initiate.Fade("Maps_AreaUniversitas", Color.black, 2.0f);
                toPos = "1To3";
            }

        } else if (from == 2)
        {
            if (to == 1)
            {
                Initiate.Fade("Maps_AreaKota", Color.black, 2.0f);
                toPos = "2To1";
            }
            else if (to == 3)
            {
                Initiate.Fade("Maps_AreaUniversitas", Color.black, 2.0f);
                toPos = "2To3";
            }

        } else if (from == 3)
        {
            if (to == 1)
            {
                Initiate.Fade("Maps_AreaKota", Color.black, 2.0f);
                toPos = "3To1";
            }
            else if (to == 2)
            {
                Initiate.Fade("Maps_AreaTaman", Color.black, 2.0f);
                toPos = "3To2";
            }
        }
    }
}
