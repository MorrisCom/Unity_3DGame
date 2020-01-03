using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    [Header("物件:光照與隨機技能")]
    public GameObject Objlight;
    public GameObject RandomSkill;
    [Header("是否自動顯示隨機技能")]
    public bool autoshowskill;
    [Header("是否自動開門")]
    public bool autoopendoor;

    private Image imgcross;


    private Animator door;

    private void Start()
    {
        imgcross = GameObject.Find("轉場效果").GetComponent<Image>();
        door = GameObject.Find("木頭門").GetComponent<Animator>();
        if (autoshowskill) Showskill();
        if (autoopendoor) Invoke("OpenDoor",1);

    }

    private void Showskill()
    {
        RandomSkill.SetActive(true);
    }

    private void OpenDoor()
    {
        Objlight.SetActive(true);
        door.SetTrigger("開門觸發");
    }

    public IEnumerator Nextlevel()
    {
        for (int i = 0; i < 255; i++)
        {
            imgcross.color += new Color(1, 1, 1, 0.01f);
            yield return new WaitForSeconds(0.01f);
        }
        //print("進入下一關");
       
    }

}
