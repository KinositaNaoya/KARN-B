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
                //敵に当たったらアクション
                if (collision.tag == "Enemy")
                {
                    Debug.Log("敵に攻撃");
                }

            }
        }
    }

    IEnumerator Deley() //攻撃の踏み込みをディレイさせる関数
    {
        yield return new WaitForSeconds(0.3f);

    }
}
