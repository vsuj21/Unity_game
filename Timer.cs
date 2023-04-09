using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;
    [SerializeField]
    private float CountDown = 0;
    // Start is called before the first frame update
    void Start()
    {
        CountDown = MaxTime;

    }

    // Update is called once per frame
    void Update()
    {
        CountDown -= Time.deltaTime;
        if (CountDown <= 0)
        {
            Coin.coin_count = 0;
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
