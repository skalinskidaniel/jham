using Unity.Cinemachine;
using UnityEngine;

public class chekaButao : MonoBehaviour
{
    private bool abriu = false;
    [SerializeField] public Portao acessoPutao;
    [SerializeField] public Portao2 acessoPutao2;

    private bool todosButaoPrimeiro = false;
    private bool TODOS = false;
    private float primeiros = 0f;
    private float everybody = 0f;
    void Update()
    {
        if(primeiros >=2f)
        {
            todosButaoPrimeiro = true;
        }
        if(everybody>=5f)
        {
            TODOS = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("1"))
        {
            primeiros+=1f;
            everybody +=1f;
        }
        if(other.CompareTag("2"))
        {
            primeiros+=1f;
            everybody +=1f;
        }
        if(other.CompareTag("3"))
        {
            everybody +=1f;
        }
        if(other.CompareTag("4"))
        {
            everybody +=1f;
        }
        if(other.CompareTag("1"))
        {
            everybody +=1f;
        }
        if(todosButaoPrimeiro)
        {
            abriu = true;
            acessoPutao.AbrirPort();
        }
        if(TODOS)
        {
            abriu = true;
            acessoPutao2.AbrirPort();
        }
    }
}
