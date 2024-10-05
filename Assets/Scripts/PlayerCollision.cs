using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private LifeController lifeController;
    private FeedbackController feedbackController;

    private void Awake()
    {
        lifeController = GetComponent<LifeController>();
        feedbackController = GetComponent<FeedbackController>();
    }

    private void TakeDamage(int damage)
    {
        lifeController.ChangeLife(-damage);
        feedbackController.ShowFeedback();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("EnemyBullet"))
        {
            TakeDamage(collision.gameObject.GetComponent<DamageController>().Damage);         
        }
    }
}
