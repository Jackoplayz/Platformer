
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
   
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

        private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.tag.Equals("Player")) 
        {

            Playercontroller playerController = other.gameObject.GetComponent<Playercontroller>();
            playerController.TakeDamage(damage);

        }
                
    }



}







