using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
        #region Change: Outdoor To Outdoor
        // Change Outdoor To Outdoor
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
        #endregion

        #region Change: Outdoor To Indoor
        // Change Outdoor To Indoor
        else if (collision.tag == "ToKos")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(1, "Kos");
        }
        else if (collision.tag == "1ToTempatMakan_AreaKota")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(1, "TempatMakan");
        }
        else if (collision.tag == "2ToApotek")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(2, "Apotek");
        }
        else if (collision.tag == "2ToTempatMakan_AreaTaman")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(2, "TempatMakan");
        }
        else if (collision.tag == "2ToMinimarket_AreaTaman")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(2, "Minimarket");
        }
        else if (collision.tag == "3ToTempatMakan_AreaUniversitas")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(3, "TempatMakan");
        }
        else if (collision.tag == "3ToMinimarket_AreaUniversitas")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(3, "Minimarket");
        }
        #endregion

        #region Change: Indoor To Outdoor
        // Change Indoor To Outdoor
        else if (collision.tag == "KosTo1")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("Kos", 1);
        }
        else if (collision.tag == "TempatMakanTo1_AreaKota")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("TempatMakan", 1);
        }
        else if (collision.tag == "ApotekTo2")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("Apotek", 2);
        }
        else if (collision.tag == "TempatMakanTo2_AreaTaman")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("TempatMakan", 2);
        }
        else if (collision.tag == "MinimarketTo2_AreaTaman")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("Minimarket", 2);
        }
        else if (collision.tag == "TempatMakanTo3_AreaUniversitas")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("TempatMakan", 3);
        }
        else if (collision.tag == "MinimarketTo3_AreaUniversitas")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("Minimarket", 3);
        }
        else if (collision.tag == "3ToUniversitas")
        {
            ChangeSceneManager.ChangeArea_OutdoorToIndoor(3, "Universitas");

        }
        else if (collision.tag == "UniversitasTo3")
        {
            ChangeSceneManager.ChangeArea_IndoorToOutdoor("Universitas", 3);
        }
        #endregion

        #region Change: Indoor To Indoor
        // Change Indoor To Indoor
        else if (collision.tag == "KosToKamarKos")
        {
            ChangeSceneManager.ChangeArea_IndoorToIndoor("Kos", "KamarKos");
        }
        else if (collision.tag == "KamarKosToKos")
        {
            ChangeSceneManager.ChangeArea_IndoorToIndoor("KamarKos", "Kos");
        }
        #endregion
    }
}
