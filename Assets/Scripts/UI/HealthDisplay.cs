using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _heathBar;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }
    private void OnDisable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        _heathBar.text = health.ToString();
    }
}
