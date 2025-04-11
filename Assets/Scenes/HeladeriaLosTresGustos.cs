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
        if (saborHelado != "DDL" && saborHelado != "CHO" && saborHelado != "FRU")
        {
            Debug.Log("Sabor de helado no valido");
            return;
        }

        if (cantGramos < 250 && cantGramos > 3000) {
            Debug.Log("Cantidades no validas");
            return;
        }

        if (saborHelado == "DDL" || saborHelado == "CHO")
        {
            resultado = costoGramo * cantGramos;
            Debug.Log(resultado);

        } else if (saborHelado == "FRU") {
            resultado = cantGramos - (costoGramo * 0.10f);
            Debug.Log(resultado);

        }
     


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
