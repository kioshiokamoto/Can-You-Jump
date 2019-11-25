using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject enemigo;
    int numeroAleatorio;

    // Start is called before the first frame update
    void Start()
    {
        numeroAleatorio = Random.Range(4,21);
        InvokeRepeating("InstanciarEnemigos",numeroAleatorio,numeroAleatorio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstanciarEnemigos()
    {
        Instantiate(enemigo, transform.position, transform.rotation);
    }
}
