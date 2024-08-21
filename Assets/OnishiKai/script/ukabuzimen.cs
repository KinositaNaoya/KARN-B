using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ukabuzimen : MonoBehaviour
{




    BoxCollider2D Box2D;

    //クリックした回数を保存するの関数
    double Clicktimer;

    double Clickcooltime=0.25;



    // Start is called before the first frame update
    void Start()
    {
        Box2D = GetComponent<BoxCollider2D>();
        //時間を初期化
        Clicktimer = Time.time;
    }

    // Update is called once per frame



    //Sを2回押した時にisTrggerをtrueにして当たり判定を消失させる
    void Update()
    {
        if(!Box2D.isTrigger&& Input.GetKeyDown(KeyCode.S))
        {
            double interval = Clicktimer - Clickcooltime;

            if(interval<Clickcooltime)
            {

                Box2D.isTrigger = true;


            }
            Clicktimer = Time.time;
        }


      
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Box2D.isTrigger = false;
        Debug.Log("すり抜けた");
    }
}
