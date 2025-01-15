using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
 
    public void homeButton()
    {
       
            SceneManager.LoadScene("MainMenu");

 
    }
    public void backbutton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
