using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class Movimentacao : MonoBehaviour
{//se alguem precisar mexer nos q eu fiz ja to deixando comentado mas me pergunta q explico melhor 
    public CharacterController cc;
    public Vector2 Input;//os input do player
    private Vector3 veloGravidade;//gravidade 
    public float velo = 5f;
    public float gravidade = -1.15f;//"força" da gravidade (curiosidade nois tem a mesma gravidade de mario 64)
    private Vector3 dire ;//DIREção pego aqui eu guardo a direção q quero ir pelo menos por enquanto
    private float veloRotation = 50f;
    private Animator animator;
    void Awake()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    
    }

    void Update()
    {
        dire = transform.right *Input.x+transform.forward*Input.y;//isso aqui da a direção soma os inputs
        
        cc.Move(dire*velo* Time.deltaTime); //por enquanto eu n lembro como funciona o normalized pra elel n correer masi rapido na diagonal dps vejo isso 
        
        animator.SetBool("Andando",dire !=Vector3.zero);   
        
        veloGravidade.y += gravidade *Time.deltaTime;
        
        cc.Move(veloGravidade*Time.deltaTime);//aqui ta puxando o player pra baixo so pra caso o pessoal se perca
        
        
        if(dire != Vector3.zero)//se o movimento for diferente de zer
        {
            Quaternion Rotacao = Quaternion.LookRotation(dire,Vector3.up);//rotacao ta guardando onde ele deve olha
            transform.rotation = Quaternion.RotateTowards(transform.rotation,Rotacao, veloRotation*Time.deltaTime);//faz ele roda 
           //transform.forward = dire; //rotação rui fudida e capenga estilo gta san andreas 
        }
    }

    public void OnMove(InputValue value)
    {
        Input = value.Get<Vector2>();
    }
}
