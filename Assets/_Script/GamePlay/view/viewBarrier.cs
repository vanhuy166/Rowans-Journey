using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewBarrier : MonoBehaviour
{
    private controller ctl;
    private Animator ani;


    private float runSpeed;

    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();
        ani = GetComponent<Animator>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        runSpeed = ctl.playerctl.modelplayer.runSpeed;
        if (collision.gameObject.name == "Player"&& ctl.playerctl.modelplayer.getRunspeed() <= ctl.playerctl.modelplayer.getRunspeed1() )
        {
            runSpeed--;
            Debug.Log(runSpeed);
            ctl.playerctl.modelplayer.setRunspeed(runSpeed);
        }
        else if (collision.gameObject.name == "Player" && ctl.playerctl.modelplayer.getRunspeed() > ctl.playerctl.modelplayer.getRunspeed1())
        {
            ani.SetBool("breakBarrier", true);
            Destroy(gameObject,0.4f);
            ctl.audioctl.playAudiobreak();
        }
    }
}
