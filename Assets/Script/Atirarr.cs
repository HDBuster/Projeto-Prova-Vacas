using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Atirarr : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false); // Começar com o raio desativado
    }

    public void OnFire(InputAction.CallbackContext context) //Este é chamado (invoke) no InputSystem em Nave
    {
        switch (context.phase) //Fases da interação Hold
        {
            case InputActionPhase.Performed: //Enquanto a segurar o clique, ative
                gameObject.SetActive(true);
                break;
            case InputActionPhase.Started: //Quando clicar, ative
                gameObject.SetActive(true);
                break;
            case InputActionPhase.Canceled: //Quando não estiver clicando, desative
                gameObject.SetActive(false);
                break;
        }
    }
}
