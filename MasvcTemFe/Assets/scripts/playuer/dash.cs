using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class dash : MonoBehaviour
{
    public bool Dashe = false;//isso aqui diz se esta no dash ou n 
    private float forcaDashe = 15;
    private Rigidbody rb;
    private float tempo = 0f;// é tempo q elel vai receber essse embalo /força etc
    private float AnimTempo = 0.817f;//aqui é o tempo q dura a nimação de dash/rool oq for 
    private Animator animator;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
   void OnDash()
    { 
        Debug.Log("rolei");
        if(!Dashe)
        {
            StartCoroutine(Dash());
        }
    }
   IEnumerator Dash()
    {
        Debug.Log("puxo a função");
        Dashe = true; //quando chama ele avisa q agr esta em dash 
       //cc.height//puxei o cc aqui pq dependendo de como for a animação eu vou ter q diminuir o collider exemplo cambalhota
       animator.SetTrigger("dash");
        while(tempo<AnimTempo)
        { 
            Debug.Log("to deshando de fato");
            rb.AddForce(new Vector3(0,forcaDashe,0));//aqui ocorre de fato o dash transform.forward * Time.deltaTime
            tempo+= Time.deltaTime;
            yield return null;//aqui ele espera o outro frama mas no geral é pra parar o while
        }
       tempo = 0f;
       yield return new WaitForSeconds(5f);//aqui é colldow(esperarar o proximo n sei escrever essa palavra) do dash porém tem q adaptar pq nois ta com sytem proprio ent tem q de algum jeito fazer ele esperarr pra chamar
       Dashe = false;
    }
}
