using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComidaDeAnimalitosUI : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCantDias;
    string codigo;
    int cantDias;
    int comidaPerrosPeq = 400;
    int comidaPerrosGrandes = 700;
    int comidaGatos = 300;
    int comidaAnimalIndicado;
    int cantComidaTotal;
    int precioTotal;
    int precioPorCienGramos;


    void Start()
    {
        txtResultado.text = string.Empty;
    }

    public void CalcularComida()
    {
        if (inputCantDias.text == "")
        {
            txtResultado.text = "Ingrese una cantidad de dias";
            return;
        }
        if (inputCodigo.text == "")
        {
            txtResultado.text = "Ingrese un codigo";
            return;
        }

        codigo = inputCodigo.text;
        cantDias = int.Parse(inputCantDias.text);

        if (cantDias < 3)
        {
            txtResultado.text = "La cantidad de días no puede ser menos que 3";
        }

        if (codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            txtResultado.text = "Código no válido";
            return;
        }

        if (inputCodigo.text == "PP")
        {
            comidaAnimalIndicado = comidaPerrosPeq;
        }
        else if (inputCodigo.text == "G")
        {
            comidaAnimalIndicado = comidaGatos;
        }
        else if (inputCodigo.text == "PG")
        {
            comidaAnimalIndicado = comidaPerrosGrandes;
        }
        cantComidaTotal = comidaAnimalIndicado * cantDias;
        precioTotal = cantComidaTotal / 100 * precioPorCienGramos;
        txtResultado.text = "Para el período de " + cantDias + " días se necesitan " + cantComidaTotal + "gramos de alimento, qie saldrán $" + precioTotal;
    }
}


