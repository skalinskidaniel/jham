using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class dash : MonoBehaviour
{
    public bool Dashe = false;//isso aqui diz se esta no dash ou n 
    private CharacterController cc;
    private float tempo = 0f;// é tempo q elel vai receber essse embalo /força etc
    private float AnimTempo = 0.817f;//aqui é o tempo q dura a nimação de dash/rool oq for 
    private Animator animator;
    void Awake()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
   void OnDash()
    {
        animator.SetTrigger("dash");   
        Debug.Log("rolei");
        StartCoroutine(Dash());
    }
   IEnumerator Dash()
    {
        Debug.Log("tadeshando");
        Dashe = true; //quando chama ele avisa q agr esta em dash 
       //cc.height//puxei o cc aqui pq dependendo de como for a animação eu vou ter q diminuir o collider exemplo cambalhota
        while(tempo<AnimTempo)
        {
            cc.Move(5* transform.forward * Time.deltaTime);//aqui ocorre de fato o dash
            tempo+= Time.deltaTime;
            yield return null;//aqui ele espera o outro frama mas no geral é pra parar o while
        }
       tempo = 0f;
       yield return new WaitForSeconds(5f);//aqui é colldow(esperarar o proximo n sei escrever essa palavra) do dash porém tem q adaptar pq nois ta com sytem proprio ent tem q de algum jeito fazer ele esperarr pra chamar
       Dashe = false;
    }
}
