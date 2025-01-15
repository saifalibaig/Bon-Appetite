using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update

    public void PlayGame()
    {
        int selectedGameType = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        if (selectedGameType == 0)
        {
            AudioManager.Instance.PlayMusic("Theme1");

            SceneManager.LoadScene("Gameplay");
        }
        else if ( selectedGameType == 1)
        {
            SceneManager.LoadScene("LevelSelect");

        }
    }
   
}
