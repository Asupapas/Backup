using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public int health = 20;
    public TextMeshProUGUI healthText;
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Bullet")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
