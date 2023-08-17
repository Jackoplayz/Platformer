
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        string logMessage = "Enemy collided with " + other.name;

        Debug.Log(logMessage);

    }



}







