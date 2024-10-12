using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUIController : MonoBehaviour
{
    private static LifeUIController instance;

    public static LifeUIController Instance { get { return instance; } }

    private TextMeshProUGUI lifeText;

    private void Awake()
    {
        instance = this;
        lifeText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateLife(int life)
    {
        lifeText.text=$"Life: {life}";
    }
}
