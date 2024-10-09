using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI mainText;

    public int playerHealth = 100;
    public int playerAttack = 10;
    public int playerLevel = 1;
    public int enemyHealth = 100;
    public int enemyAttack = 5;

    // Start is called before the first frame update
    void Start()
    {
      
      mainText.text = "Your Character Level is " + playerLevel;
      
    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
