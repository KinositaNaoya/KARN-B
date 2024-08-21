using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] int HP;//“G‚ÌHP

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)//‰¼Ý’u
    {
        if (collision.gameObject.name =="AttckPoint")//‚ñAƒl[ƒ€‚Å‚Í‚È‚­Tag‚ÅŠÇ—‚·‚×‚«B
        {
            //AttckPoint‚©‚çUŒ‚—Í‚Ì•Ï”‚ðŽæ“¾‚µ‚ÄŒvŽZ‚µ‚½‚¢(—\’è)
            Debug.Log("-1");
            HP -= 1;
        }
    }
}
