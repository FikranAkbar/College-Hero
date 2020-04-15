using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainmenuManager : MonoBehaviour
{

    [SerializeField] List<RoleCharacter> roleCharacters;
    int indexChooseRole = 1;

    [SerializeField] Image charImage;
    [SerializeField] TextMeshProUGUI charDesc;

    [SerializeField] GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowCharProfile();
    }

    public void ChangeCharacter_Right()
    {
        indexChooseRole += 1;
        if(indexChooseRole > 2)
        {
            indexChooseRole = 0;
        }
        ShowCharProfile();
    }

    public void ChangeCharacter_Left()
    {
        indexChooseRole -= 1;
        if(indexChooseRole < 0)
        {
            indexChooseRole = 2;
        }
        ShowCharProfile();
    }

    public void ShowCharProfile()
    {
        charImage.sprite = roleCharacters[indexChooseRole].charImage;
        charDesc.text = roleCharacters[indexChooseRole].charDesc;
    }

    public void Click_StartButton()
    {
        Player.GetComponent<PlayerStats>().GenerateRoleCharacter(indexChooseRole);
        Player.transform.position = new Vector2(0, 0);
        DontDestroyOnLoad(Player);
        SceneManager.LoadScene("Perkuliahan");
    }
}
