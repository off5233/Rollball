using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision Des)
    {
        if (Des.gameObject.name == "Player")
        {
            ScoreText.score += 1;
            Destroy(gameObject);
        }
    }
}
