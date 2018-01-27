using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    public Button yourButton;

    // Use this for initialization
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);

    }

    void OnClick()
    {
        if (name == "Start")
        {
            SceneManager.LoadScene("juuso_test");
        }

        else if (name == "Credits")
        {
            SceneManager.LoadScene("Credits");
        }

        else if (name == "Exit")
        {
            Application.Quit();
        }

        else if (name == "Back")
        {
            SceneManager.LoadScene("Titles");
        }
    }
}
