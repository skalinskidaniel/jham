using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;
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
        Debug.Log("x é "+rb.linearVelocity.x);//te4ste
        Debug.Log("z é "+rb.linearVelocity.z);//teste
        Vector3 movimento =new Vector3(dire.x,0f,dire.y);//bota na variavel movimento onde ela deve ir 
        rb.MovePosition(rb.position + movimento * velo * Time.fixedDeltaTime); //faz a conta /move de vdd
        rodieiaSuave();
    }
    private void OnCollisionEnter(Collision collision)//se se to no chao dai posso pula
    {
        if(collision.gameObject.CompareTag("Chao"))
        {
            podePular = true;
        }
    }
    void rodieiaSuave()
    {
        if(dire !=Vector3.zero)
        {
            transform.forward = dire;
        }
       // if(new Vector2(rb.linearVelocity.x,rb.linearVelocity.z).magnitude>0f)
       // {
           // horizontalDire = new Vector3(rb.linearVelocity.x,0,rb.linearVelocity.z);
            //Quaternion rotation = Quaternion.LookRotation(horizontalDire,Vector3.up);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation,veloRotation);
       // }
    }

    
}
