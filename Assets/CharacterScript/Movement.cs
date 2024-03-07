using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    GridObject gridObject;
    Animator characterAnimator;
    Units currentUnit;
    bool hasMoved = false; // Flag to track whether the unit has moved in the current turn

    List<Vector3> pathWorldPositions;
    [SerializeField] float moveSpeed = 1f;

    [SerializeField] GameObject dropdownManagerObject; // Reference to the dropdown manager object
    DropdownManager dropdownManager;

    private void Awake()
    {
        gridObject = GetComponent<GridObject>();
        characterAnimator = GetComponent<Animator>();

        // Ensure dropdownManagerObject is not null before accessing its components
        if (dropdownManagerObject != null)
        {
            dropdownManager = dropdownManagerObject.GetComponent<DropdownManager>();
            dropdownManager.OnUnitsSelected += UpdateSelectedUnit;
        }
    }

    private void UpdateSelectedUnit(Units selectedUnit)
    {
        currentUnit = selectedUnit;
        hasMoved = false; // Reset the flag when a new unit is selected
    }

    public void Move(List<PathNode> path)
    {
        pathWorldPositions = gridObject.targetGrid.ConvertPathNodesToWorldPositions(path);
        gridObject.positionOnGrid.x = path[path.Count - 1].pos_x;
        gridObject.positionOnGrid.y = path[path.Count - 1].pos_y;

        RotateCharacter();
        // Trigger animation for starting movement
        characterAnimator.SetBool("IsMoving", true);
    }

    private void RotateCharacter()
    {
        if (pathWorldPositions.Count > 0)
        {
            Vector3 direction = (pathWorldPositions[0] - transform.position).normalized;
            direction.y = 0;
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }

    private void Update()
    {
        if (pathWorldPositions == null || pathWorldPositions.Count == 0)
            return;

        transform.position = Vector3.MoveTowards(transform.position, pathWorldPositions[0], moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, pathWorldPositions[0]) < 0.05f)
        {
            pathWorldPositions.RemoveAt(0);
            // Trigger animation for stopping movement if path completed
            if (pathWorldPositions.Count == 0) { characterAnimator.SetBool("IsMoving", false); }
            else { RotateCharacter(); }
        }
    }

    // Called when the move button is pressed
    public void OnMoveButtonPressed()
    {
        if (!hasMoved && currentUnit != null)
        {
            currentUnit.Move(); // Call the Move method of the current unit
            hasMoved = true; // Set the flag to true after moving
        }
    }

    private void OnDestroy()
    {
        if (dropdownManager != null)
        {
            dropdownManager.OnUnitsSelected -= UpdateSelectedUnit;
        }
    }
}