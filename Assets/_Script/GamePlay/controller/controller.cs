using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public playerCtl playerctl;
    public UICtl uictl;
    public enemiesCtl enemiesctl;
    public audioCtl audioctl;
    private void Awake()
    {
        playerctl = GameObject.Find("playerCtl").GetComponent<playerCtl>();
        uictl = GameObject.Find("UICtl").GetComponent<UICtl>();
        enemiesctl = GameObject.Find("enemiesCtl").GetComponent<enemiesCtl>();
        audioctl = GameObject.Find("audioCtl").GetComponent<audioCtl>();
    }
    private void Start()
    {
        audioctl.playAudiobg();
        audioctl.pauseAudioMenu();
    }
    private void Update()
    {
        playerctl.playermovement.MoveAndJump();
        playerctl.playerskill.useSkill();
    }
    private void FixedUpdate()
    {
        playerctl.checkdead.checkPlayerDead();
    }
}
