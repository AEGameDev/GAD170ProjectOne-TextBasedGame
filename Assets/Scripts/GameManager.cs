using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int health = 0;
    public int maxHealth = 100;
    public int attack = 10;
    public int level = 0;
    public float attackIncrease = 1.25f;
    public int experience = 0;
    public int maxExperience = 100;

    public int enemyHealth = 0;
    public int maxEnemyHealth = 100;

    // Start is called before the first frame update
    void Start()
    {

        
        enemyHealth = Random.Range(enemyHealth, maxEnemyHealth);

        level += 1;
        Debug.Log("You are level " + level);
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        LevelUp();
        NewEnemy();
                                        
        void Attack()
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                enemyHealth -= attack;
                Debug.Log("Player Did " + attack + " Damage");
            }


        }
      
        void LevelUp()
        {
            if (Input.GetKeyUp(KeyCode.L))
            {
                level += 1;
                attack += (int)1.25f * 10; 
                Debug.Log("You are now level " + level + ". And your Attack Damage is now" + attack);
            }                 
        }

        void NewEnemy()
        {
            if (enemyHealth <= 0)
            {
                enemyHealth = Random.Range(enemyHealth,maxEnemyHealth);
            }
        }
    }

}
