using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{

    // 6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que en una variable llamada num1 y muestre un mensaje por pantalla indicando &quot;el número es par&quot; o &quot;el número es impar&quot;. Deberá utilizar el operador “módulo” es el caracter %. //

    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        int sobrante;
        sobrante = num1 % 2;
        if (sobrante == 0)
        {
            Debug.Log("El numero es par");
        }
        else
        {
            Debug.Log("El numero es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
