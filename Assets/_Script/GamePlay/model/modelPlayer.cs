using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelPlayer : MonoBehaviour
{
    public float runSpeed = 10.0f;
    private float runSpeed1;
    public float jumpSpeed = 25.0f;

    public void setRunspeed(float speed)
    {
        this.runSpeed = speed;
    }
    public float getRunspeed()
    {
        return this.runSpeed; 
    }
    public float getRunspeed1()
    {
        return this.runSpeed1;
    }
    public void Awake()
    {
        setRunspeed(10f);
        runSpeed1 = runSpeed;
    }
}
