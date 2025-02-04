using UnityEngine;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    float health = 10;
    float maxHealth;
    Image healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
        healthBar = GetComponentsInChildren<Image>()[1];
        healthBar.fillAmount = health / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
       // healthBar.fillAmount = health / maxHealth;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
