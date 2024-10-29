using UnityEngine;
using TMPro;

public class GameHUD : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Player player;

    [Header("Components")]
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        player.OnScoreChanged += PlayerScoredChanged;
    }

    private void PlayerScoredChanged()
    {
        scoreText.text = "Score: " + player.GetCurrentScore();
    }

    private void Update()
    {

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