using UnityEngine;

public class praga : NewMonoBehaviourScript //ele herda do script de respaw
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            morreu = true;  //so serve pra ativar esssa variavel dentro do outro script
        }
    }
}
