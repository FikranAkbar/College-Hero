using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBtn : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("MainmenuManager").GetComponent<MainmenuManager>().ChangeCharacter_Right();
    }

    private void OnMouseUpAsButton()
    {
        GameObject.Find("MainmenuManager").GetComponent<MainmenuManager>().ChangeCharacter_Right();
    }
}
