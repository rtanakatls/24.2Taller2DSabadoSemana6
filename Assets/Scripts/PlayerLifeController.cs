using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeController : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int maxLife;


    private void Start()
    {
        LifeUIController.Instance.UpdateLife(life);
    }

    public void ChangeLife(int value)
    {
        life += value;
        LifeUIController.Instance.UpdateLife(life);
        LifeBarUIController.Instance.UpdateLifeBar(life, maxLife);
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
