using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectUIController : MonoBehaviour
{
    public void homeButton()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void levelbutton()
    {

        int selectedLevel =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.LevelIndex = selectedLevel;
        AudioManager.Instance.StopMusic();
        AudioManager.Instance.PlayMusic("Theme1");
        
        SceneManager.LoadScene("Gameplay");
       

    }
}
