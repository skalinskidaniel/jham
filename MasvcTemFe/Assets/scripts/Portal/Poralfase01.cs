using UnityEngine;
using UnityEngine.SceneManagement;

public class Poralfase01 : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("fase_02");
        }
    }
}
