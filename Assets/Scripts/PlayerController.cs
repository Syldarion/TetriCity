using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // TODO: Remove this reference
    public GameManager gameManager;
    
    public OrbitCamera playerCamera;

    private TetricityControls controls;

    private Vector2 lastMoveValue;
    private float lastTiltValue;
    private float lastRotateValue;
    
    void Awake()
    {
        controls = new TetricityControls();
        controls.Enable();
    }

    private void OnEnable()
    {
        // controls.Player.MoveCamera.performed += HandleMoveCamera;
        // controls.Player.TiltCamera.performed += HandleTiltCamera;
        // controls.Player.RotateCamera.performed += HandleRotateCamera;

        controls.Player.PlacePiece.performed += HandlePlacePiece;
        controls.Player.RotatePiece.performed += HandleRotatePiece;
    }
    
    private void OnDisable()
    {
        // controls.Player.MoveCamera.performed -= HandleMoveCamera;
        // controls.Player.TiltCamera.performed -= HandleTiltCamera;
        // controls.Player.RotateCamera.performed -= HandleRotateCamera;
        
        controls.Player.PlacePiece.performed -= HandlePlacePiece;
        controls.Player.RotatePiece.performed -= HandleRotatePiece;
    }

    void Start()
    {
        
    }

    void Update()
    {
        lastMoveValue = controls.Player.MoveCamera.ReadValue<Vector2>();
        //lastTiltValue = controls.Player.TiltCamera.ReadValue<float>();
        lastRotateValue = controls.Player.RotateCamera.ReadValue<float>();
        
        playerCamera.focalPoint.x += lastMoveValue.x * Time.deltaTime;
        playerCamera.focalPoint.z += lastMoveValue.y * Time.deltaTime;
        //playerCamera.pitchAngle += lastTiltValue * Time.deltaTime;
        playerCamera.yawAngle += lastRotateValue * Time.deltaTime;
    }

    // private void HandleMoveCamera(InputAction.CallbackContext context)
    // {
    //     lastMoveValue = context.ReadValue<Vector2>();
    //     Debug.Log(lastMoveValue);
    // }
    //
    // private void HandleTiltCamera(InputAction.CallbackContext context)
    // {
    //     lastTiltValue = context.ReadValue<float>();
    // }
    //
    // private void HandleRotateCamera(InputAction.CallbackContext context)
    // {
    //     lastRotateValue = context.ReadValue<float>();
    // }

    private void HandlePlacePiece(InputAction.CallbackContext context)
    {
        gameManager.PlaceCurrentPiece();
    }

    private void HandleRotatePiece(InputAction.CallbackContext context)
    {
        gameManager.RotateCurrentPiece();
    }
}
