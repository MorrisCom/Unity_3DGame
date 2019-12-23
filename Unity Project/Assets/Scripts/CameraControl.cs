using UnityEngine;

public class CameraControl : MonoBehaviour
{
    #region
    private Transform player;

    [Header("追蹤速度"),Range(1,10)]
    public float speed = 5;
    [Header("上方限制"),]
    public float top = -6;
    [Header("下方限制"),]
    public float bottom = 6;
    #endregion
    private void Start()
    {
        player = GameObject.Find("玩家").transform;
    }
    private void LateUpdate()       //在update之後執行
    {
        track();
    }
    /// <summary>
    /// 追蹤玩家座標方法
    /// </summary>
    private void track() 
    {
        Vector3 posPlayer = player.position; //玩家.座標
        Vector3 posCamera = transform.position; //攝影機.座標

        posPlayer.x = 0;        //x=0

        posPlayer.z = Mathf.Clamp(posPlayer.z, top, bottom);//將z軸限制住

        transform.position= Vector3.Lerp(posPlayer, posCamera, 0.5f*Time.deltaTime*speed);
    }
}
