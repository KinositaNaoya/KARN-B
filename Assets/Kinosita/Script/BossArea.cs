using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArea : MonoBehaviour
{
    public bool inArea = false;//CameraHomingに渡す用の変数


    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inArea = true;
            Debug.Log("入ったよ");

        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            inArea = false;
            Debug.Log("入ってないよ");
        }
    }
}
