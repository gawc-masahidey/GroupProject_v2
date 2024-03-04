using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{/*
    private static MapManager _instance;
    public static MapManager Instance { get { return _instance; } }
    public GameObject overlayObjectPrefab;
    public GameObject overlayContainer;

    public Dictionary<Vector2Int,OverlayTile> map;
    /*
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    void Start()
    {
        var tileMap = gameObject.GetComponentInChildren<Tilemap>();
        map = new Dictionary<Vector2Int, OverlayTile>();

        BoundsInt bounds = tileMap.cellBounds;

        for (int z = bounds.max.z; z > bounds.min.z; z--)
        {
            for (int y = bounds.min.y; y < bounds.max.y; y++)
            {
                for (int x = bounds.min.x; x < bounds.max.x; x++)
                {
                    var tileLocation = new Vector3Int(x, y, z);
                    var tileKey = new Vector2Int(x, y);

                    if (tileMap.HasTile(tileLocation) && !map.ContainsKey(tileKey))
                    {
                        var overlayTile = Instantiate(overlayObjectPrefab, overlayContainer.transform);
                        var cellWorldPosition = tileMap.GetCellCenterWorld(tileLocation);

                        overlayTile.transform.position = new Vector3(cellWorldPosition.x, cellWorldPosition.y, cellWorldPosition.z + 1);
                        overlayTile.GetComponent<SpriteRenderer>().sortingOrder = tileMap.GetComponent<TilemapRenderer>().sortingOrder;

                        map.Add(tileKey, overlayTile.GetComponent<OverlayTile>());
                    }
                }
            }
        }
    }
    */
    /*
   private void Awake()
   {
       if (_instance != null && _instance != this)
       {
           Destroy(this.gameObject);
       }
       else
       {
           _instance = this;
       }
   }

    // Start is called before the first frame update
    void Start()
    {
        Terrain terrain = GetComponentInChildren<Terrain>();

        if (terrain == null)
        {
            Debug.LogError("No Terrain component found in children.");
            return;
        }

        TerrainData terrainData = terrain.terrainData;

        int width = terrainData.heightmapResolution;
        int height = terrainData.heightmapResolution;

        map = new Dictionary<Vector2Int, OverlayTile>();

        float[,] heights = terrainData.GetHeights(0, 0, width, height);

        // Calculate the half width and half length of the terrain grid
        float halfWidth = terrainData.size.x / 2f;
        float halfLength = terrainData.size.z / 2f;

        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                float normalizedX = x * 1.0f / (width - 1);
                float normalizedZ = z * 1.0f / (height - 1);

                Vector3 worldPosition = new Vector3(normalizedX * terrainData.size.x - halfWidth + terrain.transform.position.x,
                                                    heights[z, x] * terrainData.size.y + terrain.transform.position.y,
                                                    normalizedZ * terrainData.size.z - halfLength + terrain.transform.position.z);

                GameObject overlayObject = Instantiate(overlayObjectPrefab, worldPosition, Quaternion.identity, overlayContainer.transform);
                OverlayTile overlayTile = overlayObject.GetComponent<OverlayTile>();
                map.Add(new Vector2Int(x, z), overlayTile);
            }
        }
   }
    */
}