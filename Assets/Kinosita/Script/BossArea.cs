using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArea : MonoBehaviour
{
    public bool inArea = false;//CameraHoming‚É“n‚·—p‚Ì•Ï”


    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inArea = true;
            Debug.Log("“ü‚Á‚½‚æ");

        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            inArea = false;
            Debug.Log("“ü‚Á‚Ä‚È‚¢‚æ");
        }
    }
}
