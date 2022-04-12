//normal = 90 km x día
//lluvia = 110km x día
//$130 = 1l = 15km
//1km = 0,066l = 8,66666 (26/3)

//cantidad de taxis
//cantidad de días total
//cantidad de días de lluvia de esos días

//"Una flota de [cantidadDeUnidades] unidades trabajando durante [periodoDeDias] días implicará un
//gasto de [costoTotalCombustible] pesos en concepto de combustible".

//si días <5; negativa; días > días de lluvia --> mensaje de error + no cuentas


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejTema4 : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;
    public int diasDeLluvia;
    

    float precioLluvia = (130 / 15) * 110; // 953,33333
    float precioNormal = (130 / 15) * 90; // 
    int dias;

    float costoTotalCombustible;

    void Start()
    {
        dias = periodoDeDias - diasDeLluvia;
        if (periodoDeDias >= 5 && periodoDeDias > 0 && periodoDeDias >= diasDeLluvia)
        {
            costoTotalCombustible = cantidadDeUnidades * ((precioNormal * dias) + (precioLluvia * diasDeLluvia));

            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible");
        }
        else
        {
            Debug.Log("Ha ingresado valores incorrectos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
