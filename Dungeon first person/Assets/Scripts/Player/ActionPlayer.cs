using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ActionPlayer : MonoBehaviour
{

    private void Start()
    {}

    public void OnMenu(InputValue value)
    {
        HandleMenuButton();
    }

    private void HandleMenuButton()
    {
        if(DataPersistenceManager.instance != null)
        {
            DataPersistenceManager.instance.SaveGame();
        }
        else
        {
            Debug.LogWarning("DataPersistenceManager instance wasn't found in the scene");
        }
            
        // load the main menu scene
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
