using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    [SerializeField] string Scenename;

    public void OnClick()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(Scenename);
    }
}
