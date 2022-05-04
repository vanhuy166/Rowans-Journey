using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesCtl : MonoBehaviour
{
    public viewEnemies viewenemies;
    private int GroundLayer, BossLayer;
    private void Awake()
    {
        viewenemies = GameObject.Find("Enemies").GetComponent<viewEnemies>();
        GroundLayer = LayerMask.NameToLayer("Ground");
        BossLayer = LayerMask.NameToLayer("Boss");
    }
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(BossLayer, GroundLayer, true);
    }
}
