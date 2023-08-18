using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class TextManager : MonoBehaviour
{
    [SerializeField] private GameObject sprite_DialogueBox;
    [SerializeField] private TMP_Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        OnOff(true);

        count = 0;
        isDialogue = true;
    }

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    private void HideDialogue()
    {
        OnOff(false);
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        count++;
    }

    void Awake()
    {
        OnOff(true);
    }

    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.G))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    HideDialogue();
            }
        }    
    }
}
