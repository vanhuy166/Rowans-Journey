using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewBarrier : MonoBehaviour
{
    private controller ctl;
    private Animator ani;
    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();
        ani = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && ctl.playerctl.modelplayer.getRunspeed()==10.0f)
        {
            ctl.playerctl.modelplayer.setRunspeed(0.0f);
            ctl.uictl.viewui.skill.value = 0.0f;
            ctl.playerctl.viewplayer.hurt();
            ctl.audioctl.playAudiohurt();
        }else if (collision.gameObject.name == "Player" && ctl.playerctl.modelplayer.getRunspeed() > 10.0f)
        {
            ani.SetBool("dead", true);
            Destroy(gameObject,0.4f);
            ctl.audioctl.playAudiobreak();
        }

    }
}
