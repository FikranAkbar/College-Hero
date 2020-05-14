using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCanvas : MonoBehaviour
{
    private void Awake()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ClearHUD()
    {
        Destroy(gameObject);
    }
}
