using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private controller ctl;
    private void Awake()
    {
        ctl = GetComponent<controller>();
    }
    public void replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void pause()
    {
        Time.timeScale = 0f; 
        ctl.uictl.viewui.pauseGame.SetActive(true);
        ctl.audioctl.pauseAudiobg();
    }
    public void continueGame(){
        Time.timeScale = 1f; 
        ctl.uictl.viewui.pauseGame.SetActive(false);
        ctl.audioctl.playAudiobg();
    }
}
