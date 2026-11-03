using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    
    public float movimientoEjeX;
    public float movimientoEjeZ;
    public float movimientoEjeY;


    public float velocidadMovimiento = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = Input.GetAxis("Horizontal");
        movimientoEjeZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoEjeX, movimientoEjeY, movimientoEjeZ).normalized;
        movimiento *= Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimiento);
    }
}
