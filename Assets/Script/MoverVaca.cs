using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverVaca : MonoBehaviour
{
    public float velocidade;

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = new Vector2(-1, 0) * velocidade * Time.fixedDeltaTime;
        transform.Translate(Vector2.left * velocidade * Time.fixedDeltaTime);
    }
}
