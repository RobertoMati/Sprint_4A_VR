using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public Animator animatorBoton;
    public Animator animatorPuerta;
    

    public void OnPointerClick(Vector3 poss)
    {
        Debug.Log("animandooo");
        animatorBoton.SetTrigger("Pulsado");
        animatorPuerta.SetTrigger("botonpulsado");
    }
}
