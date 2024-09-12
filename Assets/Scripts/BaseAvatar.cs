using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour
{
    [SerializeField] private float _maxSpeed;
    protected float maxHealth;
    protected float health;

    public float MaxSpeed {
        get {
        return this._maxSpeed;
        }
        private set {
        this._maxSpeed = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            Die();
        }
    }

    public virtual void Die() {
        Destroy(gameObject);
    }
}
