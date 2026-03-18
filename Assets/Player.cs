using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public string nombre;
    public int vida;
    [SerializeField] private float velocidad = 5f;
    public int score = 0;
    public InputSystem_Actions inputs;
    [SerializeField] private Vector2 moveInput;
    public GameObject BalaPrefab;

    private void Awake()
    {
        inputs = new();
    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Move.performed += OnMovement;
        inputs.Player.Move.canceled += OnMovement;

        inputs.Player.Attack.performed += OnAttack;
    }

    private void OnAttack(InputAction.CallbackContext context)
    {

      

        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
        disparar(dir);
    }

    private void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void MovementMechanism(Vector2 input)
    {
        transform.position += (Vector3)input*velocidad*Time.deltaTime;
    }
    private void Start()
    {
        
    }
    void Update()
    {
        if (moveInput != Vector2.zero)
        {
            MovementMechanism(moveInput);
        }
       /* if (Input.GetMouseButtonDown(0))
        {
            disparar(moveInput);
        }*/
    }
    public void disparar(Vector2 dir)
    {
        GameObject bala = Instantiate(BalaPrefab,transform.position, Quaternion.identity);
        bala.transform.up = dir;
    }

    

}
