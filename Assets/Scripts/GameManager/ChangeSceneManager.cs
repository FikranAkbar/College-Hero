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
        // SPAWN POINT: OUTDOOR
        // Area Kota
        spawnLocation.Add("2To1", new Vector2(11.5f, -0.86f));
        spawnLocation.Add("3To1", new Vector2(-2.08f, -7.07f));
        spawnLocation.Add("TempatMakanTo1_AreaKota", new Vector2(8.28f, -0.5f));
        // Area Taman
        spawnLocation.Add("1To2", new Vector2(-12.39f, -0.53f));
        spawnLocation.Add("3To2", new Vector2(-5.8f, -7.28f));
        spawnLocation.Add("ApotekTo2", new Vector2(10.82f, -6.48f));
        spawnLocation.Add("TempatMakanTo2_AreaTaman", new Vector2(3.85f, 6.75f));
        spawnLocation.Add("MinimarketTo2_AreaTaman", new Vector2(10.82f, -6.48f));
        // Area Universitas
        spawnLocation.Add("1To3", new Vector2(-13.68f, 9.47f));
        spawnLocation.Add("2To3", new Vector2(13.94f, 9.47f));
        spawnLocation.Add("TempatMakanTo3_AreaUniversitas", new Vector2(11.07f, -8.6f));
        spawnLocation.Add("ApotekTo3_AreaUniversitas", new Vector2(0.09f, 6.5f));
        // Unknown
        spawnLocation.Add("default", new Vector2(-6.36f, 5.52f));

        // SPAWN POINT: INDOOR
        // Area Kos
        spawnLocation.Add("1ToKos", new Vector2(0.42f, -4.61f));
        spawnLocation.Add("KamarKosToKos", new Vector2(-2.64f, 2.32f));
        // Area Kamar Kos
        spawnLocation.Add("KosToKamarKos", new Vector2(1.72f, -2.91f));
        // Area Tempat Makan
        spawnLocation.Add("1ToTempatMakan_AreaKota", new Vector2(11.15f, -2.8f));
        spawnLocation.Add("2ToTempatMakan_AreaTaman", new Vector2(11.15f, -2.8f));
        spawnLocation.Add("3ToTempatMakan_AreaUniversitas", new Vector2(11.15f, -2.8f));
        // Area Apotek
        spawnLocation.Add("2ToApotek", new Vector2(-7.42f, -1.95f));
        // Area Minimarket
        spawnLocation.Add("2ToMinimarket_AreaTaman", new Vector2(-7.42f, -1.95f));
        spawnLocation.Add("3ToMinimarket_AreaUniversitas", new Vector2(-7.42f, -1.95f));
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

    public static void ChangeArea_OutdoorToIndoor(int from, string to)
    {
        if(from == 1)
        {
            if(to == "Kos")
            {
                Initiate.Fade("Maps_Kos", Color.black, 2.0f);
                toPos = "1ToKos";
            }
            else if(to == "TempatMakan")
            {
                Initiate.Fade("Maps_TempatMakan_AreaKota", Color.black, 2.0f);
                toPos = "1ToTempatMakan_AreaKota";
            }
        }
        else if(from == 2)
        {
            if(to == "Apotek")
            {
                Initiate.Fade("Maps_Apotek", Color.black, 2.0f);
                toPos = "2ToApotek";
            }
            else if(to == "TempatMakan")
            {
                Initiate.Fade("Maps_TempatMakan_AreaTaman", Color.black, 2.0f);
                toPos = "2ToTempatMakan_AreaTaman";
            }
            else if(to == "Minimarket")
            {
                Initiate.Fade("Maps_Minimarket_AreaTaman", Color.black, 2.0f);
                toPos = "2ToMinimarket_AreaTaman";
            }
        }
        else if(from == 3)
        {
            if(to == "TempatMakan")
            {
                Initiate.Fade("Maps_TempatMakan_AreaUniversitas", Color.black, 2.0f);
                toPos = "3ToTempatMakan_AreaUniversitas";
            }
        }
    }

    public static void ChangeArea_IndoorToOutdoor(string from, int to)
    {
        if(from == "TempatMakan")
        {
            if(to == 1)
            {
                Initiate.Fade("Maps_AreaKota", Color.black, 2.0f);
                toPos = "TempatMakanTo1_AreaKota";
            }
            else if(to == 2)
            {
                Initiate.Fade("Maps_AreaTaman", Color.black, 2.0f);
                toPos = "TempatMakanTo2_AreaTaman";
            }
            else if(to == 3)
            {
                Initiate.Fade("Maps_AreaUniversitas", Color.black, 2.0f);
                toPos = "TempatMakanTo3_AreaUniversitas";
            }
        }
        if(from == "Apotek")
        {
           if(to == 2)
            {
                Initiate.Fade("Maps_AreaTaman", Color.black, 2.0f);
                toPos = "ApotekTo2";
            }
        }
        if(from == "Minimarket")
        {
            if(to == 2)
            {
                Initiate.Fade("Maps_AreaTaman", Color.black, 2.0f);
                toPos = "MinimarketTo2_AreaTaman";
            }
        }
    }

    public static void ChangeArea_IndoorToIndoor(string from, string to)
    {
        if(from == "Kos")
        {
            if(to == "KamarKos")
            {
                Initiate.Fade("Maps_KamarKos", Color.black, 2.0f);
                toPos = "KosToKamarKos";
            }
        }
        else if(from == "KamarKos")
        {
            if(to == "Kos")
            {
                Initiate.Fade("Maps_Kos", Color.black, 2.0f);
                toPos = "KamarKosToKos";
            }
        }
    }
}
