using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Morris
{
    public class RandomSkill : MonoBehaviour
    {
        
        public Sprite[] SpriteBlurry;     //陣列 模糊 16
        public Sprite[] SpriteSkill;      //陣型 正常 8
        public string[] nameskill = {"連續射擊","正向箭", "背向箭", "側向箭", "生命增加", "攻擊增加", "攻速增加", "爆擊增加" };


        [Header("捲動速度"), Range(0.01f, 1f)]
        public float speed = 0.02f;
        [Header("圖片模糊捲動次數"), Range(1, 30)]
        public int count = 6;

        private Image Imgskill;
        private AudioSource aud;        //喇叭元件
        private Button btn;
        private Text textname;
        private GameObject skillpanel;  //取得遊戲物件
        private int index;

        public AudioClip audscroll;     //捲動音效
        public AudioClip audskill;      //技能音效
        private void Start()
        {
            skillpanel = GameObject.Find("隨機技能");
            textname = transform.GetChild(0).GetComponent<Text>(); //變形.取得子物件(編號).取得元件<>
            btn = GetComponent<Button>();
            Imgskill = GetComponent<Image>();
            aud = GetComponent<AudioSource>();
            StartCoroutine(RandomEffect());
            btn.onClick.AddListener(ChooseSkill);
        }
        //連續變更圖片1-16 捲動效果
        private IEnumerator RandomEffect() 
        {
            btn.interactable = false;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < SpriteBlurry.Length; i++)
                {
                    aud.PlayOneShot(audscroll,0.5f);
                    Imgskill.sprite = SpriteBlurry[i];
                    yield return new WaitForSeconds(speed);
                }
            }
            // 捲動結束後
            btn.interactable = true;
            index = Random.Range(0, SpriteSkill.Length);  //隨機選一張技能1-8張
            Imgskill.sprite = SpriteSkill[index];         //sprite是面板上image的意思
            aud.PlayOneShot(audskill, 0.5f);
            textname.text = nameskill[index];                 //文字=技能名稱[隨機值]  
            
        }
        private void ChooseSkill() 
        {
            skillpanel.SetActive(false);  //面板隱藏
            print(nameskill[index]);      //儲存技能名稱  
        }


       

    }

}
