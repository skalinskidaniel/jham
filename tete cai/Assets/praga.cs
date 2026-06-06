using UnityEngine;

public class praga : NewMonoBehaviourScript
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("prayer ta aqui desgraçado sem mãe");
            morreu = true;
        }
    }
}
