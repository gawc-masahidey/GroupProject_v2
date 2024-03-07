using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Transform player1CameraPosition; // The position for Player 1's camera
    public Transform player2CameraPosition; // The position for Player 2's camera
    [SerializeField] private GameObject gameDirector;
    private TurnAdmin turnAdmin; // Reference to the TurnAdmin script
    private Camera mainCamera; // Reference to the main camera

    void Start()
    {
        mainCamera = GetComponent<Camera>(); // Get the Camera component attached to this GameObject

        if (gameDirector != null)
        {
            turnAdmin = gameDirector.GetComponent<TurnAdmin>(); // Get the TurnAdmin script from the gameDirector
            if (turnAdmin != null)
            {
                // Subscribe to the OnTurnChanged event
                turnAdmin.OnTurnChanged += OnTurnChangedHandler;
                // Set the initial camera position based on whose turn it is
                if (turnAdmin.IsRedTurn)
                    SwitchToPlayer1View();
                else
                    SwitchToPlayer2View();
            }
            else
            {
                Debug.LogError("TurnAdmin script not found on the GameDirector object!");
            }
        }
        else
        {
            Debug.LogError("GameDirector object not assigned in the inspector!");
        }
    }

    // Unsubscribe from the event when the script is destroyed
    void OnDestroy()
    {
        if (turnAdmin != null)
        {
            turnAdmin.OnTurnChanged -= OnTurnChangedHandler;
        }
    }

    // Handler for the OnTurnChanged event
    private void OnTurnChangedHandler()
    {
        if (turnAdmin.IsRedTurn)
            SwitchToPlayer1View();
        else
            SwitchToPlayer2View();
    }

    // Switch the camera to Player 1's view
    private void SwitchToPlayer1View()
    {
        transform.position = player1CameraPosition.position;
        transform.rotation = player1CameraPosition.rotation;
    }

    // Switch the camera to Player 2's view
    private void SwitchToPlayer2View()
    {
        transform.position = player2CameraPosition.position;
        transform.rotation = player2CameraPosition.rotation;
    }

    // Zoom in on a specific game object for the current player's turn
    public void ZoomInOnGameObject(Units targetUnit)
    {
        if (targetUnit != null)
        {
            if ((turnAdmin.IsRedTurn && targetUnit.CompareTag("Player1")) ||
                (!turnAdmin.IsRedTurn && targetUnit.CompareTag("Player2")))
            {
                Vector3 targetPosition = targetUnit.transform.position;
                mainCamera.transform.position = targetPosition - mainCamera.transform.forward * 5f; // Adjust camera position
                mainCamera.fieldOfView = 30f; // Adjust field of view for zoom effect
            }
            else
            {
                Debug.LogWarning("Invalid target for zoom or it's not the current player's turn!");
            }
        }
        else
        {
            Debug.LogWarning("Invalid target for zoom!");
        }
    }

    // Reset the camera to its default position and field of view
    public void ResetCamera()
    {
        if (turnAdmin != null)
        {
            if (turnAdmin.IsRedTurn)
                SwitchToPlayer1View();
            else
                SwitchToPlayer2View();
        }
    }

    // Subscribe to the OnUnitsSelected event
    public void SubscribeToDropdown(DropdownManager dropdownManager)
    {
        if (dropdownManager != null)
            dropdownManager.OnUnitsSelected += ZoomInOnGameObject;
    }

    // Unsubscribe from the OnUnitsSelected event
    public void UnsubscribeFromDropdown(DropdownManager dropdownManager)
    {
        if (dropdownManager != null)
            dropdownManager.OnUnitsSelected -= ZoomInOnGameObject;
    }
}