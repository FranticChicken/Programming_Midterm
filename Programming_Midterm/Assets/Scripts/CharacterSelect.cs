using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    Button char1Button;

    Button char2Button;

    bool jumpEnabled;
    float playerSpeed;
    Canvas inGameUI;

    // Start is called before the first frame update
    void Start()
    {
        char1Button = transform.Find("CharOneButton").GetComponent<Button>();
        char2Button = transform.Find("CharTwoButton").GetComponent<Button>();

        char1Button.onClick.AddListener(OnChar1ButtonClick);

        char2Button.onClick.AddListener(OnChar2ButtonClick);

        //inGameUI = transform.Find("Game Canvas").GetComponentInParent
    }

    void OnChar1ButtonClick()
    {
        playerSpeed = 5;
        jumpEnabled = true;
        gameObject.SetActive(false);

    }

    void OnChar2ButtonClick()
    {
        playerSpeed = 10;
        jumpEnabled = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
