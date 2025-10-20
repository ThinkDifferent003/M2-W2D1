using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class negative : MonoBehaviour
{
    public int number = 10;
    // Start is called before the first frame update
    void Start()
    {
        int result = number - 1;
        int result2 = number - 2;
        Debug.Log("Il numero prima è: " + result);
        Debug.Log("Il numero prima prima è: " + result2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
