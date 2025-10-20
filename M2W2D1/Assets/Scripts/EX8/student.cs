using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class student : MonoBehaviour
{
    public int voto;
    // Start is called before the first frame update
    void Start()
    {
        if (voto == 10)
            Debug.Log("A");
        else if (voto == 9)
            Debug.Log("B");
        else if (voto == 8)
            Debug.Log("C");
        else if (voto == 7)
            Debug.Log("D");
        else if (voto == 6)
            Debug.Log("E");
        else
            Debug.Log("F");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
