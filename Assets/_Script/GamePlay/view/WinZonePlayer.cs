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
        ctl.uictl.viewui.winGame.SetActive(true);
        ctl.uictl.viewui.setWinGameScore();
        ctl.uictl.checkBestscore();
        ctl.uictl.viewui.setBestcoreWin();
        ctl.audioctl.pauseAudiobg();
        ctl.audioctl.playAudiowingame();
    }
}

