using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            CoinsRBs[i] = Coins[i].GetComponent<Rigidbody>();
            if(CoinsRBs[i].velocity.x > 0)
            {
                ActivateCoin(Coins[i]);
            }
            if(Coins[i] == activeCoin && CoinsRBs[i].velocity.x > 0)
            {
                //Calculate Distance to goal
                    //print distance to goal
            }
       }
    }

    // Update is called once per frame
    void Update()
    {
        //Check if any quarters have made it in the goal
        for (int i = 0; i < Coins.Length; i++)
        {
            if(Coins[i].)
            if(goal.bounds.Contains(Coins[i].transform.position))
            {
                Victory();
            }
        }


       
    }
    public void ActivateCoin(GameObject coin)
    {
        //remove highlight from current active coin

        //reassign activeCoin
        activeCoin = coin;

        //add highlight to new activeCoin
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
        Debug.Log("Coin Reset Called");
    }
    public void ResetLevel()
    {
        //set coins to their starting positions
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings);
        Debug.Log("Coin Reset Called");
    }


}
