using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     public float velocidad = 5.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    void OnDestroy()
    {
        GameObject Boss = GameObject.FindWithTag("Final Boss");

        if (Boss != null)
        {
            Boss.SendMessage("DecrementarContadorBalas");
        }
        else
        {
            Debug.LogWarning("No se encontró un objeto con la etiqueta 'Final Boss'");
        }
    }
}
