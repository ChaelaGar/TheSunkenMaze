using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public float health = 10;
    [SerializeField]
    string levelToLoad = "Lose";
    float maxHP;
    [SerializeField]
    float healthRestart = 10;
    [SerializeField]
    Image healthBar;

    // timers
    float hitTimer = 0f;
    [SerializeField]
    float hitTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        health = healthRestart;
        maxHP = health;
        healthBar.fillAmount = health / maxHP;
    }
    // Update is called once per frame
    void Update()
    {
        hitTimer += Time.deltaTime;
        //healthBar.fillAmount = health / maxHP;
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene(levelToLoad);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        // IF we hit an enemy, reduce player HP
        if (collision.gameObject.tag == "Enemy" && hitTimer >= hitTime)
        {
            health -= 1;
            healthBar.fillAmount = health / maxHP;
            hitTimer = 0;
            //add consequences
            //IF health gets too low, reload the current level
            if (health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //SceneManager.LoadScene(levelToLoad);
            }
        }
       
        else
        {
            if (collision.gameObject.tag == "Win")
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        // IF we hit an enemy, reduce player HP
        if (collision.gameObject.tag == "Enemy" && hitTimer >= hitTime)
        {
            health -= 1;
            healthBar.fillAmount = health / maxHP;
            hitTimer = 0;
            //add consequences
            //IF health gets too low, reload the current level
            if (health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //SceneManager.LoadScene(levelToLoad);
            }
        }
        else if (collision.gameObject.layer == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

