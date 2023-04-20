using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Myfirstscript : MonoBehaviour
{
    public Button Button1,Button2,Button3;
    public string Scene1,Scene2,Scene3;

    private void Start()
    {
        Button1.onClick.AddListener(OnButtonClick1);
        Button2.onClick.AddListener(OnButtonClick2);
        Button3.onClick.AddListener(OnButtonClick3);
    }

    private void OnButtonClick1()
    {
        Debug.Log("Button 1 Clicked");
        SceneManager.LoadScene(Scene1);
    }

    private void OnButtonClick2()
    {
        Debug.Log("Button 2 Clicked");
        SceneManager.LoadScene(Scene2);
    }

    private void OnButtonClick3()
    {
        Debug.Log("Button 3 Clicked");
        SceneManager.LoadScene(Scene3);
    }
}