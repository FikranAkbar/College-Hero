using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBtn : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("MainmenuManager").GetComponent<MainmenuManager>().ChangeCharacter_Left();
    }

    private void OnMouseUpAsButton()
    {
        GameObject.Find("MainmenuManager").GetComponent<MainmenuManager>().ChangeCharacter_Left();
    }
}
