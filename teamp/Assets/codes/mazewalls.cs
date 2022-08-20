using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazewalls : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D()
    {
         
         gameObject.GetComponent<SpriteRenderer>().enabled = false;
         gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
    void OnTriggerExit2D()
    {    
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        
    }
}
