
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
        private void OnTriggerEnter(Collider other)
        {
       

        if (other.tag.Equals("Player")) 
        {

            Playercontroller playerController = other.gameObject.GetComponent<Playercontroller>();
            playerController.TakeDamage(damage);

        }
                
        }



}







