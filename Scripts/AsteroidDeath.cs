using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDeath : Death
{
    public int scoreIncreaseAmount;

    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    public override void Die()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ReduceAsteroidCountByOne();

            GameManager.instance.IncreaseScore(scoreIncreaseAmount); 

            Destroy(gameObject);
        }
    }
}
