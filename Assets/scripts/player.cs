using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject playerCapsule;
    
    public Text score;
    public int coins = 0;
    void OnTriggerEnter2D(Collider2D col) {

        //obstacles
        if (col.gameObject.name == "obstacles" ){
            Die();
        }
        //coin
        if (col.gameObject.name == "coin"){
            coins++;
            Debug.Log(coins);
            Destroy(col.gameObject);
            score.text = ( "Score: " + coins);
        }
        
    }
    
    void Die()
    {
        Destroy(playerCapsule);
    }
}
