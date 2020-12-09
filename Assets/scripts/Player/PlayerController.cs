using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public int maxHP;
    public int currentHP;

    public int scoreToReduce = 100;
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        maxHP = 3;
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void dealDamage(int damage)
    {
        currentHP = currentHP - damage;
        if (currentHP <= 0)
        {
            FindObjectOfType<scoreManager>().reduceScore(scoreToReduce);
            //death
            //Debug.Log("death");

            LevelManager.instance.RespawnPlayer();
        }
    }
    
    public void healDamage(int heal)
    {
        currentHP += heal;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }

    }
}
