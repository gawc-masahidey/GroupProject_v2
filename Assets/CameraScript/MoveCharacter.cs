using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] GridMap targetGridMap;
    [SerializeField] LayerMask terrainLayerMask;

    [SerializeField] GridObject targetCharacter;

    Pathfinding pathfinding;
    List<PathNode> path;

    private void Start()
    {
        pathfinding = targetGridMap.GetComponent<Pathfinding>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, float.MaxValue, terrainLayerMask))
            {
                Vector2Int gridPosition = targetGridMap.GetGridPosition(hit.point);

                path = pathfinding.FindPath(targetCharacter.positionOnGrid.x, targetCharacter.positionOnGrid.y, gridPosition.x, gridPosition.y);

                targetCharacter.GetComponent<Movement>().Move(path);
            }
        }
    }
}
