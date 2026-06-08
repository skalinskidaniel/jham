using UnityEngine;

public class spawPeixe : MonoBehaviour
{ 
    //[SerializeField]private GameObject peixe;
    [SerializeField]private GameObject peixe;
    private bool podedarSpaw = false;

    void  OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            peixe.SetActive(true);
            podedarSpaw = true;
            //Instantiate(peixe,transform.position,transform.rotation);
        }
    }
}
