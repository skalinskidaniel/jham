using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] public GameObject player;
   [SerializeField] Transform spawnPoint;
    public Vector3 spawnPointAtual;
   [SerializeField] float spawValue;
   public bool morreu = false;


    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < spawValue)
        {
            VooltaCaiu();
        }
        if(morreu)
        {
            Debug.Log("aqui vai");
            Respau();
        }
    }
    void Respau()
    {
        player.transform.position = spawnPoint. position;
        morreu = false;
    }
    void VooltaCaiu()
    {
     player.transform.position = spawnPointAtual;
    }
}
