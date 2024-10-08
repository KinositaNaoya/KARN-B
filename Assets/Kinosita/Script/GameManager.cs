using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;//ここでﾒﾓﾘの容量を確保

    private void Awake()
    {

        if(instance == null)//ﾒﾓﾘの中身が空っぽなら自分を入れる
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
