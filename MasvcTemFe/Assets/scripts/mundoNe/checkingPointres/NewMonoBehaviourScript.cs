using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] GameObject player;
   [SerializeField] Transform spawnPoint; // pega o transform do primeirro shakapoint 
   [SerializeField] float Queda; // pra ver se caiu do mapa 
   public bool morreu = false; // diz se rewpawna ou n 


    // Update is called once per frame
    void Update()
    {
        if(morreu)
        {
            Respau();
        }
    }
    void Respau()
    {
        player.transform.position = spawnPoint. position; //passa o valou de spawpoint inicial pro payer
        morreu = false;
    }
}
