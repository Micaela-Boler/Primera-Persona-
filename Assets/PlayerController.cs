using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Ejes de movimientos")]
    private float horizontalInput;
    private float verticalInput;
    private Vector3 vectorMovement;

    [Header("Velocidad de movimientos")]
    public float speed;

    [Header("Game Over")]
    public GameOver gameOverScreen;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        vectorMovement = new Vector3(horizontalInput, 0f, verticalInput);

        vectorMovement.Normalize(); 

        transform.Translate(vectorMovement * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }


    // Game Over
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOverScreen.activeScreen();
        }
    }
}
