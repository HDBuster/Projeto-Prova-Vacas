using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Atirarr : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false); // Come�ar com o raio desativado
    }

    public void OnFire(InputAction.CallbackContext context) //Este � chamado (invoke) no InputSystem em Nave
    {
        switch (context.phase) //Fases da intera��o Hold
        {
            case InputActionPhase.Performed: //Enquanto a segurar o clique, ative
                gameObject.SetActive(true);
                break;
            case InputActionPhase.Started: //Quando clicar, ative
                gameObject.SetActive(true);
                break;
            case InputActionPhase.Canceled: //Quando n�o estiver clicando, desative
                gameObject.SetActive(false);
                break;
        }
    }
}
