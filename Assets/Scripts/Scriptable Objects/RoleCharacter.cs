using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character/Role")]
public class RoleCharacter : ScriptableObject
{
    public int money;
    public float multiplierFactor;
    public float health;
    public int healthInc;
}
