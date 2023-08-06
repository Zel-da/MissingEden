using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveUi : MonoBehaviour
{
    public Material waveMaterial;
    public float waveSpeed = 1.0f;
    public float waveIntensity = 0.5f;

    void Update()
    {
        // Update the wave properties in the material every frame
        waveMaterial.SetFloat("_WaveSpeed", waveSpeed);
        waveMaterial.SetFloat("_WaveIntensity", waveIntensity);
    }
}