using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reapet_negative : MonoBehaviour
{
    public int startingNumber = 10;
    // Start is called before the first frame update
    void Start()
    {
        int result = startingNumber - 1;
        int result2 = startingNumber - 2;
        Debug.Log("Il numero prima �: " + result);
        Debug.Log("Il numero prima prima �: " + result2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
