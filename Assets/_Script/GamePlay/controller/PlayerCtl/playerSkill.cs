using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkill : MonoBehaviour
{
    private playerCtl playerctl;
    private void Awake()
    {
        playerctl = GetComponent<playerCtl>();
    }

    public void useSkill()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && playerctl.ctl.uictl.viewui.skill.value == 1)
        {
            playerctl.ctl.audioctl.playAudioskill();
            StartCoroutine("delaySkill");
        }
    }
    IEnumerator delaySkill()
    {
        playerctl.modelplayer.setRunspeed(40.0f);
        playerctl.viewplayer.skill();
        playerctl.ctl.uictl.viewui.skill.value = 0;
        playerctl.ctl.uictl.viewui.setColor();
        yield return new WaitForSeconds(0.3f);
        playerctl.modelplayer.setRunspeed(10.0f);
    }
}
