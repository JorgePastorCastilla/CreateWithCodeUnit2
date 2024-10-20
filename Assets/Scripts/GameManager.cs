using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> listaDePrefabs;
    private List<GameObject> matados;
    private bool hasPerdido;
    private bool hasGanado;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPerdido)
        {
            Debug.Log("HAS PERDIDO");
        }else if (hasGanado)
        {
            Debug.Log("HAS GANADO");
        }
    }

    void Matar(GameObject objeto)
    {
        if ( Contiene(objeto, matados) )
        {
            hasPerdido = true;
        }
        else 
        {
            matados.Add(objeto);
            if (matados.Count == listaDePrefabs.Count)
            {
                hasGanado = true;
            }
        }
    }

    bool Contiene(GameObject objeto, List<GameObject> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if (objeto == lista[i])
            {
                return true;
            }
        }
        return false;
    }
}
