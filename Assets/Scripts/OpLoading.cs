using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpLoading : MonoBehaviour
{
    public int a;
    public float time;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > time)
        {
            SceneManager.LoadScene(a);
        }
    }
}
