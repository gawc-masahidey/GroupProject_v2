using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] GridMap targetGridMap;
    [SerializeField] LayerMask terrainLayerMask;

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

                GameObject[] players = GameObject.FindGameObjectsWithTag("Player1");
                players = players.Concat(GameObject.FindGameObjectsWithTag("Player2")).ToArray();

                foreach (GameObject player in players)
                {
                    GridObject gridObject = player.GetComponentInChildren<GridObject>();
                        path = pathfinding.FindPath(gridObject.positionOnGrid.x, gridObject.positionOnGrid.y, gridPosition.x, gridPosition.y);
                        if (path != null && path.Count > 0)
                        {
                            player.GetComponent<Movement>().Move(path);
                            break; // Exit the loop after moving the first player found
                        }
                    }
                }
            }
        }
}
