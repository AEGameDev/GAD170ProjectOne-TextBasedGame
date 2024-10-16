using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int attack = 0;
    public int level = 0;
    private float attackStatUp = 1.25f;
    public int experience = 0;

    public int enemyHealth = 0;
    public int enemyLevel = 0;

    private bool level2Logged = false;
    private bool level3Logged = false;
    private bool level4Logged = false;
    private bool level5Logged = false;

    private bool level2Attack = false;
    private bool level3Attack = false;
    private bool level4Attack = false;

    private bool weaponChosen = false;
    private bool endOfStart = false;

    private bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("*A Deranged Dwarf Appears Out Of Nowhere*");
        Debug.Log("Ingund: Adventurer! You made it!");
        Debug.Log("Ingund: I was getting worried that we were on our own...");
        Debug.Log("Ingund: Let me get you up to speed. We are fighting the 'Black Titans' demonic army!");
        Debug.Log("Ingund: You'll need to take up arms against them! *Ingund gestures towards the weapons rack*");
        Debug.Log("Ingund: You have a choice Adventurer! *Press 1 for an Axe, 2 for a Sword or 3 for a Mace*");

        level += 1;

        if (enemyHealth <= 0)
        {
            enemyLevel = Random.Range(1, 6);
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
        if (Input.GetKeyDown(KeyCode.Alpha1) && !weaponChosen)
        {
            Debug.Log("*Player picks up the Axe*");
            Debug.Log("*Ingund Bellows* Axe-citing Times Ahead!");
            Debug.Log("*Press Space To Continue*");
            weaponChosen = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && !weaponChosen)
        {
            Debug.Log("*Player chose a Sword*");
            Debug.Log("*Ingund Howls* Death By a Thousand Stabs!");
            Debug.Log("*Press Space To Continue*");
            weaponChosen = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && !weaponChosen)
        {
            Debug.Log("*Player grabs the Mace*");
            Debug.Log("*Ingund Roars* A Mighty Choice!");
            Debug.Log("*Press Space To Continue*");
            weaponChosen = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !endOfStart)
        {
            Debug.Log("*VWOOMP* A Void Opens & A Level " + enemyLevel + " Demon Appears!");
            Debug.Log("Ingund: One of the Black Titans minions has set upon us!");
            Debug.Log("Ingund: Quick adventurer, destroy this foul beast!");
            Debug.Log("*Press A to Attack*");
            endOfStart = true;
        }

        Attack();
        AttackIncrease();
        EnemyDeadDead();
        Experience();
        LevelUpNotification();
        LevelUp();
        NewEnemy();                      
        EndGame();

    }

    void Attack()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            enemyHealth -= attack;
            Debug.Log("Player Attack Did " + attack + " Damage!");
            Debug.Log("Enemy has " + enemyHealth + "HP Remaining!");
        }
    }

    void AttackIncrease()
    {
        if (level == 2 && !level2Attack)
        {
            float attacklvl2 = attackStatUp * (float)attack;
            attack = (int)attacklvl2;
            Debug.Log("Your Attack Increased To: " + attack);
            level2Attack = true;
        }
        if (level == 3 && !level3Attack)
        {
            float attacklvl3 = attackStatUp * (float)attack;
            attack = (int)attacklvl3;
            Debug.Log("Your Attack Increased To: " + attack);
            level3Attack = true;
        }
        if (level == 4 && !level4Attack)
        {
            float attacklvl4 = attackStatUp * (float)attack;
            attack = (int)attacklvl4;
            Debug.Log("Your Attack Increased To: " + attack);
            level4Attack = true;
        }
    }

    void NewEnemy()
    {
        if (enemyHealth < 1)
        {
            Debug.Log("*RHEEEEEKK* The Demon is Slain! *VWOOMP* Another Demon Spawns...");

            enemyLevel = Random.Range(1, 6);
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
    void EnemyDeadDead()
    {
        if (enemyHealth < 0)
        {
            Debug.Log("That Demons Definitely DEAD DEAD!");
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
            Debug.Log("You have reached the Max Level: " + level);
        }
    }    
    void EndGame()
    {
        if (level == 5 && !gameOver)
        {
            Debug.Log("Ingund: Thank you for your service Adventurer!");
            Debug.Log("Ingund: You have saved us! *Ingund Tears Up*");
            Debug.Log("Ingund: Go on your way now, QUICKLY! Before I Weep!");
            Debug.Log("*Adventure Complete* Thanks for Playing, Press Q to End Game!");
            gameOver = true;           
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
           Debug.Break();
        }
    }

}
