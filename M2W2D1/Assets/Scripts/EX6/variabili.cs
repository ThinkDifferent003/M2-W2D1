using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variabili : MonoBehaviour
{
    public int number = 5;
    public int number2 = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (number < number2)
        {
            Debug.Log(+ number2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
