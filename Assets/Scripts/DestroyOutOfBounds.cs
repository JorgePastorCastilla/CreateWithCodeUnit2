using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30f;
    public float lowerBound = -10f;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound )
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound)
        {
            if (!gameManager.IsValidOutOfBounds(gameObject) )
            {
                gameManager.hasPerdido = true;
            }
            Destroy(gameObject);
        }
    }
}
