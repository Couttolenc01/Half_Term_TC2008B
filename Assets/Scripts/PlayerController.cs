using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Obtener la dirección de movimiento en el plano horizontal, considerando la rotación
        Vector3 movement = transform.TransformDirection(new Vector3(horizontalInput, 0f, verticalInput)) * speed * Time.fixedDeltaTime;

        // Mover el objeto en todas las direcciones
        rb.MovePosition(rb.position + movement);
    }
}
