using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridControl : MonoBehaviour
{
    [SerializeField] GridMap targetGridMap;
    [SerializeField] LayerMask terrainLayerMask;
    
    Pathfinding pathfinding;
    Vector2Int currentPosition = new Vector2Int();
    List<PathNode> path;

    private void Start()
    {
        pathfinding = targetGridMap.GetComponent<Pathfinding>();
    }

        void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, float.MaxValue, terrainLayerMask))
            {
                Vector2Int gridPosition = targetGridMap.GetGridPosition(hit.point);

                Debug.Log("Mouse click detected at position: " + gridPosition);

                path = pathfinding.FindPath(currentPosition.x, currentPosition.y, gridPosition.x, gridPosition.y);

                currentPosition = gridPosition;

                if (path != null)
                {
                    Debug.Log("Path found with " + path.Count + " steps");
                }
                else
                {
                    Debug.LogWarning("No path found!");
                }

               
                GridObject gridObject = targetGridMap.GetPlacedObject(gridPosition);
                /*
                if (gridObject == null)
                {
                    Debug.Log("x=" + gridPosition.x + "y=" + gridPosition.y + " is empty");
                }
                else
                {
                    Debug.Log("x=" + gridPosition.x + "y=" + gridPosition.y + gridObject.GetComponent<Character>().Name);
                }
                 */
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (path != null && path.Count > 0)
        {
            Gizmos.color = Color.green;
            for (int i = 0; i < path.Count - 1; i++)
            {
                Vector3 startPos = targetGridMap.GetWorldPosition(path[i].pos_x, path[i].pos_y, true);
                Vector3 endPos = targetGridMap.GetWorldPosition(path[i + 1].pos_x, path[i + 1].pos_y, true);
                Gizmos.DrawLine(startPos, endPos);
            }
        }
    }
    /*
    private void OnDrawGizmos()
    {
        if (path == null) { return; }
        if (path.Count == 0) { return; }

        for (int i = 0; i < path.Count - 1; i++)
        {
            Gizmos.DrawLine(targetGridMap.GetWorldPosition(path[i].pos_x, path[i].pos_y, true),
                targetGridMap.GetWorldPosition(path[i + 1].pos_x, path[i + 1].pos_y, true)
                );
        }
    }*/

}
