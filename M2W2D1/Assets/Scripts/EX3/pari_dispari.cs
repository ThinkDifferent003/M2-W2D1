using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        if (number % 2 == 0)
        
           {Debug.Log("Il numero " + number + " è pari.");}
        
        else
           {Debug.Log("Il numero " + number + " è dispari.");}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
