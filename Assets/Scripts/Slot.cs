using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item; // 획득한 아이템.
    public Image itemImage; // 아이템의 이미지.

    // 이미지의 투명도 조절.
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    // 아이템 획득
    public void AddItem(Item _item, int _count = 1)
    {
        item = _item;
        itemImage.sprite = item.itemImage;

        SetColor(1);
    }

    // 슬롯 초기화.
    private void ClearSlot()
    {
        item = null;
        itemImage.sprite = null;
        SetColor(0);
    }
}
