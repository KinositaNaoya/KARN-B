using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttckManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            void OnTriggerEnter2D(Collider2D collision)
            {
                //�G�ɓ���������A�N�V����
                if (collision.tag == "Enemy")
                {
                    Debug.Log("�G�ɍU��");
                }

            }
        }
    }

    IEnumerator Deley() //�U���̓��ݍ��݂��f�B���C������֐�
    {
        yield return new WaitForSeconds(0.3f);

    }
}
