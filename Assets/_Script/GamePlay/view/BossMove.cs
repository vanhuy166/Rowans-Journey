using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float speed;
    private controller ctl;
    private Animator ani;
    private SpriteRenderer boss;

    public float lengthBoss;
    private float length = 0f;
    private Vector3 deltaLength;

    // Start is called before the first frame update
    void Start()
    {
        length = lengthBoss;
        ctl = GameObject.Find("controller").GetComponent<controller>();
        boss = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
        deltaLength = new Vector3(0.005f*speed, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (ctl.playerctl.modelplayer.getRunspeed()>0)
        {
            if (length <= 0)
            {
                length = lengthBoss;
                boss.flipX = !boss.flipX;
            }

            if (boss.flipX)
            {
                transform.position = transform.position + deltaLength;
            }
            else
            {
                transform.position = transform.position - deltaLength;
            }

            length = length - deltaLength.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && ctl.playerctl.modelplayer.getRunspeed() > ctl.playerctl.modelplayer.getRunspeed1())
        {
            ani.SetBool("killBoss", true);
            Destroy(gameObject, 0.2f);
            ctl.audioctl.playAudiobreak();
        }
        else if (collision.gameObject.name == "Player")
        {
            Time.timeScale = 0f;
            ctl.playerctl.modelplayer.setRunspeed(0.0f);
            ctl.uictl.viewui.gameover.SetActive(true);
            ctl.playerctl.viewplayer.dead();
            ctl.uictl.viewui.setGameoverscore();
            ctl.uictl.checkBestscore();
            ctl.uictl.viewui.setBestcore();
            ctl.audioctl.pauseAudiobg();
            ctl.audioctl.playAudiogameover();
        }

    }

}
