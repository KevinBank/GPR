using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthTextUI : MonoBehaviour
{
    [SerializeField]
    private PlayerStats playerStats;
    [SerializeField]
    private Text healthText;

    private void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        playerStats.HealthChanged += RenderHealth;
        playerStats.Death += OnDie;
    }

    private void RenderHealth(int health)
    {
        healthText.text = "Health: " + health;
    }
    private void OnDie()
    {
        healthText.text = "Ik ben dood";
    }
}
