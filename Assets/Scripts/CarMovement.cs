using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private CharacterController controller;
    public float _movespped = 10f;
    private Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        direction.z = _movespped;
        controller.Move(direction * Time.fixedDeltaTime);
        float _horiziontal = Input.GetAxis("Horizontal");
        transform.Translate(_horiziontal, 0, 0);

    }
}
