using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;//‚±‚±‚ÅÒÓØ‚Ì—e—Ê‚ğŠm•Û

    private void Awake()
    {

        if(instance == null)//ÒÓØ‚Ì’†g‚ª‹ó‚Á‚Û‚È‚ç©•ª‚ğ“ü‚ê‚é
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
}
