using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coin_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        ++Coin.coin_count;
        
    }

    private void OnTriggerEnter(Collider col )
    {
        if(col.CompareTag("Player"))
            Destroy(gameObject);
        
    }

    // Update is called once per frame
    void OnDestroy()
    {
        --Coin.coin_count;
        if (Coin.coin_count <= 0)
        {
            //we won
            GameObject Timer = GameObject.Find("Level_timer");
            Destroy(Timer);
            GameObject[] FireworkSystems = GameObject.FindGameObjectsWithTag("Fire");
            foreach (GameObject GO in FireworkSystems)
                GO.GetComponent<ParticleSystem>().Play();
        }
        
    }
}
