using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.InputSystem;

public class Temporizador : MonoBehaviour
{
    float tempoValor = 120f;
    public TextMeshProUGUI temporizador;
    public GameObject textoVitoria;
    public GameObject menuPausa;
    bool pausado = false;
    private bool pausa;
    
    // Start is called before the first frame update
    void Start()
    {
        textoVitoria.gameObject.SetActive(false);
        menuPausa.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (tempoValor > 0)
        {
            tempoValor -= Time.deltaTime;
        } else
        {
            tempoValor = 0;
            textoVitoria.gameObject.SetActive (true);

            Time.timeScale = 0;
        }

        MostrarTempo(tempoValor);

        if (pausa)
        {
            pausado = !pausado;
            Time.timeScale = pausado ? 0 : 1;
            menuPausa.SetActive(pausado);
        }
    }

    void MostrarTempo(float tempoMostrar)
    {
        if (tempoMostrar < 0) 
        { 
            tempoMostrar = 0;
        }

        float minutos = Mathf.FloorToInt(tempoMostrar / 60);
        float segundos = Mathf.FloorToInt(tempoMostrar % 60);

        temporizador.text = "Tempo: " + string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void OnPausa(InputAction.CallbackContext context)
    {
        pausa = context.performed;
    }
}
