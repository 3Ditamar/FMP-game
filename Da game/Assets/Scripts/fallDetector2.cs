using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDetector2 : MonoBehaviour
{
    
	public GameObject Player;
//	public GameObject FallDetectorObject;
	
	private float posX = 85f;
	private float posY = 2f;
	
	
	//private float posX = FallDetectorObject.transform.position.x;
	//private float posY = FallDetectorObject.transform.position.y +200f;
	
	
	//posX = posX - 0;
	//posY =- 200;
	
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




