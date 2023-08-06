using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransform : MonoBehaviour
{
    public RectTransform newRectTransform;
    public WaveEffect waveEffect;

    void Start()
    {
        waveEffect.SetRectTransform(newRectTransform);
    }
}
