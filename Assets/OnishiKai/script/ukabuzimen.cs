using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ukabuzimen : MonoBehaviour
{




    CircleCollider2D Ccol;

    //ƒNƒŠƒbƒN‚µ‚½‰ñ”‚ğ•Û‘¶‚·‚é‚ÌŠÖ”
    double Clicktimer;

    double Clickcooltime=0.25;



    // Start is called before the first frame update
    void Start()
    {
        Ccol = GetComponent<CircleCollider2D>();
        //ŠÔ‚ğ‰Šú‰»
        Clicktimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Ccol.isTrigger&& Input.GetKeyDown(KeyCode.S))
        {
            double interval = Clicktimer - Clickcooltime;

            if(interval<Clickcooltime)
            {

                Ccol.isTrigger = true;


            }
            Clicktimer = Time.time;
        }


        void OnTriggerExit2D(Collider2D collision)
        {
            Ccol.isTrigger = false;
        }
    }
}
