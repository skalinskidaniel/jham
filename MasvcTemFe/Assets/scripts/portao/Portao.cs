using UnityEngine;

public class Portao : MonoBehaviour

{
    [SerializeField]private GameObject ColliderPort;
    [SerializeField]private Animator animatorPort;
    [HideInInspector] public int butao = 0;
    [SerializeField] public int QntBotao;
    
    //[SerializeField] private Butao acessoButao;

    // Update is called once per frame
    void Awake()
    {
        
    }
    void Update()
    {
        if (butao >= QntBotao)
        {
            AbrirPort();
        }
    }
    public void AbrirPort()
    {
        animatorPort.SetBool("POrtao",true);
        ColliderPort.GetComponent<BoxCollider>().enabled = false;
    }
}
