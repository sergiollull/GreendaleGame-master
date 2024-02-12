using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 2000000000000f;
    
    private Rigidbody2D _rigidBody2D;
    private BoxCollider2D boxCollider2D;
    void Start()
    {
        
    }
    private void Awake()
    {
        _rigidBody2D = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        CalculateMovements();

        
    }
    void CalculateMovements()
    {
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (transform.position.x > 1543.0f)
            {
                //Debug.Log("Right exceed");
                transform.position = new Vector3(1543.0f, transform.position.y, 0);
            }
            else
            {
                transform.position += Vector3.right * movementSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {

            if (transform.position.x < 40.0f)
            {
                //Debug.Log("Left exceed");
                transform.position = new Vector3(40.0f, transform.position.y, 0);
            }
            else
            {
                transform.position += Vector3.right * -movementSpeed * Time.deltaTime;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Fly");
            float jumpVelocity = 200f;
            _rigidBody2D.velocity = Vector2.up * jumpVelocity;
            
        }
    }

}
