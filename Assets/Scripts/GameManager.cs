using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int health = 0;
    public int maxHealth = 100;
    public int attack = 10;
    public int level = 0;
    public float attackIncrease = 1.25f;
    public int experience = 0;
    public int maxExperience = 501;

    public int enemyHealth = 0;
    public int enemyLevel = 0;

    private bool level2Logged = false;
    private bool level3Logged = false;
    private bool level4Logged = false;
    private bool level5Logged = false;

    private bool gameOver = false;
    

    // Start is called before the first frame update
    void Start()
    {
        level += 1;

        if (enemyHealth <= 0)
        {
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
    // Update is called once per frame
    void Update()
    {
        Attack();
        Experience();
        LevelUpNotification();
        LevelUp();                
        NewEnemy();
        EndGame();
        return;
    }

    void Attack()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            enemyHealth -= attack;
            Debug.Log("Player Did " + attack + " Damage! " + "Enemy has " + enemyHealth + "HP");
        }
    }

    void NewEnemy()
    {
        if (enemyHealth <= 0)
        {
            Debug.Log("Enemy Slain & A New One Appears");
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
        if (experience > 100 && experience < 200 && !level2Logged) 
        {
            Debug.Log("You are ready to level up to level 2!");
            Debug.Log("Press L to Level Up...");
            level2Logged = true;
        }
        if (experience > 200 && experience < 300 && !level3Logged)
        {
            Debug.Log("You are ready to level up to level 3!");
            Debug.Log("Press L to Level Up...");
            level3Logged = true;
        }
        if (experience > 300 && experience < 400 && !level4Logged)
        {
            Debug.Log("You are ready to level up to level 4!");
            Debug.Log("Press L to Level Up...");
            level4Logged = true;
        }
        if (experience > 400 && experience <500 && !level5Logged)
        {
            Debug.Log("You are ready to level up to level 5!");
            Debug.Log("Press L to Level Up...");
            level5Logged = true;
        }

    }

    void LevelUp()
    {
        if (experience >100 && experience <200 && Input.GetKeyDown(KeyCode.L))
        {
            level = 2;
            Debug.Log("You are level 2!");
        }       
        else if (experience >200 && experience <300 && Input.GetKeyDown(KeyCode.L))
        {
            level = 3;
            Debug.Log("You are level 3!");
        }
        else if (experience >300 && experience <400 && Input.GetKeyDown(KeyCode.L))
        {
            level = 4;
            Debug.Log("You are level 4!");
        }
        else if (experience >400 && experience <500 && Input.GetKeyDown(KeyCode.L))
        {
            level = 5;
            Debug.Log("You are level 5");
        }
    }    
    void EndGame()
    {
        if (level == 5 && !gameOver)
        {
            Debug.Log("You have completed the Game");
            gameOver = true;
        }
    }
}
