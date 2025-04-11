using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public string saborHelado;
    public float cantGramos;

    float resultado;
    float costoGramo = 1.25f;

    // Start is called before the first frame update
    void Start()
    {
        if (saborHelado != "DDL" && saborHelado != "CHO" && saborHelado != "FRU")  //si el sabor es diferente a esos 3
        {
            Debug.Log("Sabor de helado no valido");
            return;
        }

        if (cantGramos < 250 || cantGramos > 3000) {  //si el numero es menor a 250 o mayor a 3000
            Debug.Log("Cantidades no validas");
            return;
        }

        if (saborHelado == "DDL" || saborHelado == "CHO") //si el sabor es DDL o CHO 
        {
            resultado = costoGramo * cantGramos;
            Debug.Log("Tu helado cuesta: " + resultado + "$");

        } else if (saborHelado == "FRU") {   //si el sabor es fRU (es diferente porque haces el 10%)
            resultado = (costoGramo * cantGramos)*0.9f;
            Debug.Log("Tu helado cuesta: " + resultado + "$");

        }
     


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
