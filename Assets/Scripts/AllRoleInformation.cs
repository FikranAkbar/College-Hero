using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllRoleInformation : MonoBehaviour
{
    [Header("Roles")]
    [SerializeField] List<RoleCharacter> roles;
    int currentRoleIndex = 1;

    [Header("UI Display")]
    [SerializeField] Text roleText;
    [SerializeField] Image roleImage;
    [SerializeField] Text roleDescription;

    CharacterRole role;
    // Start is called before the first frame update
    void Start()
    {
        role = FindObjectOfType<CharacterRole>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowRoleInformation();
    }

    private void ShowRoleInformation()
    {
        roleText.text = roles[currentRoleIndex].type;
        roleDescription.text = roles[currentRoleIndex].charDesc;
        roleImage.sprite = roles[currentRoleIndex].charImage;
    }

    public void RightButton()
    {
        currentRoleIndex++;
        if(currentRoleIndex > 2)
        {
            currentRoleIndex = 0;
        }
    }

    public void LeftButton()
    {
        currentRoleIndex--;
        if (currentRoleIndex < 0)
        {
            currentRoleIndex = 2;
        }
    }

    public void GoToGameScene()
    {
        role.AssignRole(roles[currentRoleIndex]);
    }
}
