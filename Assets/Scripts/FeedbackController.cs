using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackController : MonoBehaviour
{
    private bool isFeedbackActive;
    private float timer;
    [SerializeField] private float feedbackDelay;
    [SerializeField] private Color feedbackColor;
    private Color originalColor;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }


    public void ShowFeedback()
    {
        isFeedbackActive = true;
        timer = 0;
        spriteRenderer.color = feedbackColor;
    }

    private void Update()
    {
        FeedbackTimer();
    }

    private void FeedbackTimer()
    {
        if (isFeedbackActive)
        {
            timer += Time.deltaTime;
            if (timer >= feedbackDelay)
            {
                isFeedbackActive = false;
                spriteRenderer.color = originalColor;
            }
        }
    }


}
