using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

    //Movement
    public float speed;
    public float jump;
    int jumpavailable = 1;
    float moveVelocity;
    public int jumpsnumber = 1;
    public Transform player;
    

    void start(){jumpavailable = jumpsnumber;}

    void Update () 
    {
        //sitting
        if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.S)) 
        {
             Vector3 plp = player.position;
             plp.y -= 0.35f;
             player.position = plp;

             Vector3 pls = player.localScale;
             pls.y -= 0.35f;
             player.localScale = pls;
        }
        //Jumping
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
        {
            if(jumpavailable>0)
            {
                GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump); 
                jumpavailable--;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

    }
    //Check if Grounded
    void OnTriggerEnter2D()
    {
        jumpavailable = jumpsnumber;
    }
    
}