using UnityEngine;
using UnityEngine.AI;
using System.Collections;
public class capeta : MonoBehaviour
{
    private bool teleporta = false;
    [SerializeField]private MataQueda respaw;
    public Animator animator;
    [SerializeField] private Transform jogado;
    [SerializeField] public NavMeshAgent bicho;
    [SerializeField] private AudioSource mordeu;
    [SerializeField] private AudioClip[] mordeuVariação;
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
            StartCoroutine(somMordida());
            respaw = other.GetComponent<MataQueda>();
            teleporta = true;
        }
        
    }
    void MordeuEvent()
    {
        mordeu.PlayOneShot(mordeuVariação[Random.Range(0,mordeuVariação.Length)]);
    }
    IEnumerator somMordida()
    {
        animator.SetBool("bite",true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("bite",false);
    }
}
