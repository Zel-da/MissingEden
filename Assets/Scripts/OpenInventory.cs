using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public static bool inventoryActivated = false;


    // �ʿ��� ������Ʈ
    [SerializeField]
    private GameObject go_InventoryBase;
    [SerializeField]
    private GameObject go_SlotsParent;

    private void OpenInventory1()
    {
        go_InventoryBase.SetActive(true);
    }

    private void CloseInventory()
    {
        go_InventoryBase.SetActive(false);
    }

    public void OnClick()
    {
        inventoryActivated = !inventoryActivated;

        if (inventoryActivated)
            OpenInventory1();
        else
            CloseInventory();
    }
}
