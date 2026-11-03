using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredTocada = false;
    float temporizador = 3f;

    void Update()
    {
        if (paredTocada)
        {
            temporizador = temporizador - Time.deltaTime;
            if (temporizador < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredTocada = false;
                temporizador = 3f;
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredTocada = true;
        }
    }
}
