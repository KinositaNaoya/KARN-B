using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArea : MonoBehaviour
{
    public bool inArea = false;//CameraHoming�ɓn���p�̕ϐ�


    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inArea = true;
            Debug.Log("��������");

        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            inArea = false;
            Debug.Log("�����ĂȂ���");
        }
    }
}
