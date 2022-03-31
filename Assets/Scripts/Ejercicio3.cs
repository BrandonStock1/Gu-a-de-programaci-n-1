using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    //3. Crear una variable pública que permita ingresar texto. Permitir que al ejecutar el programa se muestre en la consola un mensaje de saludo que incluya el texto de la variable.Por ejemplo, si en la variable se ingresa el texto “Ana”, el mensaje en consola debe decir “Hola Ana”.//

    // Start is called before the first frame update

    public string txt;

    void Start()
    {
        Debug.Log("Buenos dias " + txt + "!!! ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
