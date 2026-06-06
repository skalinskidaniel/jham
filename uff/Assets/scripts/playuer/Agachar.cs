using UnityEngine;
using UnityEngine.InputSystem;

public class Agachar : MonoBehaviour
{
    private CapsuleCollider cc;
    private Animator animator;
    
    private bool Agachado = true;
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; //trava o mause 
        Cursor.visible = false;//esconde o mause
        cc = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
    }

    void OnAgachar() //caso esteje confuso a logica é agachado tem valor 2 dai quando eu chamo esse metodo ele inverte o valor de agachado q diminui ele
    {
        Agachado =!Agachado;

        if(!Agachado)
        {
            animator.SetBool("agachando",false);
            cc.height  = 3.9f;//pra pra garantir eu to acessando a heigth do cc ai mexo direto no tamanho dele
        }
        if(Agachado)
        {   
            animator.SetBool("agachando",true);
            cc.height = 2.50f;
        }
       //funny fact quando eu tava arrumando  todas as mecanicas pro rb eu descobri aqui q colider tem .height eu achava e isso so rodava no character 
    }
}
