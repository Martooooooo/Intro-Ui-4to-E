using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    public TMP_InputField inputUsuario;
    string usuario = "MartoBiosca";
    string clave = "tic2025";
    // Start is called before the first frame update
    void Start()
    {
       txtMensaje.text= "";
    }

    public void ComprobarClaveIngresada()
    {
        string ClaveIngresada = inputClave.text;
        string UsuarioIngresado = inputUsuario.text;
        if (ClaveIngresada != clave || UsuarioIngresado != usuario)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
        }
        else if (ClaveIngresada == clave && UsuarioIngresado == usuario)
        {
            txtMensaje.text = " Bienvenido";

        }

    }
}
