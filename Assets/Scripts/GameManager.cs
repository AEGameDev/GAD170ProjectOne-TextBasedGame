using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int health = 0;
    public int maxHealth = 100;
    public int attack = 0;
    public int level = 0;
    public float attackIncrease = 1.25f;
    public int experience = 0;
    public int maxExperience = 501;

    public int enemyHealth = 0;
    public int enemyLevel = 0;   
    
    

    // Start is called before the first frame update
    void Start()
    {
        level += 1;

        enemyLevel = Random.Range(1, 5);
        if (enemyLevel == 1)
        {
            enemyHealth = 10;
        }
        else if (enemyLevel == 2)
        {
            enemyHealth = 15;
        }
        else if(enemyLevel == 3)
        {
            enemyHealth = 20;
        }
        else if (enemyLevel == 4)
        {
            enemyHealth = 25;
        }
        else if (enemyLevel == 5)
        {
            enemyHealth = 30;
        }

        attack = 10;

        if (level == 2)
        {

            float attackStat2 = attackIncrease / (float)attack * 100;
            Debug.Log(attackStat2);

        }                
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        LevelUp();       
        Experience();
        NewEnemy();
        EndGame();
        return;
    }

    void Attack()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            enemyHealth -= attack;
            Debug.Log("Player Did " + attack + " Damage!" + " Enemy has " + enemyHealth + "HP");
        }
    }

    void NewEnemy()
    {
        if (enemyHealth <= 0)
        {
            Debug.Log("Enemy Slain! New Enemy Appears!");
            enemyLevel = Random.Range(0, 5);
            if (enemyLevel == 1)
            {
                enemyHealth = 10;
            }
            else if (enemyLevel == 2)
            {
                enemyHealth = 15;
            }
            else if (enemyLevel == 3)
            {
                enemyHealth = 20;
            }
            else if (enemyLevel == 4)
            {
                enemyHealth = 25;
            }
            else if (enemyLevel == 5)
            {
                enemyHealth = 30;
            }
        }
    }

    void LevelUp()
    {
        if (experience >100 && experience <200 && Input.GetKeyDown(KeyCode.L))
        {
            level = 2;
        }
        if (level == 2 && Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("You are now level 2!");
            
        }
        else if (experience >200 && experience <300 && Input.GetKeyDown(KeyCode.L))
        {
            level = 3;
        }

        //if (p > minValue && p < maxValue)
    }

    void Experience()
    {
        if (enemyHealth <= 0)
        {
            experience = experience + Random.Range(1, 51);
            Debug.Log("You have gained some XP");           
        }
    }

    void LevelUpNotification()
    {
        if (experience > 100 && experience <200)
        {
            Debug.Log("You are ready to level up to level 2!");
            Debug.Log("Press L to Level Up...");
            return;
        }
        if (experience == 200)
        {
            Debug.Log("You are ready to level up to level 3!");
            Debug.Log("Press L to Level Up...");
        }
        if (experience == 300)
        {
            Debug.Log("You are ready to level up to level 4!");
            Debug.Log("Press L to Level Up...");
        }
        if (experience == 400)
        {
            Debug.Log("You are ready to level up to level 5!");
            Debug.Log("Press L to Level Up...");
        }
        
    }

    void EndGame()
    {
        if (level == 5)
        {
            Debug.Log("You have completed the Game");
            return;
        }
    }
}
