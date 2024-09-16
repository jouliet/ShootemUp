using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : BaseAvatar
{
    float maxEnergy = 5;
    float energy;

    public float Energy {
        get {
            return energy;
        }
        set {
            this.energy = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;
        health = maxHealth;
        energy = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        energy += Time.deltaTime * 0.3f;
        if (Energy > 5)
        { 
            energy = 5;
        }
    }
}
