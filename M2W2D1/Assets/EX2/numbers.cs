using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbers : MonoBehaviour
{
    public int number1;
    public int number2;
    public int number3;
    public int number4;
    // Start is called before the first frame update
    void Start()
    {
        int somma = number1 + number2 + number3 + number4;
        int moltiplicazione = number1 * number2 * number3 * number4;
        int media = somma / 4;
        Debug.Log("La somma dei numeri è: " + somma);
        Debug.Log("La moltiplicazione dei numeri è: " + moltiplicazione);
        Debug.Log("La media dei numeri è: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
