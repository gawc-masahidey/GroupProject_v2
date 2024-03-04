using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[RequireComponent(typeof(OverlayTile))]
public class TileMouseController : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var focusedTileHit = GetFocusedOnTile();
        if (focusedTileHit.HasValue)
        {
            GameObject overlayTile = focusedTileHit.Value.collider.gameObject;
            transform.position = overlayTile.transform.position;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = overlayTile.GetComponent<SpriteRenderer>().sortingOrder;
        }
    }
    
    public RaycastHit2D? GetFocusedOnTile()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Inputt.mousePosition);   
        Vector2 mousePos2d = new Vector2 2 (mousePos.x, mousePos.y);

        RaycastHit2D[] hits = Physics2D.RaycastAll(mousePos2d, Vector2.zero);
        
        if(hits.Length > 0 )
        {
            return hits.OrderByDescending(i => i.collider.transform.position.z).First();
        }
        
        return null;
    }
    */

    /*
   
    // Reference to the MapManager
    private MapManager mapManager;

    void Start()
    {
        // Get reference to the MapManager
        mapManager = MapManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the focused overlay object
        var focusedOverlay = GetFocusedOverlay();

        // Check if there is a focused overlay object
        if (focusedOverlay != null)
        {
            // Update the position of the TileMouseController to match the focused overlay object
            transform.position = focusedOverlay.transform.position;
        }
    }

    // Get the focused overlay object
    public OverlayTile GetFocusedOverlay()
    {
        // Cast a ray from the camera to the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // If the ray hits something
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the hit object is part of the overlay objects
            if (mapManager.map.ContainsValue(hit.collider.gameObject))
            {
                // Get the OverlayTile component attached to the hit object
                OverlayTile overlayTile = hit.collider.gameObject.GetComponent<OverlayTile>();
                return overlayTile;
            }
        }

        return null;
    }
    */
}


