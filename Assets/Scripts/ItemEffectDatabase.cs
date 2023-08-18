using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEffect
{
    public string itemName; // �������� �̸�. (Ű��)
    [Tooltip("HP, SP, DP, HUNGRY, THIRSTY , SATISFY�� �����մϴ�")]
    public string[] part; // ����.
    public int[] num; // ��ġ.
}

public class ItemEffectDatabase : MonoBehaviour
{

    [SerializeField]
    private ItemEffect[] itemEffects;

    private const string HP = "HP", SP = "SP", DP = "DP", HUNGRY = "HUNGRY", THIRSTY = "THIRSTY", SATISFY = "SATISFY";

    public void UseItem(Item _item)
    {
        if (_item.itemType == Item.ItemType.Used)
        {

            for (int x = 0; x < itemEffects.Length; x++)
            {

                if (itemEffects[x].itemName == _item.itemName)
                {

                    for (int y = 0; y < itemEffects[x].part.Length; y++)
                    {

                        switch (itemEffects[x].part[y])
                        {
                            case HP:
                                
                                break;
                            case SP:
                                
                                break;
                            case DP:
                                //thePlayerStatus.IncreaseDP(itemEffects[x].num[y]);
                                break;
                            case THIRSTY:
                                //thePlayerStatus.IncreaseThirsty(itemEffects[x].num[y]);
                                break;
                            case HUNGRY:
                                //thePlayerStatus.IncreaseHungry(itemEffects[x].num[y]);
                                break;
                            case SATISFY:
                                break;
                            default:
                                Debug.Log("�߸��� Status ����. HP, SP, DP, HUNGRY, THIRSTY , SATISFY�� �����մϴ�");
                                break;
                        }
                        Debug.Log(_item.itemName + " �� ����߽��ϴ�");

                    }
                    return;
                }


            }
            Debug.Log("ItemEffectDatabase�� ��ġ�ϴ� itemName �����ϴ�");
        }

    }
}