using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{
    [SerializeField] int vida;

    [SerializeField] int maximoVida;

    private void Start()
    {
        vida = maximoVida;
    }

    
    private void TomarDaño(int daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Curar(int curacion)
    {
        if((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }
    }
}