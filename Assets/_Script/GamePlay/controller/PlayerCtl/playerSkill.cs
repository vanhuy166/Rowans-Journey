using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkill : MonoBehaviour
{
    private playerCtl playerctl;

    private float runSpeed;

    private void Awake()
    {
        playerctl = GetComponent<playerCtl>();
        runSpeed = playerctl.modelplayer.runSpeed;
    }

    public void useSkill()
    {
        /*Kiểm tra thanh năng lượng đầy*/
        if (Input.GetKeyDown(KeyCode.RightArrow) && playerctl.ctl.uictl.viewui.skill.value == 1)
        {
            playerctl.ctl.audioctl.playAudioskill();
            StartCoroutine("delaySkill");
        }
    }
    IEnumerator delaySkill()
    {
        playerctl.modelplayer.setRunspeed(4* runSpeed); /*Tăng tốc tức thì cho nhân vật*/
        playerctl.viewplayer.skill();
        playerctl.ctl.uictl.viewui.skill.value = 0;
        playerctl.ctl.uictl.viewui.setColor();
        yield return new WaitForSeconds(0.3f);
        playerctl.modelplayer.setRunspeed(runSpeed);/*Trả lại tốc độ ban đầu cho nhân vật*/
    }
}
