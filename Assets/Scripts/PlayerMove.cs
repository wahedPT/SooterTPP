using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController character;
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float rotateSpeed;
    [SerializeField]
    private float backSpeed;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        var horizotalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        var movement = new Vector3(horizotalInput, 0, verticalInput);
        anim.SetFloat("Speed", verticalInput);
        transform.Rotate(Vector3.up, horizotalInput * rotateSpeed * Time.deltaTime);
        if (verticalInput != 0)
        {
            float moveSpeed = (verticalInput > 0) ? playerSpeed : backSpeed;
            character.SimpleMove(transform.forward * verticalInput * moveSpeed);
        }
    }
}
