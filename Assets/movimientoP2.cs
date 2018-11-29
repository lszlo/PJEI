using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoP2 : MonoBehaviour {
    public float speed = 1.5f;
    private Vector3 target;
    // Use this for initialization
    void Start () {
        target = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           
        }
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
