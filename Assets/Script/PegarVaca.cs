using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PegarVaca : MonoBehaviour
{
    private float conta = 0;
    public TextMeshProUGUI contarTexto;

    void Start()
    {
        SetCountText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vaca"))
        {
            collision.gameObject.SetActive(false);
            conta++;
            SetCountText();
        }
    }

    private void SetCountText()
    {
        contarTexto.text = "Vacas: " + conta.ToString();
    }
}
