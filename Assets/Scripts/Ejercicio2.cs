using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    //2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: //
    // a.Suma //
    // b.Producto //
    

    // Start is called before the first frame update
    void Start()
    {
        int num1 = 4;
        int num2 = 5;
        int res;
        res = num1 + num2;
        Debug.Log("El resultado de sumar el " + num1 + " y " + num2 + ", es " + res);
        res = num1 * num2;
        Debug.Log("El resultado de multiplicar el " + num1 + " y " + num2 + ", es " + res);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
