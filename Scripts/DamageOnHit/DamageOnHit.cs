using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{

    public float DamageInflicted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       starShipHealth starshipHealth = collision.GetComponent<starShipHealth>();
       
       if (starshipHealth != null )
        {
            starshipHealth.TakeDamage(DamageInflicted);

            Destroy(gameObject);
        }
    }
}
