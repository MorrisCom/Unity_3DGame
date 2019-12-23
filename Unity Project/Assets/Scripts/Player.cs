using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Joystick joystick;
    private Rigidbody rig;
    private Animator ani;
    private Transform target;
    [Header("移動速度"),Range(1,300)]
    public float speed = 15;
    private void Start()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
        joystick = GameObject.Find("虛擬搖桿").GetComponent<Joystick>();
        target = GameObject.Find("目標").transform;
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
        ani.SetBool("跑步開關",h != 0 || v != 0);
        Vector3 PosPlayer = transform.position;  //玩家,座標
        Vector3 PosTarget = new Vector3(PosPlayer.x - h, 0.26f, PosPlayer.z -v);
        //print(PosTarget);
        target.position = PosTarget;  //目標.座標=計算後的座標

        PosTarget.y = PosPlayer.y;

        transform.LookAt(PosTarget);

    }
}
