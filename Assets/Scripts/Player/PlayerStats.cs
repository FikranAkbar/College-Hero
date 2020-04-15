using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private PlayerStatsTemplate Status;

    private void Start()
    {
        Status = new PlayerStatsTemplate();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(moveHorizontal, moveVertical, 0);
    }

    public void GenerateRoleCharacter(int index)
    {
        if (index == 0)
        {
            Status.CreateAnakDesa();
        }
        else if (index == 1)
        {
            Status.CreateAnakKota();
        }
        else if (index == 2)
        {
            Status.CreateAnakSultan();
        }
    }
}
