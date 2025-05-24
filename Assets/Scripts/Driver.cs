using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private float steerSpeed = 0.1f;
    [SerializeField]
    private float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
=======
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
>>>>>>> d3bdd39 (Enviroment and code for deliveries and recognition betw coustomers and packs)

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
}
