using System.Collections;
using UnityEngine;
using TMPro;

public class EnemyAttack : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform spawnPoint;
    public float disparoIntervalo;
    public TextMeshProUGUI balasEnPantallaText;

    private int balasEnPantalla = 0;

    private void Start()
    {
        StartCoroutine(DispararBullets());
    }

    IEnumerator DispararBullets()
    {
        float tiempoTotal = 40.0f;

        while (tiempoTotal > 0)
        {
            yield return new WaitForSeconds(disparoIntervalo);

            // Cambiar el patrón de disparo cada 10 segundos
            if (tiempoTotal > 30.0f)
            {
                Patron1(); //
            }
            else if (tiempoTotal > 20.0f)
            {
                Patron2(); // 
            }
            else if (tiempoTotal > 10.0f)
            {
                Patron3(); // 
            }
            else
            {
                Patron4(); 
            }

            tiempoTotal -= disparoIntervalo;
        }
    }

    void Patron1()
    {
        disparoIntervalo = 0.2f;
        int numBalas = 8;

        for (int i = 0; i < numBalas; i++)
        {
            float angulo = i * (360f / numBalas);
            float radio = 2.0f;

            float x = spawnPoint.position.x + Mathf.Cos(angulo * Mathf.Deg2Rad) * radio;
            float z = spawnPoint.position.z + Mathf.Sin(angulo * Mathf.Deg2Rad) * radio;

            Vector3 spawnPosition = new Vector3(x, spawnPoint.position.y, z);

            Quaternion rotacion = Quaternion.LookRotation(spawnPoint.position - spawnPosition);
            Disparar(rotacion);
        }
    }

    void Patron2()
    {
        disparoIntervalo = 0.15f;
        int numBalas = 12;

        for (int i = 0; i < numBalas; i++)
        {
            float angulo = i * (360f / numBalas);
            float radio = i * 0.5f;

            float x = spawnPoint.position.x + Mathf.Cos(angulo * Mathf.Deg2Rad) * radio;
            float z = spawnPoint.position.z + Mathf.Sin(angulo * Mathf.Deg2Rad) * radio;

            Vector3 spawnPosition = new Vector3(x, spawnPoint.position.y, z);

            Quaternion rotacion = Quaternion.LookRotation(spawnPoint.position - spawnPosition);
            Disparar(rotacion);
        }
    }

    void Patron3()
    {
        disparoIntervalo = 0.25f;
        int numBalas = 6;

        for (int i = 0; i < numBalas; i++)
        {
            float angulo = i * (360f / numBalas * 2);
            float radio = 4.0f;

            float x = spawnPoint.position.x + Mathf.Cos(angulo * Mathf.Deg2Rad) * radio;
            float z = spawnPoint.position.z + Mathf.Sin(angulo * Mathf.Deg2Rad) * radio;

            Vector3 spawnPosition = new Vector3(x, spawnPoint.position.y, z);

            Quaternion rotacion = Quaternion.LookRotation(spawnPoint.position - spawnPosition);
            Disparar(rotacion);
        }
    }

    void Patron4()
    {
        disparoIntervalo = 0.18f;
        int numBalas = 10;

        for (int i = 0; i < numBalas; i++)
        {
            float angulo = i * (360f / numBalas);
            float radio = 2.5f;

            float x = spawnPoint.position.x + Mathf.Cos(angulo * Mathf.Deg2Rad) * radio;
            float z = spawnPoint.position.z + Mathf.Sin(angulo * Mathf.Deg2Rad) * radio;

            Vector3 spawnPosition = new Vector3(x, spawnPoint.position.y, z);

            Quaternion rotacion = Quaternion.LookRotation(spawnPoint.position - spawnPosition);
            Disparar(rotacion);
        }
    }

    void Disparar(Quaternion rotacion)
    {
        GameObject bullet = Instantiate(balaPrefab, spawnPoint.position, rotacion);
        Destroy(bullet, 10.0f);
        IncrementarContadorBalas();
    }

    void IncrementarContadorBalas()
    {
        balasEnPantalla++;
        ActualizarTextoContadorBalas();
    }

    public void DecrementarContadorBalas()
    {
        balasEnPantalla--;
        ActualizarTextoContadorBalas();
    }

    void ActualizarTextoContadorBalas()
    {
        balasEnPantallaText.text = "Balas en pantalla: " + balasEnPantalla;
    }
}
