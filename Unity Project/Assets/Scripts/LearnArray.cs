using UnityEngine;

public class LearnArray : MonoBehaviour
{
    public int pA = 10;
    public int pB = 20;
    public int pC = 30;
    //類型、陣列
    public int[] players;
    public float[] speeds;
    public bool[] missions;
    public Color[] colors;

    //指定預設
    public string[] names = new string[5];
    public string[] animals = { "dog", "cat", "monkey" };//起始是0開始
    //陣列資料 陣列名稱[索引值]

    private void Start()
    {
        print(animals[1]);

        print(animals.Length);
    }
}
