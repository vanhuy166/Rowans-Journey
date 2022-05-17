using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZonePlayer : MonoBehaviour
{
    private controller ctl;
    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Win");
        Time.timeScale = 0f;
        ctl.uictl.viewui.gameover.SetActive(true);
        ctl.uictl.viewui.TitleGame.text = "YOU WIN!!!";
        ctl.uictl.viewui.setGameoverscore();
        ctl.uictl.checkBestscore();
        ctl.uictl.viewui.setBestcore();
        ctl.audioctl.pauseAudiobg();
        ctl.audioctl.playAudiowingame();
    }
}

