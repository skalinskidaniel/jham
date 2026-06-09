using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TrocadeMundos : MonoBehaviour
{
    [SerializeField]private GameObject MundoA;
    [SerializeField]private GameObject MundoB;
    [SerializeField]private RawImage anim;
    [SerializeField] private AudioSource TrocaSouce;
    [SerializeField] private AudioClip[] TrocaVaria;
    private bool estouMundA = true;
   // private float alfa = 0f;
    private float tempo = 2f;
    void Start()
    {
        Clarear();
    }
    void OnMundos()
    {
        estouMundA = !estouMundA; //ela recebe o contrario dela mesma toda vez q chamada
        if(estouMundA)
        {
            StartCoroutine(Animacao());  //da stard pra couratine
            StartCoroutine(DesRespaw());
           
        }
        if(!estouMundA)
        {
            StartCoroutine(Animacao()); 
            StartCoroutine(Respaw());
        }
    }
    void Escurecer()
    {
        anim.CrossFadeAlpha(1,0.90f, true);//faz o canva ficar ruggnes em 0..90 s
    }
    void Clarear()
    {
        anim.CrossFadeAlpha(0,0.90f, false);//faz o canva ficar transparente 
    }
    IEnumerator Animacao()
    {   trocaSom();
        Escurecer();
        yield return new WaitForSeconds(1.50f);//espera um tempo
        Clarear();
    }
    IEnumerator Respaw()
    {
        //PodeAndar = false;//faz o player n poder masi andar 
        yield return new WaitForSeconds(1.5f);
        MundoB.SetActive(true);//ativa mundo B
        MundoA.SetActive(false);//desatia o mundo A
        
        //yield return new WaitForSeconds(3.5f);
        //PodeAndar = true;
    }
    IEnumerator DesRespaw()
    {
        //PodeAndar = true;
        yield return new WaitForSeconds(1.5f);
        MundoB.SetActive(false);
        MundoA.SetActive(true); // a brisa nesses 2 era travo o player dai mudo o mundo ai destravo o player dps q clariar

        //yield return new WaitForSeconds(3.5f);//por isso aquii é maior 
        //PodeAndar = false;
    }
    void trocaSom()
    {
        TrocaSouce.PlayOneShot(TrocaVaria[Random.Range(0,TrocaVaria.Length)]);
    }
}
