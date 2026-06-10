using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal03 : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("fase_03");
        }
    }
}
