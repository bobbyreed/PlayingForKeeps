using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Collider goal;
    public GameObject goalObject;
    public GameObject[] Coins;
    public Rigidbody[] CoinsRBs;
    public Transform[] CoinStarts;
    public GameObject activeCoin;

    // Start is called before the first frame update
    void Start()
    {
        
       goal = goalObject.GetComponent<Collider>();
       //create array of transforms the same size as number of coins
       CoinStarts = new Transform[Coins.Length];
       CoinsRBs = new Rigidbody[Coins.Length];
       //assign start transforms to CoinStarts
       for (int i = 0; i < Coins.Length; i++)
       {
            CoinStarts[i] = Coins[i].transform;
            CoinsRBs[i] = Coins[i].GetComponent<Rigidbody>();
            //Debug.Log("Coin " + i + " Rigidbody is " + CoinsRBs[i]);            
       }
       ActivateCoin(Coins[0]);
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
        SceneManager.LoadScene(0);
        Debug.Log("Level Reset Called");
    }



}
