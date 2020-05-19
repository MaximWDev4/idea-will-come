using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public CharacterController2D controller;
    public playerMovement movement;
    public GameObject playerCapsule;
    public SpriteRenderer[] spriteRenderer;
    public Sprite NewSprite;
    public Sprite NormalSprite;
    public Text score;
    public Text GameOverText;
    public int coins = 0;
    private GameObject go;
    void OnTriggerEnter2D(Collider2D col) {

        //obstacles
        if (col.gameObject.tag == "obstacles" ){
            Die();
        }
        //coin
        if (col.gameObject.tag == "coin"){
            coins++;
            Debug.Log(coins);
            Destroy(col.gameObject);
            score.text = ( "Score: " + coins);
        }
        if (col.gameObject.tag == "BadMushroom"){
            movement.runSpeed = 60f;
            controller.m_JumpForce = 400f;
            ChangeSprite(spriteRenderer[0], NewSprite);
            ChangeSprite(spriteRenderer[1], NewSprite);
            ChangeSprite(spriteRenderer[2], NewSprite);

        }

        if (col.gameObject.tag == "GoodMushroom"){
            movement.runSpeed = 40f;
            controller.m_JumpForce = 600f;
            ChangeSprite(spriteRenderer[0], NormalSprite);
            ChangeSprite(spriteRenderer[1], NormalSprite);
            ChangeSprite(spriteRenderer[2], NormalSprite);

        }
    }
    
    void Die()
    {
        Destroy(playerCapsule);
        GameOverText.text = "Game Over!";
        go = GameObject.FindGameObjectWithTag("Creator");
        go.GetComponent<ButtonCreator>().CreateButton();
    }

    void ChangeSprite(SpriteRenderer Object, Sprite NewSprite){

        Object.sprite = NewSprite;
    }
}
