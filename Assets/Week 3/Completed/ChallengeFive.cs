using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD170.Completed
{
    public class ChallengeFive : MonoBehaviour
    {
        int playerOneHealth = 0;
        int playerOneStrength = 0;
        int playerOneAgility = 0;
        int playerOneIntelligence = 0;
        int playerOnePowerLevel = 0;

        int playerTwoHealth = 0;
        int playerTwoStrength = 0;
        int playerTwoAgility = 0;
        int playerTwoIntelligence = 0;
        int playerTwoPowerLevel = 0;

        // Start is called before the first frame update
        void Start()
        {
            SetPlayerOneStats();
            SetPlayerTwoStats();
        }

        // Update is called once per frame
        void Update()
        {
            Battle();
        }

        void SetPlayerOneStats()
        {
            // set our health to 100
            playerOneHealth = 100;
            // set our stats to random numbers between 0 - 10
            playerOneAgility = Random.Range(0, 10);
            playerOneIntelligence = Random.Range(0, 10);
            playerOneStrength = Random.Range(0, 10);
        }

        void SetPlayerTwoStats()
        {
            // set our health to 100
            playerTwoHealth = 100;
            // set our stats to random numbers between 0 - 10
            playerTwoAgility = Random.Range(0, 10);
            playerTwoIntelligence = Random.Range(0, 10);
            playerTwoStrength = Random.Range(0, 10);
        }

        void Battle()
        {
            // if you want to get really fancy here, only let me "battle" if both characters have health left.
            if (Input.GetKeyDown(KeyCode.Space) && playerOneHealth > 0 && playerTwoHealth > 0)
            {
                playerOnePowerLevel = GeneratePowerLevel(playerOneIntelligence, playerOneAgility, playerOneStrength);
                playerTwoPowerLevel = GeneratePowerLevel(playerTwoIntelligence, playerTwoAgility, playerTwoStrength);
                DetermineWinner(playerOnePowerLevel, playerTwoPowerLevel);
            }
            else if(playerOneHealth <= 0 || playerTwoHealth <= 0)
            {
                Debug.Log("Game is over");
            }
        }

        int GeneratePowerLevel(int intel, int agil, int strength)
        {
            // let's do some sort of algorithm here i.e. intel + agil  + strength, it's probably a good idea to add some randomness here too,
            // otherwise the same player will always win most likely.
            int powerLevel = intel * agil * strength + Random.Range(0, 10);

            return powerLevel;
        }

        void DetermineWinner(int playerOnePower, int playerTwoPower)
        {
            if (playerOnePowerLevel > playerTwoPowerLevel)
            {
                // player one has more power.
                // deal a random amount of damage to the other player.
                playerTwoHealth -= Random.Range(0, 25);
                // check if the other player has health left over, if not, tell us player one has won the game.
                if (playerTwoHealth >= 0)
                {
                    Debug.Log("player one has won!");
                }
            }
            else if (playerTwoPowerLevel > playerOnePowerLevel)
            {
                // player two has more power
                // deal a random amount of damage to the other player.
                playerOneHealth -= Random.Range(0, 25);
                // check if the other player has health left over, if not, tell us player two has won the game.
                if (playerOneHealth >= 0)
                {
                    Debug.Log("player two has won!");
                }
            }
            else
            {
                // should we do anything if it's a draw? maybe they both take damage
                playerOneHealth -= Random.Range(0, 25);
                playerTwoHealth -= Random.Range(0, 25);

                if (playerTwoHealth >= 0)
                {
                    Debug.Log("player one has won!");
                }

                if (playerOneHealth >= 0)
                {
                    Debug.Log("player two has won!");
                }
            }
        }
    }
}
