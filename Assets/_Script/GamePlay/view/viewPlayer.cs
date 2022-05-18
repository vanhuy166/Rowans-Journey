using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewPlayer : MonoBehaviour
{
    public Rigidbody2D rig;
    private BoxCollider2D box;
    private Animator animator;
    private GameObject khoi;
    private controller ctl;
    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();
        rig = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        khoi = GameObject.Find("khoi");
    }
    public void run()
    {
        animator.SetBool("jump", false);
        animator.SetBool("skill", false);
        khoi.SetActive(true);
    }
    public void jump()
    {
        animator.SetBool("jump", true);
        animator.SetBool("skill", false);
        khoi.SetActive(false);
    }
    public void dead()
    {
        animator.SetBool("jump", false);
        animator.SetBool("skill", false);
        animator.SetBool("dead", true);
        animator.SetBool("hurt", false);
        khoi.SetActive(false);
    }
    public void skill()
    {
        animator.SetBool("skill", true);
    }
    public void hurt()
    {
        animator.SetBool("jump", false);
        animator.SetBool("skill", false);
        animator.SetBool("hurt", true);
        khoi.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Barrier" && ctl.playerctl.modelplayer.getRunspeed() < ctl.playerctl.modelplayer.getRunspeed1())
        {
            StartCoroutine("collisionBarrier");
        }
        else if (collision.gameObject.name == "Trap" && ctl.playerctl.modelplayer.getRunspeed() < ctl.playerctl.modelplayer.getRunspeed1())
        {
            StartCoroutine("collisionTrap");
        }

    }

    IEnumerator collisionBarrier()
    {
        hurt();
        ctl.audioctl.playAudiohurt();
        yield return new WaitForSeconds(0.25f);
        animator.SetBool("hurt", false);
        khoi.SetActive(true);
    }
    IEnumerator collisionTrap()
    {
        hurt();
        ctl.audioctl.playAudiohurt();
        yield return new WaitForSeconds(0.25f);
        animator.SetBool("hurt", false);
        khoi.SetActive(true);
    }
}
