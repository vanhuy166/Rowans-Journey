using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerMenu : MonoBehaviour
{
    public GameObject MenuGame;
    public GameObject introduceGuideGame;
    public GameObject moveGuideGame;
    public GameObject skillGuideGame;

    public void Awake()
    {
        StartMenuGame();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }
    public void StartMenuGame()
    {
        MenuGame.SetActive(true);
        introduceGuideGame.SetActive(false);
        moveGuideGame.SetActive(false);
        skillGuideGame.SetActive(false);
    }

    public void StartIntroduceGuideGame()
    {
        MenuGame.SetActive(false);
        introduceGuideGame.SetActive(true);
        moveGuideGame.SetActive(false);
        skillGuideGame.SetActive(false);
        
    }

    public void StartMoveGuideGame()
    {
        MenuGame.SetActive(false);
        introduceGuideGame.SetActive(false);
        moveGuideGame.SetActive(true);
        skillGuideGame.SetActive(false);
    }

    public void StartSkillGuideGame()
    {
        MenuGame.SetActive(false);
        introduceGuideGame.SetActive(false);
        moveGuideGame.SetActive(false);
        skillGuideGame.SetActive(true);
    }


    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
  
}
