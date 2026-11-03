using TMPro;
using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textoTiempo;

    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    void Update()
    {
        if (estaJugando)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
            estaJugando = false;
            textoTiempo.text = Mathf.FloorToInt(tiempoDePartida).ToString();
        }
    }
}
