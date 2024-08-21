using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttckPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Enemy")
        {
            Debug.Log("");
        }
    }
}
