using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // Variable to let us add to score
    //public so we can drag & drop
   public Score scoreObject;

    // Variable to hold the coins point value 
    //public so we can change in editor 
    public int coinValue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Unity calls this funcition when our coin touches any other object 
    // If the player touches coin, score goes up

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we touched is the player
        PlayerScript playerScript = collision.collider.GetComponent<PlayerScript>();

        //if the thing we toyuched has a player script that means it is a player
        if (playerScript)
        {
            //We hit the player
            // Add to the score based on value
           scoreObject.AddScore(coinValue);
            //Destory the gameObject that is attached to the script 
            Destroy(gameObject);
        }
    }


}
