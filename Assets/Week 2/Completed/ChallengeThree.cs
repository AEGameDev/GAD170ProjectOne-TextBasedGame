using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD170.Completed
{
    public class ChallengeThree : MonoBehaviour
    {
        /*
         * Write some code to do the following:
            * Create a local variable to hold a random float, between 1 and 10, leave a comment for its purpose.          
            * Debug log the value of the number
            * Check for and Debug out the following:
                * Debug log "The number was exactly one" if randomNumber equals 1.
                * Debug log "The number was greater than three" if randomNumber is greater than 3.
                * Debug log 'The number was greater than 7 or less than 5' if randomNumber is greater than 7 or less than 5; otherwise, debug log 'the number was 6 or 7'."
                * Debug log "The number was greater than one and less than 5; or the number was greater than 5" if randomNumber is greater than 1 and less than 5, or if it's greater than 5.
            * Bonus - Let�s debug out a percentage of the result, i.e. if the max possible random number is 10 and our random number is 1, as a percentage should be ?
         */

        private void Start()
        {
            float randomNumber = Random.Range(0f, 10f);

            Debug.Log(randomNumber);

            if (randomNumber == 1)
            {
                Debug.Log("the number was exactly one");
            }

            if (randomNumber > 3)
            {
                Debug.Log("the number was greater than three");
            }

            if (randomNumber > 7 || randomNumber < 5)
            {
                Debug.Log("The number was greater than 7 or less than 5");
            }
            else
            {
                Debug.Log("the number was 6 or 7");
            }

            if ((randomNumber > 1 && randomNumber < 5) || randomNumber > 5)
            {
                Debug.Log("The number was greater than one and less than 5; or the number was greater than 5");
            }

            Debug.Log("The random number as a percentage is: " + (randomNumber / 10) * 100 + "%");
        }
    }
}