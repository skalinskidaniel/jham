using System.Collections.Generic;
using UnityEngine;

public class shakaQueda : MonoBehaviour
{[SerializeField] public List<GameObject> colliders;
 [SerializeField] public Vector3 respawAtual;
 [SerializeField] public GameObject player;
public bool caiu= false;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            respawAtual = transform.position;
            Debug.Log("shakapoint slavo "+respawAtual);
        }
    }   
}   
