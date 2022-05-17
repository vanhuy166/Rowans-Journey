using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private playerCtl playerctl;

    private float jumpspeed;
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
        if ((Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.Space)) && clickjump==true)
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
            Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, true); /*Bỏ qua va chạm giữa nhân vật và bậc*/
        }
        //nhảy xuống dưới
        else if (rig.velocity.y <= 0 && !jumpOffCoroutineRunning)
        {
            Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, false);
        }

    }
    IEnumerator JumpOff()
    {
        /*kiểm tra và bỏ qua va chạm giữa nhân vật và bậc*/
        jumpOffCoroutineRunning = true;
        Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, true); 
        yield return new WaitForSeconds(0.25f);
        Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, false);
        jumpOffCoroutineRunning = false;
    }
    IEnumerator isClickjump()
    {
        clickjump = false;
        yield return new WaitForSeconds(0.7f); /*khoảng thời gian giữa 2 lần nhảy*/
        clickjump = true;
    }
    void PlayerMove()
    {
        if (Mathf.Abs(rig.velocity.y) <= 0.1f && playerctl.modelplayer.getRunspeed()<= (playerctl.modelplayer.runSpeed+1.0f) && playerctl.modelplayer.getRunspeed() > 0.0f)
        {
            playerctl.viewplayer.run();
        }
        playerctl.viewplayer.gameObject.transform.position += new Vector3(1, 0, 0) * playerctl.modelplayer.getRunspeed() * Time.deltaTime;
    }
    
}
