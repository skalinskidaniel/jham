using UnityEngine;

public class MataQueda : shakaQueda
{
    [SerializeField]private Rigidbody rb;
   [SerializeField]private shakaQueda Caminhoderato;
    void Awake()
    {
        rb = player.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("ta entrando no tigre");
            caiu = true;
        }
    } 
    void Update()
    {
        if(caiu)
        {
            MorreudeQueda();
        }
    }
    public void MorreudeQueda()
    {
        rb.linearVelocity = Vector3.zero;       
        rb.angularVelocity = Vector3.zero;
        Debug.Log("vc vai para "+ Caminhoderato.respawAtual);
        player.transform.position = Caminhoderato.respawAtual;
        caiu = false;
        
    }
}
