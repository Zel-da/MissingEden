using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CookScene : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Roast", LoadSceneMode.Additive);
    }
}
