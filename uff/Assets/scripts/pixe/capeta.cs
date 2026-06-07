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
        bicho.SetDestination(jogado.position);
        if(teleporta)
        {
            Debug.Log("respaw ta null");
            respaw.MorreudeQueda();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            animator.SetBool("bite",true);
            respaw = other.GetComponent<MataQueda>();
            teleporta = true;
        }
        
    }
}
