using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
        Cursor.visible = true;
    }
}
