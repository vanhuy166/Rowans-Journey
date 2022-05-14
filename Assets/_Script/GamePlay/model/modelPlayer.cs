using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelPlayer : MonoBehaviour
{
    public float runSpeed = 10.0f;
    public float jumpSpeed = 22.0f;

    public void setRunspeed(float speed)
    {
        this.runSpeed = speed;
    }
    public float getRunspeed()
    {
        return this.runSpeed; 
    }
}
