using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class pulo : MonoBehaviour
{
    private CharacterController cc;
    private Animator animator;
    private bool EstanoChao;
    [SerializeField]private Transform rednose;
    [SerializeField]private LayerMask colisaoLayer;
    private float forcaY;

    void Awake()
    {
        cc= GetComponent<CharacterController>();
        animator= GetComponent<Animator>();
    }
    void Update()
    {
        EstanoChao = Physics.CheckSphere(rednose.position,0.3f,colisaoLayer);
        if(forcaY>1.15f)
        {
            forcaY+=-1.15f*Time.deltaTime;
        }
        cc.Move(new Vector3 (0,forcaY,0)*Time.deltaTime);
    }
    void OnPulo()
    {
        forcaY = 15f;
        if(EstanoChao)
        {
            animator.SetTrigger("Pulei");
            Debug.Log("pulei");
            
            
        }
        

       // cc.AddForce(Vector3.up*forcaY*Time.deltaTime);
        //Vector3.up + forcaY
    }
}
