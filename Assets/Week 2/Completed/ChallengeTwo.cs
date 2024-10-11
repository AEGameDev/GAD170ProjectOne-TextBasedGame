using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD170.Completed
{
    public class ChallengeTwo : MonoBehaviour
    {
        /*
       * Write some code to do the following:
          * Create variables for the following information:
              * The name of your favourite game.
              * How many hours you have played it for. (do a rough estimate, if it was free, did you buy dlc?)
              * How much it cost you to purchase.
              * The dollar per hour.
          * Debug out the following:
              * “My Favourite game is ___, I have played it for ___, it cost me _____, therefore my value of dollar per hour is: ____.” 
       */

        public string gameName;
        public float gameCost;
        public int hoursPlayed;


        // Start is called before the first frame update
        void Start()
        {
            // hint you'll need to do a fraction and some casting in this case we'd want to divide our cost by our hours.
            // make sure you double check this in a calculator, but also consider you may need to convert from ints to floats.
            float costPerHour = gameCost / (float)hoursPlayed;

            Debug.Log("My Favourite game is " + gameName);
            Debug.Log("I have played it for " + hoursPlayed);
            Debug.Log("it cost me $" + gameCost);
            Debug.Log("therefore my value of dollar per hour is: $" + costPerHour);
        }
    }
}
