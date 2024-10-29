using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private MovementComponent movementComponent;
    // ui text for score
    // ui text for health

    private int currentScore = 0;

    public event Action OnScoreChanged;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        movementComponent.SetMovementInput(x);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddToScore();
        }

        // testing for github
    }

    public void AddToScore()
    {
        currentScore += 1;
        OnScoreChanged?.Invoke();
    }
    public int GetCurrentScore()
    {
        return currentScore;
    }
}

// movement
// move left and right
// jump & double jump 
// need to check if player is on ground
// shooting
// fire rate 
// ammo system
// spawn projectiles
// projectile speed
// jumping
// rolling 
// crouch 
// bombs
// health 
// stats
// UI 
// Inventory 
// Skills