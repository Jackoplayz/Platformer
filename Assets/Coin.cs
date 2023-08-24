using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag.Equals("Player"))
        {

            Playercontroller playerController = other.gameObject.GetComponent<Playercontroller>();
            playerController.TakeDamage(damage);
            Destroy(gameObject);
        }

    }    
}

