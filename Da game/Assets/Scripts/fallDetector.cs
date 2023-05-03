using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDetector : MonoBehaviour
{
    
	public GameObject Player;
	
	private float posX = -13f;
	private float posY = 6f;
	
	// Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
		if(collision.gameObject.tag == "Player")
		{
			//Debug.Log("Player respawn");

			//remove object
			//Destroy(Player);
			//Debug.Log("Destroyed");

			//respawn 
			//posX = Player.flagX;
			//posY = Player.flagY;

			Vector2 newPosition = new Vector2(posX , posY);
			//Instantiate(Player, newPosition , Quaternion.identity);
			Player.transform.position = newPosition;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}




