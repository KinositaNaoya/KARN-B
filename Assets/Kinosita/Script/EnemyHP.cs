using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] int HP;//敵のHP

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)//仮設置
    {
        if (collision.gameObject.name =="AttckPoint")//ん、ネームではなくTagで管理すべき。
        {
            //AttckPointから攻撃力の変数を取得して計算したい(予定)
            Debug.Log("-1");
            HP -= 1;
        }
    }
}
