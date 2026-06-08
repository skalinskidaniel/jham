using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
public class MovimentacaoV2 : MonoBehaviour
{
    private Vector3 horizontalDire;
    private Rigidbody rb;
    private Animator animator;
    private Vector3 dire;
    public float velo = 5f;
    private float veloRotation = 50f;
    public float forcaPulo = 15f;
    private bool podePular = true;
    [SerializeField] private AudioSource passossource;
    [SerializeField] private AudioClip[] passosVariacao;
    [SerializeField] private AudioSource PuloSouce;
    [SerializeField] private AudioClip[] PuloVariacao;
    [SerializeField] private AudioClip[] caiuvariacao;
    [SerializeField] private AudioSource CaiuSouce;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    void OnMove(InputValue value)
    {
        dire = value.Get<Vector2>();//ta lendo/guardando os input
        animator.SetBool("Andando",dire !=Vector3.zero);   
    } 
    void OnPulo(InputValue value)
    {
        if(value.isPressed && podePular)// se a ação ta sendo feita e eu posso pula
        {
            rb.AddForce(Vector3.up * forcaPulo,ForceMode.Impulse);//bota força pra cima
            podePular = false;
            animator.SetTrigger("Pulei");
        }
    }

    private void FixedUpdate()
    {
        Vector3 movimento =new Vector3(dire.x,0f,dire.y);//bota na variavel movimento onde ela deve ir 
        rb.MovePosition(rb.position + movimento * velo * Time.fixedDeltaTime); //faz a conta /move de vdd
        rodieiaSuave();
       // if(podePular == false)
        //{
           // animator.SetBool("EstanoChao",false);
        //}
    }
    private void OnCollisionEnter(Collision collision)//se se to no chao dai posso pula
    {
        if(collision.gameObject.CompareTag("Chao"))
        {
            podePular = true;
            animator.SetBool("EstanoChao",true);
           // CaiuSom();
        }
       
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Chao"))
        {
            podePular = false;
            animator.SetBool("EstanoChao",false);
        }
    }
    void rodieiaSuave()
    {
        if(dire !=Vector3.zero)
        {
            transform.forward = new Vector3(dire.x,0,dire.y);
        }
    }
    private void Passos() // pra toca os som definidos na animação algume fora eu leu minhas anotações ? eu me sinto o thanos em ultimato quando vira fazendeiro
    {
        passossource.PlayOneShot(passosVariacao[Random.Range(0,passosVariacao.Length)]);
    }
    private void PuloSom()
    {
        PuloSouce.PlayOneShot(PuloVariacao[Random.Range(0,PuloVariacao.Length)]);
    }
    private void CaiuSom()
    {
        CaiuSouce.PlayOneShot(caiuvariacao[Random.Range(0,caiuvariacao.Length)]);
    }
    
}
