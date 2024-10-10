using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices.WindowsRuntime;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI mainText;

    public int playerHealth = 100;
    public int playerAttack = 10;
    public int playerLevel = 1;
    public int playerExperience = 0;
    public float attackGain = 0.25f;

    public int enemyHealth = 0;
    public int enemyAttack = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the Game Adventurer!");
        Debug.Log("It's time to slay some enemies!");
        Debug.Log("When an enemy appears, press the A key to attack!");
        Debug.Log("To begin your adventure, press B!");

        enemyHealth += Random.Range(100, 150);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B))
        {
            Debug.Log("An enemy appears out of nowhere, you know what to do adventurer!");
        }

        Attack();
        LevelUp();

        if (enemyHealth < 1) 
        {
            EnemyKilled();
            enemyHealth = Random.Range(100, 150);
        } 

   

        //This is player attack function
        void Attack()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                enemyHealth -= playerAttack;

            }
        }
      
        //This function logs when an enemy has been killed and updates player on current XP
        void EnemyKilled()
        {
            playerExperience += Random.Range(0, 100);
            Debug.Log("You slayed and enemy!");
            Debug.Log("Your current XP is " + playerExperience + "/100XP");
            
        }

        void LevelUp()
        {
            if (playerExperience >= 100)
            {
                Debug.Log("You can now level up!");
                Debug.Log("Press L to increase level!");
            }
            if (Input.GetKeyDown (KeyCode.L))
            {
                playerLevel++;
                Debug.Log("You are now level " + playerLevel + "!");
                Debug.Log("A new enemy appears...");
            }
            if (playerExperience >= 100)
            {
                playerExperience = 0;
            }
        }
    }

  
    








}
