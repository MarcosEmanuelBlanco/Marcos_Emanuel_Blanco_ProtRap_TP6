using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorHUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoTiempoFinal;
    public void ActualizarTextoTiempoFinal(string nuevoTexto)
    {
        textoTiempoFinal.text = "Tu Tiempo Final: " + nuevoTexto;
    }
}
