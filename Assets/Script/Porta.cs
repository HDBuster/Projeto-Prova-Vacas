using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Vaca"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
