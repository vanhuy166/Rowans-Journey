using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDead : MonoBehaviour
{
    private playerCtl playerctl;
    private bool dead = false;
    private void Awake()
    {
        playerctl = GetComponent<playerCtl>();

    }
    public void checkPlayerDead()
    {
        if (playerctl.ctl.enemiesctl.viewenemies.eatPlayer==true)
        {
            isDead();
            dead = true;
        }
    }
    public void isDead()
    {
        if (dead == true) return;
        playerctl.modelplayer.setRunspeed(0.0f);
        playerctl.modelplayer.jumpSpeed = 0.0f;
        playerctl.viewplayer.dead();
        playerctl.ctl.uictl.viewui.gameover.SetActive(true);
        playerctl.ctl.uictl.viewui.TitleGame.text = "GAME OVER!!!";
        playerctl.ctl.uictl.viewui.setGameoverscore();
        playerctl.ctl.uictl.checkBestscore();
        playerctl.ctl.uictl.viewui.setBestcore();
        playerctl.ctl.audioctl.pauseAudiobg();
        playerctl.ctl.audioctl.playAudiogameover();
        Debug.Log("dead");
    }
}
