using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    Animator m_Animator;
    public Animator animatorPuerta;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    public void OnPointerClick(Vector3 poss)
    {
        Debug.Log("animandooo");
        m_Animator.SetTrigger("Pulsado");
        animatorPuerta.SetTrigger("botonpulsado");
    }
}
