using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MencobaFiturTemplate : MonoBehaviour
{

    public Text Duit;
    public Text DamageM;
    public Text HealingS;
    PlayerTemplate CStats;

    // Start is called before the first frame update
    void Start()
    {
        CStats = GameObject.Find("Player").GetComponent<PlayerStats>().CharacterStats;
    }

    // Update is called once per frame
    void Update()
    {
        Duit.text = "Duit: " + CStats.Money;
        DamageM.text = "DamageM: " + CStats.DamageMultiplier;
        HealingS.text = "HealingS: " + CStats.HealingSpeed;
    }
}
