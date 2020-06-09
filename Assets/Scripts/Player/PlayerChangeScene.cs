using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "1To2")
        {
            ChangeSceneManager.ChangeArea_OutdoorToOutdoor(1, 2);
        }
        else if (collision.tag == "1To3")
        {
            ChangeSceneManager.ChangeArea_OutdoorToOutdoor(1, 3);
        }
        else if (collision.tag == "2To1")
        {
            ChangeSceneManager.ChangeArea_OutdoorToOutdoor(2, 1);
        }
        else if (collision.tag == "2To3")
        {
            ChangeSceneManager.ChangeArea_OutdoorToOutdoor(2, 3);
        }
        else if (collision.tag == "3To1")
        {
            ChangeSceneManager.ChangeArea_OutdoorToOutdoor(3, 1);
        }
        else if (collision.tag == "3To2")
        {
            ChangeSceneManager.ChangeArea_OutdoorToOutdoor(3, 2);
        }
        else if (collision.tag == "ToKos")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(1, "Kos");
        }
        else if (collision.tag == "KosToKamarKos")
        {
            ChangeSceneManager.ChangeArea_IndoorToIndoor("Kos", "KamarKos");
        }
        else if (collision.tag == "KamarKosToKos")
        {
            ChangeSceneManager.ChangeArea_IndoorToIndoor("KamarKos", "Kos");
        }
        else if (collision.tag == "1ToTempatMakan")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(1, "TempatMakan");
        }
        else if (collision.tag == "TempatMakanTo1")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("TempatMakan", 1);
        }
        else if (collision.tag == "2ToApotek")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(2, "Apotek");
        }
        else if (collision.tag == "ApotekTo2")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("Apotek", 2);
        }
    }
}
