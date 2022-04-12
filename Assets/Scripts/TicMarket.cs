using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{


    public string nombre1;
    public string nombre2;
    public string nombre3;

    public int precio1;
    public int precio2;
    public int precio3;

    public int cantidadproct1;
    public int cantidadproct2;
    public int cantidadproct3;

    float  sumaprodct1;
    float  sumacant1;
   float   sumaprodct2;
    float sumacant2;
    float sumaprodct3;
    float  sumacant3;
    float tot2;
    float tot1;
    float tot3;
    float totalfinal;
    float totsindesct;
    float totdesc;
    // Start is called before the first frame update
    void Start()
    {
        sumacant1 = (cantidadproct1 * precio1);
        
        
        
        sumacant2 = (cantidadproct2 * precio2);
        
        

        sumacant3 = (cantidadproct3 * precio3);
        
        

        if (cantidadproct1 >= 3)
        {
            sumaprodct1 = (sumacant1 * 0.2f);
        }
        else
        {
            Debug.Log("no se aplica el desucneto");

        }

        if (cantidadproct2 >= 3)
        {
           sumaprodct2 = (sumacant2 * 0.2f);
        }
        else
        {
            Debug.Log("no se aplica el desucneto");

        }

        if (cantidadproct3 >= 3)
        {
          sumaprodct3 = (sumacant3 * 0.2f);
        }
        else
        {
            Debug.Log("no se aplica el desucneto");
        }
        tot1 = sumacant1 - sumaprodct1;
        tot2 = sumacant2 - sumaprodct2;
        tot3 = sumacant3 - sumaprodct3;


        totalfinal = tot1 + tot2 + tot3;
        totsindesct = sumacant1 + sumacant2 + sumacant3;
        totdesc = sumaprodct1 + sumaprodct2 + sumaprodct3;
        Debug.Log("El monto total con descuntos es de $" + totalfinal);
        Debug.Log("El monto total sin descuntos es de $" + totsindesct);
        Debug.Log("El monto total de los descuntos es de $" + totdesc); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
