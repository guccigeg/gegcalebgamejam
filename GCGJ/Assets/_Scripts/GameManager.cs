using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour {
    [SerializeField] private float health = 10.0f;
    [SerializeField] private float death = 10.0f;
    private void Update() {

    }
    public void LoseHealth(float lostHealth) {
        health -= lostHealth;
    }
    public void GainHealth(float gainedHealth) {
        health += gainedHealth;
    }

    public void LoseDeath(float lostDeath) {
        death -= lostDeath;
    }
    public void GainDeath(float gainedDeath) {
        death += gainedDeath;
    }
}