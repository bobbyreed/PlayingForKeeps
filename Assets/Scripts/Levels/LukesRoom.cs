using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LukesRoom : Level
{
    
    
    // Start is called before the first frame update
    void Start()
    {
       goal = goalObject.GetComponent<Collider>();
       //create array of transforms the same size as number of coins
       CoinStarts = new Transform[Coins.Length];
       //assign start transforms to CoinStarts
       for (int i = 0; i < Coins.Length; i++)
       {
            CoinStarts[i] = Coins[i].transform;
       }
    }

    // Update is called once per frame
    void Update()
    {
        //Check if any quarters have made it in the goal
        for (int i = 0; i < Coins.Length; i++)
        {
            if(goal.bounds.Contains(Coins[i].transform.position))
            {
                Victory();
            }
        }
       
    }

    public void Victory()
    {
        Debug.Log("Victory!");
    }

    public void ResetCoins()
    {
        //set coins to their starting positions
        for (int i = 0; i < Coins.Length; i++)
        {
            Coins[i].transform.position = CoinStarts[i].position; 
        }
    }
}
