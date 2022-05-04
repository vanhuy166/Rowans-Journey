using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private playerCtl playerctl;

    private float jumpspeed;
    private float runspeed;
    private Rigidbody2D rig;

    private int PlayerLayer, GroundLayer;
    private bool jumpOffCoroutineRunning = false;
    private bool clickjump = true;
    private void Awake()
    {
        playerctl = GetComponent<playerCtl>();
    }
    private void Start()
    {
       jumpspeed = playerctl.modelplayer.jumpSpeed;
       rig = playerctl.viewplayer.rig;
       PlayerLayer = LayerMask.NameToLayer("Player");
       GroundLayer = LayerMask.NameToLayer("Ground");
    }
    public void MoveAndJump()
    {
        PlayerMove();
        playerJump();
    }
    void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)/*&& Mathf.Abs(rig.velocity.y) <= 0.5f*/&& clickjump==true)
        {
            rig.AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
            StartCoroutine("isClickjump");
            playerctl.viewplayer.jump();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine("JumpOff");  // xử lý sự kiện nhảy xuống
        }

        //kiểm tra nhảy lên
        if (rig.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, true);
        }
        //nhảy xuống dưới
        else if (rig.velocity.y <= 0 && !jumpOffCoroutineRunning)
        {
            Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, false);
        }

    }
    IEnumerator JumpOff()
    {
        jumpOffCoroutineRunning = true;
        Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, true);
        yield return new WaitForSeconds(0.25f);
        Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, false);
        jumpOffCoroutineRunning = false;
    }
    IEnumerator isClickjump()
    {
        clickjump = false;
        yield return new WaitForSeconds(0.7f);
        clickjump = true;
    }
    void PlayerMove()
    {
        if (Mathf.Abs(rig.velocity.y) <= 0.1f && playerctl.modelplayer.getRunspeed()<=11.0f && playerctl.modelplayer.getRunspeed() > 0.0f)
        {
            playerctl.viewplayer.run();
        }
        //playerctl.viewplayer.gameObject.transform.Translate(new Vector2(playerctl.modelplayer.getRunspeed(), 0));
        playerctl.viewplayer.gameObject.transform.position += new Vector3(1, 0, 0) * playerctl.modelplayer.getRunspeed() * Time.deltaTime;
    }
    
}
