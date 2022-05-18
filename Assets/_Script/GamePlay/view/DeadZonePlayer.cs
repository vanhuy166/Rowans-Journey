using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZonePlayer : MonoBehaviour
{
    private controller ctl;
    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dead");
        Time.timeScale = 0f;
        ctl.uictl.viewui.gameover.SetActive(true);
        ctl.playerctl.viewplayer.dead();
        ctl.uictl.viewui.setGameoverscore();
        ctl.uictl.checkBestscore();
        ctl.uictl.viewui.setBestcore();
        ctl.audioctl.pauseAudiobg();
        ctl.audioctl.playAudiogameover();
    }
}
