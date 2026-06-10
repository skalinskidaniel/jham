using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Butao : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public Portao Portao;

    //private bool abriu = false;
    //[SerializeField] public Portao acessoButao;
    [SerializeField] private Collider colliderMorre;
    void Awake()
    {
        colliderMorre = GetComponent<BoxCollider>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            animator.SetTrigger("butao");
            Portao.butao ++;
            Debug.Log(Portao.butao);
            Destroy(colliderMorre);
        }
    }
}
