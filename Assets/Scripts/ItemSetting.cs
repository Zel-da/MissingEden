using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSetting : MonoBehaviour
{
    public float Expiration_Date = 0;
    public Sprite change_img;
    Image thisImg;

    private void Start()
    {
        thisImg = GetComponent<Image>();
    }

    void Update()
    {
        Expiration_Date += Time.deltaTime;

        if(Expiration_Date == 1080)
        {
            thisImg.sprite = change_img;
        }
    }
}
