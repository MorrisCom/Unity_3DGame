using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Joystick joystick;
    private Rigidbody rig;

    public float speed = 15;
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        joystick = GameObject.Find("虛擬搖桿").GetComponent<Joystick>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        float h = joystick.Horizontal;     //水平
        float v = joystick.Vertical;       //垂直 
        rig.AddForce(-h*speed, 0, -v*speed);
    }
}
