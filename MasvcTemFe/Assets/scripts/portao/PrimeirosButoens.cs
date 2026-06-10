using System.Runtime.Serialization;
using UnityEngine;

public class PrimeirosButoens : MonoBehaviour
{
    [SerializeField]private Animator animator;
    [SerializeField]private Animator animatorPort;
    [SerializeField]private GameObject ColliderPort;
    private float botoens = 0f;
    private bool abriu  = false;
    void Awake()
    {
       animator=GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            animator.SetTrigger("butao");
            botoens +=1f;
        }
        if(botoens>= 2f&&!abriu)
        {
            abriu = true;
            Portao();
           
        }
    }
    void Portao()
    {
        animatorPort.SetBool("POrtao",true);
        ColliderPort.GetComponent<BoxCollider>().enabled = false;

    }
}
