using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtl : MonoBehaviour
{
    public controller ctl;

    public modelPlayer modelplayer;
    public viewPlayer viewplayer;

    public playerMovement playermovement;
    public checkDead checkdead;
    public playerSkill playerskill;

    private void Awake()
    {
        ctl = GameObject.Find("controller").GetComponent<controller>();

        modelplayer = GameObject.Find("model").GetComponent<modelPlayer>();
        viewplayer = GameObject.Find("Player").GetComponent<viewPlayer>();

        playermovement = GetComponent<playerMovement>();
        checkdead = GetComponent<checkDead>();
        playerskill = GetComponent<playerSkill>();
    }
}
