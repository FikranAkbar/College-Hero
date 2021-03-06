﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Character/Role")]
public class RoleCharacter : ScriptableObject
{
    public string type;
    public int moneyGift;
    public float multiplierFactor;
    public int healthInc;
    [TextArea] public string charDesc;
    public Sprite charImage;
}
