using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter),typeof(MeshRenderer),typeof(MeshCollider))]
public class TileMap : MonoBehaviour
{
    /*
    [SerializeField] int width = 90;
    //[SerializeField] int height;
    [SerializeField] int length = 120;
    [SerializeField] float tileSize = 1.0f;
    internal readonly BoundsInt cellBounds;

    void Start()
    {
        BuildMesh();
    }

    void BuildMesh()
    {
        int numTiles = width * length;
        int numTris = numTiles * 2;

        int vSizeWidth = width + 1;
        int vSizeLength = length + 1;
        int numVerts = vSizeWidth * vSizeLength;

        // Generate the mesh data
        Vector3[] vertices = new Vector3[numVerts];
        Vector3[] normals = new Vector3[numVerts];
        Vector2[] uv = new Vector2[numVerts];
        int[] triangles = new int[numTris * 3];

        int x, z;

        // Generate vertices
        for (z = 0; z < vSizeLength; z++)
        {
            for (x = 0; x < vSizeWidth; x++)
            {
                vertices[z * vSizeWidth + x] = new Vector3(x * tileSize, 0, z * tileSize);
                normals[z * vSizeWidth + x] = Vector3.up;
                uv[z * vSizeWidth + x] = new Vector2((float)x / vSizeWidth, (float)z / vSizeLength);
            }
        }

        // Generate triangles
        for (z = 0; z < length; z++)
        {
            for (x = 0; x < width; x++)
            {
                int squareIndex = z * width + x;
                int triOffset = squareIndex * 6;

                triangles[triOffset + 0] = z * vSizeWidth + x;                      // Bottom left
                triangles[triOffset + 1] = z * vSizeWidth + x + vSizeWidth + 1;     // Top right
                triangles[triOffset + 2] = z * vSizeWidth + x + vSizeWidth;         // Top left

                triangles[triOffset + 3] = z * vSizeWidth + x;                      // Bottom left
                triangles[triOffset + 4] = z * vSizeWidth + x + 1;                  // Bottom right
                triangles[triOffset + 5] = z * vSizeWidth + x + vSizeWidth + 1;     // Top right
            }
        }

        // Create new mesh & populate it with new data
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.normals = normals;
        mesh.uv = uv;

        // Assign our mesh to our filter/renderer/collider
        MeshFilter meshFil = GetComponent<MeshFilter>();
        MeshRenderer meshRen = GetComponent<MeshRenderer>();
        MeshCollider meshCol = GetComponent<MeshCollider>();

        meshFil.mesh = mesh;
    }
    */
}


