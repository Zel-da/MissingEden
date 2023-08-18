using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeNextScene : MonoBehaviour
{
    [SerializeField]
    private GameObject A;

    float i = 0;

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;

        if (i > 3)
        {
            A.gameObject.SetActive(true);
        }
    }
}
