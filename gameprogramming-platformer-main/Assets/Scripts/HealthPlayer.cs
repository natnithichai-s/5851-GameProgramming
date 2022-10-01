using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;

    public void HealthShow(int playerHealth)
    {
        healthText.text = $"Lives: {playerHealth}";
    }
}
