using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private Vector3 offset;
    [SerializeField] [Range(0.1f,1f)]
    private float smoothSpeed = 0.125f;
    private Vector3 velocity = Vector3.zero;
    private void Update()
    {
        Vector3 target = new Vector3(Player.position.x, 0, transform.position.z);
        Vector3 desiredPosition = target + offset;
        //Debug.Log(offset);
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity,smoothSpeed);
    }
  
}
