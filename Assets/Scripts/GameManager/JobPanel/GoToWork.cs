using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToWork : MonoBehaviour
{
    PlayerStatus playerStatus;
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        playerStatus = FindObjectOfType<PlayerStatus>();
        button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if( playerStatus.Get_Energy() <= 10 ||
            playerStatus.Get_Energy() - JobDisplayManager.duration * 10 < 10)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
}
