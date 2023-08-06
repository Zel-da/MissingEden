using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    public GameObject childObject;

    public int a;

    public void ActivateChild()
    {
        childObject.SetActive(true); // Activate the child GameObject
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ActivateChild();
            Invoke("InvokeTest", 2.25f);
        }
    }

    void InvokeTest()
    {
        childObject.SetActive(false);
    }

    public void OnClick()
    {
        SceneManager.LoadScene(a);
        //SceneLoader.Instance.LoadScene("SampleScene");
    }
}
