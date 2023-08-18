using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CookButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Cook", LoadSceneMode.Additive);
    }
}
