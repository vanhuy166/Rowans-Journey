using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewTreasure : MonoBehaviour
{
    public Animator ani;
    public controller ctl;
    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();
        ani = GetComponent<Animator>();
    }
    public void dead()
    {
        ani.SetBool("dead", true);
        Destroy(gameObject,0.3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            ctl.uictl.congSkill();
            ctl.uictl.congdiem();
            ctl.audioctl.playAudioitem();
            dead();
        }
        
    }
}
