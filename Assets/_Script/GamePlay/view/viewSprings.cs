using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewSprings : MonoBehaviour
{
    public Animator ani;
    private void Awake()
    {
        ani = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ani.SetBool("nay", true);
    }
}
