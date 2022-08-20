using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planecamera : MonoBehaviour
{
   Rigidbody2D body;

    float horizontal;
    

    public float runSpeed = 10.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed,0);   
    }
}
