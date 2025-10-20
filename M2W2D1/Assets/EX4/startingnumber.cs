using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingnumber : MonoBehaviour
{
    public int startingNumber=10;
    // Start is called before the first frame update
    void Start()
    {
        int result = startingNumber+1;
        int result2 = startingNumber+2;
        Debug.Log("Il numero dopo è: " + result);
        Debug.Log("Il numero dopo dopo è: " + result2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
