using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GridMap gridMap; // Reference to the grid map

    public void TeleportToEnemyAdjacentPosition(string playerTag)
    {
        // Find own unit by tag
        GameObject ownUnitGameObject = GameObject.FindGameObjectWithTag(playerTag);
        if (ownUnitGameObject == null)
        {
            Debug.LogWarning("Own unit not found.");
            return;
        }

        // Find enemy unit by tag
        string enemyTag = (playerTag == "Player1") ? "Player2" : "Player1";
        GameObject enemyUnitGameObject = GameObject.FindGameObjectWithTag(enemyTag);
        if (enemyUnitGameObject == null)
        {
            Debug.LogWarning("Enemy unit not found.");
            return;
        }

        // Get GridObject components of own and enemy units
        GridObject ownGridObject = ownUnitGameObject.GetComponent<GridObject>();
        GridObject enemyGridObject = enemyUnitGameObject.GetComponent<GridObject>();

        if (ownGridObject == null || enemyGridObject == null)
        {
            Debug.LogWarning("GridObject component not found on units.");
            return;
        }

        // Get the grid position of enemy unit
        Vector3 enemyPosition = enemyUnitGameObject.transform.position;
        Vector3Int enemyGridPosition = new Vector3Int(Mathf.RoundToInt(enemyPosition.x), 0, Mathf.RoundToInt(enemyPosition.z));

        // Find adjacent position next to enemy unit's position (excluding Up and Down)
        Vector3Int adjacentPosition = FindAdjacentPosition(enemyGridPosition);

        if (adjacentPosition != Vector3Int.zero)
        {
            // Place own unit at the adjacent position
            gridMap.PlaceObject(new Vector2Int(adjacentPosition.x, adjacentPosition.z), ownGridObject);

            Debug.Log(playerTag + " unit teleported to adjacent position next to enemy unit's position.");
        }
        else
        {
            Debug.LogWarning("No valid adjacent position found.");
        }
    }

    // Function to find an adjacent position next to a given position in a 3D grid (excluding Up and Down)
    private Vector3Int FindAdjacentPosition(Vector3Int position)
    {
        Vector3Int[] directions = new Vector3Int[]
        {
            new Vector3Int(1, 0, 0),   // Right
            new Vector3Int(-1, 0, 0),  // Left
            new Vector3Int(0, 0, 1),   // Forward
            new Vector3Int(0, 0, -1)   // Backward
        };

        foreach (Vector3Int dir in directions)
        {
            Vector3Int adjacentPos = position + dir;
            if (gridMap.CheckBoundary(adjacentPos.x, adjacentPos.z) && gridMap.CheckWalkable(adjacentPos.x, adjacentPos.z))
            {
                return adjacentPos;
            }
        }

        return Vector3Int.zero;
    }
}
