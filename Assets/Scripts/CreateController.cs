using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateController : MonoBehaviour
{
    [SerializeField]
    private GameObject A;
    public void OnClick()
    {
        A.gameObject.SetActive(true);
    }
}
