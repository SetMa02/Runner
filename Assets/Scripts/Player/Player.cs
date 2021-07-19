using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private SpriteRenderer _spriteRenderer;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;


    public void ApplyDamage(int damage)
    {
        
        _health -= damage;
        HealthChanged?.Invoke(_health);
        if (_health <= 0)
            Die();
    }

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        HealthChanged?.Invoke(_health);
    }

    public void Die()
    {
        Died?.Invoke();
        
    }
}
