using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneto : MonoBehaviour {
    
   
   
    void Start()
    {
       
        
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.transform.tag);
        if (other.gameObject.tag == "magnetico")
        {
            other.transform.parent = transform;
        }
    }
    
       
    
          

}

