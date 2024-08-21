using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ukabuzimen : MonoBehaviour
{




    BoxCollider2D Box2D;

    //ƒNƒŠƒbƒN‚µ‚½‰ñ”‚ğ•Û‘¶‚·‚é‚ÌŠÖ”
    double Clicktimer;

    double Clickcooltime=0.25;



    // Start is called before the first frame update
    void Start()
    {
        Box2D = GetComponent<BoxCollider2D>();
        //ŠÔ‚ğ‰Šú‰»
        Clicktimer = Time.time;
    }

    // Update is called once per frame



    //S‚ğ2‰ñ‰Ÿ‚µ‚½‚ÉisTrgger‚ğtrue‚É‚µ‚Ä“–‚½‚è”»’è‚ğÁ¸‚³‚¹‚é
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
        Debug.Log("‚·‚è”²‚¯‚½");
    }
}
