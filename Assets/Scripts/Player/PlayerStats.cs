using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private PlayerStatsTemplate Status;
    
    [SerializeField] List<RoleCharacter> RoleCharacters;

    [SerializeField] private float speed;

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

        transform.Translate(
            Mathf.Clamp(moveHorizontal * speed, -1, 1), 
            Mathf.Clamp(moveVertical * speed, -1, 1), 
            0);
    }

    public void GenerateRoleCharacter(int index)
    {
        Status.moneyGift = RoleCharacters[index].moneyGift;
        Status.healingSpeed = RoleCharacters[index].healthInc;
        Status.damageMultiplier = RoleCharacters[index].multiplierFactor;
        GetComponent<SpriteRenderer>().sprite = RoleCharacters[index].charImage;
    }

    private void OnDestroy()
    {
        DontDestroyOnLoad(gameObject);
    }
}
