using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public string nextLevel = "Scene_2";
    public int CoinCounter = 0;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        switch (other.tag) 
        { 
           case "Finish": {
                   
                SceneManager.LoadScene(nextLevel);
                break;
                }
                  
                   case "Coin":{

                    CoinCounter++;
                    Destroy(other.gameObject);
                    break;
            }
            case "Death": {
                string thisLevel = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(thisLevel);
                break;
            }
        }
    }
}
