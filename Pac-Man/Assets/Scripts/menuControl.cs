using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuControl : MonoBehaviour
{
    public void ChangeScene(string scene)
    {
        if (scene == "quit")
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu1");
        }
    }

}
