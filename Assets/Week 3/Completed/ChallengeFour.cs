using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD170.Completed
{
    public class ChallengeFour : MonoBehaviour
    {
        /*
         * Write some code to do the following:
            * Create variables for the following information:
                * strength, agility and intelligence, and a variable for stat pool of 20
            * For each stat, let’s assign a random value between 0-10.
            * Update your stat allocation and make it a random number between 0 and your current stat pool value.
            * Finally each time we assign a random value to a stat pool, let’s remove that from our stat pool:
                * i.e. strength gets the random number 7; we take this away from our statpool, there are now 13 stat points left, agility now gets a random number between 0 and 13.
            * Debug out the following:
                * Each value of your stats and the current value of stat pool.
            * Bonus
                * Let’s assign another 20 points of stats to our statpool and assign these stats using a key input.
         */

        int statPool = 20;
        int agility;
        int strength;
        int intelligence;
        int randomNumber;

        // Start is called before the first frame update
        void Start()
        {
            randomNumber = Random.Range(0, statPool);
            agility = randomNumber;
            statPool = statPool - randomNumber;
            Debug.Log("agility = " + agility + " statpool is " + statPool);

            randomNumber = Random.Range(0, statPool);
            intelligence = randomNumber;
            statPool = statPool - randomNumber;
            Debug.Log("intelligence = " + intelligence + " statpool is " + statPool);

            randomNumber = Random.Range(0, statPool);
            strength = randomNumber;
            statPool = statPool - randomNumber;
            Debug.Log("strength = " + strength + " statpool is " + statPool);

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                statPool = statPool + 20; // add 20 more stats.
                Debug.Log("statpool = " + statPool);

                // same code as above, but we add the values to our current stat amount.
                randomNumber = Random.Range(0, statPool);
                agility += randomNumber;
                statPool = statPool - randomNumber;
                Debug.Log("agility = " + agility + " statpool is " + statPool);

                randomNumber = Random.Range(0, statPool);
                intelligence += randomNumber;
                statPool = statPool - randomNumber;
                Debug.Log("intelligence = " + intelligence + " statpool is " + statPool);

                randomNumber = Random.Range(0, statPool);
                strength += randomNumber;
                statPool = statPool - randomNumber;
                Debug.Log("strength = " + strength + " statpool is " + statPool);
            }
        }
    }
}