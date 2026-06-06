using UnityEngine;

public class MataQueda : shakaQueda
{
    private Rigidbody rb;
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
        Debug.Log("chamo o metodo");
        player.transform.position = respawAtual;
        caiu = false;
        
    }
}
