using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMove : MonoBehaviour
{
    public float rotationSpeed = 50f;

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // Rotate the image around the center of the RectTransform in a circular motion
        rectTransform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
