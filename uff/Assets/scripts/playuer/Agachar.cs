using UnityEngine;
using UnityEngine.InputSystem;

public class Agachar : MonoBehaviour
{
    private CharacterController cc;
    private Animator animator;
    
    private bool Agachado = true;
    void Awake()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void OnAgachar() //caso esteje confuso a logica é agachado tem valor 2 dai quando eu chamo esse metodo ele inverte o valor de agachado q diminui ele
    {
        Debug.Log("sentei");
        Agachado =!Agachado;

        if(!Agachado)
        {
            cc.height  = 3.9f;//pra pra garantir eu to acessando a heigth do cc ai mexo direto no tamanho dele
        }
        else
        animator.SetBool("agachando",true);
        cc.height = 2.50f;
       

    }
}
