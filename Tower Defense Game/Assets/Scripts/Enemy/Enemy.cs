using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [Header("[ Enemy Settings ]")]
    public float startHealth = 100f;
    public float startSpeed = 10f;
    public float startDfense = 0f;
    [HideInInspector] public float speed;
    [HideInInspector] public float health;
    [HideInInspector] public float dfense;

    [Header("[ Loot Settings ]")]
    public int lootMoney = 50;

    [Header("[ Effect Settings ]")]
    public GameObject deathEffect = null;

    [Header("[ Unity Settings ]")]
    public Image healthBar = null;
    private Quaternion starthealthBarRotate;

    private bool isDie = false;

    private void Start()
    {
        health = startHealth;
        speed = startSpeed;
        dfense = startDfense;
        starthealthBarRotate = healthBar.transform.rotation;
    }

    private void Update()
    {
        healthBar.transform.parent.transform.parent.rotation = starthealthBarRotate;
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health / startHealth, Time.deltaTime * 10);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0 && isDie == false)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - (pct/100));
    }

    private void Die()
    {
        isDie = true;
        PlayerStats.Money += lootMoney;
        if(deathEffect != null)
        {
            GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
        }
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
