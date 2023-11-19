using System.Collections;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public float changeInterval = 2.0f; // Intervalo para cambiar de movimiento
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        // Actualizar el temporizador
        timer += Time.deltaTime;

        // Cambiar el movimiento cada cierto intervalo
        if (timer >= changeInterval)
        {
            ChangeMovementPattern();
            timer = 0f; // Reiniciar el temporizador
        }

        // Mover el objeto de avión automáticamente según el patrón de movimiento actual
        Move();
    }

    void Move()
    {
        // Puedes ajustar o agregar más patrones de movimiento según tus necesidades
        float horizontalMovement = Mathf.Sin(Time.time * 5f) * 15.0f; // Movimiento más rápido y brusco
        float verticalMovement = Mathf.Cos(Time.time * 4f) * 12.0f;    // Movimiento más rápido y brusco

        Vector3 movement = new Vector3(horizontalMovement, verticalMovement, 0f) * Time.deltaTime;
        transform.Translate(movement);
    }

    void ChangeMovementPattern()
    {
        // Puedes ajustar estos valores según tus preferencias
        int randomPattern = Random.Range(0, 3);

        switch (randomPattern)
        {
            case 0:
                // Patrón de movimiento 1
                changeInterval = 1.5f; // Cambiar el intervalo para hacerlo más frecuente
                break;

            case 1:
                // Patrón de movimiento 2
                changeInterval = 2.5f;
                break;

            case 2:
                // Patrón de movimiento 3
                changeInterval = 2.0f;
                break;
        }
    }
}
