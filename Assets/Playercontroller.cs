

using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float speed;
    public float jumpSpeed;
    public int health;
    public bool isTouchingGround = false;
    // Start is called before the first frame update 
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newCameraPosition = new Vector3(transform.position.x,transform.position.y,-5);

        Camera.main.transform.position = newCameraPosition;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (isTouchingGround)
            {
                rigidBody.AddForce(Vector3.up * jumpSpeed);
            }
        }
    }
       
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Head Collider"))
        {
            Debug.Log("Process jumping on head");
            Destroy(other.gameObject.transform.parent.gameObject);        
        }

        if (other.tag.Equals("Ground"))
        {
            Debug.Log("Process Touching the ground");

            isTouchingGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
       if (other.tag.Equals("Ground"))
        {
            Debug.Log("Process Leaving the Ground");

            isTouchingGround = false;
        }
    }

    public void TakeDamage(int damage) 
    {
        health = health - damage;
        if (health <= 0)
        {
            Destroy(gameObject);


        }
              
    }
}
