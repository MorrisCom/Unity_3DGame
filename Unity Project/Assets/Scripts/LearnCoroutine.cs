using System.Collections; //引用 系統 集合 API
using UnityEngine;

public class LearnCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test()); //啟動協呈(協呈名稱());
    }
    private IEnumerator Test() 
    {
        print("遊戲開始");
        yield return new WaitForSeconds(3); //等待(秒數)
        print("三秒過後");

    }
    public Transform knight;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(big());
        }
    }
    private IEnumerator big()
    {
        for (int i = 0; i < 10; i++)
        {
            knight.localScale += Vector3.one ;
            yield return new WaitForSeconds(0.1f);
        }
        
    }

}
