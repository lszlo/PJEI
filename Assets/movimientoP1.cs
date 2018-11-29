using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoP1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      
        
            Vector2 mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 new_player_position = new Vector2(mouse_position.x, transform.position.y);
            transform.position = new_player_position;

        

    }
}
