using System.Collections.Generic;
using UnityEngine;

public class mudanca : NewMonoBehaviourScript
{
    void Update()
    {
        
    }
    void OnTggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            spawnPointAtual = player.transform.position;
        }
        //colidder = player.transform.position;
    }
} 

