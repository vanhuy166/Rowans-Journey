using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkill : MonoBehaviour
{
    private playerCtl playerctl;
    public modelPlayer modelplayer;

    private float runSpeed;

    private void Awake()
    {
        modelplayer = GameObject.Find("model").GetComponent<modelPlayer>();
        playerctl = GetComponent<playerCtl>();
        runSpeed = modelplayer.runSpeed;
        //Debug.Log(runSpeed);
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
