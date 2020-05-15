using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterRole : MonoBehaviour
{

    string namePlayer;
    bool roleAssigned = false;
    RoleCharacter role;

    [SerializeField] InputField nameInput;


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
        namePlayer = nameInput.text;
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

    public RoleCharacter GetRoleStatus()
    {
        return role;
    }

    public string AssignName()
    {
        return namePlayer;
    }
}
