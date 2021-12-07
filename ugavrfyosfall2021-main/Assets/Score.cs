using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("basketball"))
        {
            score++;
        }
    }

    void OnTriggerEnter()
    {
        score++;
    }
}
