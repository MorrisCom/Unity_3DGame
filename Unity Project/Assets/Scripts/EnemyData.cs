using UnityEngine;
// 腳本化物件  ScriptableObject:將此腳本的資料存為物件並放在project
[CreateAssetMenu(fileName ="怪物資料",menuName ="Morris/Monster")]
public class EnemyData : ScriptableObject
{
    [Header("血量"),Range(10,3000)]
    public float hp;
    [Header("攻擊力"), Range(0, 1000)]
    public float attack;
    [Header("攻擊冷卻時間"), Range(0, 100)]
    public float cd;
    [Header("移動速度"), Range(5, 250)]
    public float speed;
}
