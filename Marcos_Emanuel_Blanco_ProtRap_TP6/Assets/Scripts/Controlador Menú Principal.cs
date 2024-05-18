using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenúPrincipal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoInstrucciones;
    private bool aux;
    private void Start()
    {
        aux = false;
        textoInstrucciones.gameObject.SetActive(aux);
    }
    public void CargarSiguienteEscena()
    {
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceEscenaActual + 1);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void MostrarControles()
    {
        aux = !aux;
        textoInstrucciones.gameObject.SetActive(aux);
    }

}
