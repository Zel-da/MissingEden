using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveEffect : MonoBehaviour
{
    public float speed = 1.0f;
    public float amplitude = 10.0f;

    public RectTransform rectTransform;
    public Vector2 originalPosition;

    private float initialY;

    /*private void Start()
    {
        initialY = transform.position.y;
    }

    private void OnEnable()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = initialY;
        transform.position = currentPosition;
    }
    */

    public void SetRectTransform(RectTransform newRectTransform)
    {
        rectTransform = newRectTransform;
        originalPosition = rectTransform.anchoredPosition;
    }

    private void Update()
    {
        float yOffset = Mathf.Sin(Time.time * speed) * amplitude;
        rectTransform.anchoredPosition = originalPosition + new Vector2(0, yOffset);
    }
}
