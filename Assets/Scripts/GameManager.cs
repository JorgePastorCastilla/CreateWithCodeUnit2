using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> listaDePrefabs;
    public List<string> matados = new List<string>();
    public bool hasPerdido;
    public bool hasGanado;
    public TMPro.TextMeshProUGUI WonLostLabel;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPerdido || hasGanado)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
        if (hasPerdido)
        {
            WonLostLabel.text = "HAS PERDIDO";
        }else if (hasGanado)
        {
            WonLostLabel.text = "HAS GANADO";
        }

        
    }

    public void Matar(GameObject objeto)
    {
        if ( Contiene(objeto, matados) )
        {
            hasPerdido = true;
        }
        else 
        {
            matados.Add(objeto.name);
            if (matados.Count == listaDePrefabs.Count)
            {
                hasGanado = true;
            }
        }
    }

    bool Contiene(GameObject objeto, List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if (objeto.name == lista[i])
            {
                return true;
            }
        }
        return false;
    }

    public bool IsValidOutOfBounds(GameObject objeto)
    {
        return Contiene(objeto, matados);
    }
}
