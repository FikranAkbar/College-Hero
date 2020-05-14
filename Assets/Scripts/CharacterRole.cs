using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRole : MonoBehaviour
{

    bool roleAssigned = false;

    RoleCharacter role;

    private void Awake()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(this);
        } 
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (roleAssigned)
        {
            Debug.Log("Health Inc: " + role.healthInc);
            Debug.Log("Money: " + role.moneyGift);
            Debug.Log("Multiplier Factor: " + role.multiplierFactor);
        }
    }

    public void AssignRole(RoleCharacter role)
    {
        this.role = role;
        roleAssigned = true;
    }

    public void ClearRole()
    {
        Destroy(this);
    }
}
