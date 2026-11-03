using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField]
    float velocidadRotador = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, velocidadRotador * Time.deltaTime, 0,0f);
    }
}
