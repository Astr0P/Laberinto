using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
        }
    }
}
