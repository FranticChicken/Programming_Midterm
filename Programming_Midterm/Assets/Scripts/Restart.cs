using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Restart : MonoBehaviour
{
    Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        restartButton = transform.Find("Button").GetComponent<Button>();

        restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    void OnRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
