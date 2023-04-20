using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backmenuscript : MonoBehaviour
{
    public Button Backbutton;
    public string Master;
    // Start is called before the first frame update
    void Start()
    {
        Backbutton.onClick.AddListener(OnButtonClick1);
    }

    private void OnButtonClick1()
    {
        Debug.Log("Back Button Clicked");
        SceneManager.LoadScene(Master);
    }

}

