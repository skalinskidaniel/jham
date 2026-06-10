using UnityEngine;

public class Portao2 : MonoBehaviour

{
    [SerializeField]private GameObject ColliderPort;
    [SerializeField]private Animator animatorPort;
    
    //[SerializeField] private Butao acessoButao;

    // Update is called once per frame
    void Update()
    {

    }
    public void AbrirPort()
    {
        animatorPort.SetBool("POrtao",true);
        ColliderPort.GetComponent<BoxCollider>().enabled = false;
    }
}
