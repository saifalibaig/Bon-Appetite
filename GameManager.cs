using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField]
    private GameObject[] levelType;

    private int _levelIndex;

    public int LevelIndex
    {
        get { return _levelIndex; }
        set { _levelIndex = value; }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay")
        {
            Instantiate(levelType[LevelIndex]);
        }
        else if (scene.name == "LevelSelect")
        {
            Instantiate(levelType[LevelIndex]);
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {

        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

}
