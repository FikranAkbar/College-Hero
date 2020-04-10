using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public GameObject MainmenuManager;
    public PlayerTemplate Character;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangedScene()
    {
        DontDestroyOnLoad(this);
    }

    public void GenerateCharacter(int number)
    {
        if (number == 1)
        {
            Character = new PlayerTemplate(100, 0, 10, 100, 15, "-", 0, 1, 1, 0, 0);
        } 
        else if (number == 2)
        {
            Character = new PlayerTemplate(100, 0, 50, 100, 10, "-", 0, 1, 1, 0, 0);
        }
        else if (number == 3)
        {
            Character = new PlayerTemplate(100, 0, 50, 100, 5, "-", 0, 1, 1, 0, 0);
        }
    }
}
