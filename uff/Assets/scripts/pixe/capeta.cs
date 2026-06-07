using UnityEngine;
using UnityEngine.AI;
public class capeta : MonoBehaviour
{
    private bool teleporta = false;
    private MataQueda respaw;
    public Animator animator;
    [SerializeField] private Transform jogado;
    [SerializeField] public NavMeshAgent bicho;
    void Awake()
    {
        bicho = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        bicho.SetDestination(jogado.position); //faz o bicho seguir o player pelo navmesh 
        if(teleporta)
        {
            respaw.MorreudeQueda();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            animator.SetBool("bite",true);
            respaw = other.GetComponent<MataQueda>(); // eu to acessando o script do outro e guardando em respw funny fact isso aqui é capetaria chinesa aprendi hj la naquele facebook da unity com o mesmo chines 
            teleporta = true;
        }
        
    }
}
