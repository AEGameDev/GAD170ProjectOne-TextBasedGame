using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD170.Completed
{
    public class ChallengeOne : MonoBehaviour
    {
        /*
         * Write some code to do the following:
         * Variables to hold:
            * Your name
            * Your age in years.
            * Your height (to two decimal points).
            * If you're wearing a watch.
            * Your favourite number.
         *Debug out the following sentences and fill in the blanks using your variables:
            * "Hi my name is: ____"
            * "My age is:_____"
            * "I am ___ centimeters tall"
            * "The rumours going around that I am wearing a watch are: ___"
            * "My favourite number is___"
            * "If my age was added to my favourite number, and subtracted my height it would give me ____."
        */


        public string yourName;
        public int yourAge;
        public float yourHeight;
        public bool isWearingAWatch;
        public double yourFavouriteNumber; // using a double to demonstrate the difference, but int or float is fine

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Hi my name is: " + yourName);
            Debug.Log("My age is: " + yourAge);
            Debug.Log("I am " + yourHeight + " centimeters tall");
            Debug.Log("The rumours going around that I am wearing a watch are: " + isWearingAWatch);
            Debug.Log("My favourite number is " + yourFavouriteNumber);
            Debug.Log("If my age was added to my favourite number, and subtracted my height it would give me: " + (yourAge + yourFavouriteNumber - yourHeight));
        }
    }
}