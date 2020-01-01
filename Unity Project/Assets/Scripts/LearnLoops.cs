using UnityEngine;

public class LearnLoops : MonoBehaviour
{
    public string[] names = { "kid", "peter", "tom" };
    public GameObject[] player;
    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        if (true)
        {

        }
        int count = 0;
        //while迴圈
        //while(布林值){敘述}
        //條件成立時執行持續執行
        while (count<5)
        {
            count++;
            print("while迴圈執行" + count);
        }
        //for迴圈
        //(初始值;條件;跌代器)
        for (int number = 0; number <10; number++)
        {
            print("for迴圈執行" + number);
        }
        for (int number = 0; number < names.Length; number++)
        {
            print(names[number]);
        }
    }

}
