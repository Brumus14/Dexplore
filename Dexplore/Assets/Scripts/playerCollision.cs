using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{

    bool PlayerDead = false;
    public DeathMenu deathMenu;
    public int MaxHealth = 40;
    public int CurrentHealth;
    public HealthBar healthBar;

    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            TakeDamage(10);

            if (CurrentHealth <= 0)
            {
                PlayerDead = true;
                Destroy(this.gameObject);
                deathMenu.ToggleDeathMenu();
            }
        }
    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth);
    }
}
