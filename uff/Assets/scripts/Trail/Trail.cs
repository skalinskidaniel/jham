using UnityEngine;

public class Trail : dash
{
    [SerializeField]private TrailRenderer []vento;
   void EstaVento()
    {
        if(Dashe)
        {
            Venta();
        }
        if(!Dashe)
        {
            Paravento();
        }
    }
    private void Venta()
    {
        foreach(TrailRenderer T in vento)
        {
            T.emitting = true;
        }
    }
    private void Paravento()
    {
        foreach(TrailRenderer T in vento)
        {
            T.emitting = false;
        }
    }
}
