using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehavior : MonoBehaviour
{
    /*
    public bool findDistance = false;
    [SerializeField] int rows = 10;
    [SerializeField] int columns = 10;
    [SerializeField] int scale = 1;
    [SerializeField] GameObject gridPrefab;
    [SerializeField] Vector3 leftBottomLocation = new Vector3(0, 0, 0);

    [SerializeField] GameObject[,] gridArray;
    public int startX = 0;
    public int startY = 0;
    [SerializeField] int endX = 2;
    [SerializeField] int endY = 2;
    public List<GameObject> path = new List<GameObject>();

    void Awake()
    {
        gridArray = new GameObject[columns,rows];
        if (gridPrefab)
        {
            GenerateGrid();
        }
        else { Debug.Log("missing gridPrefab, please assign"); }
    }
    void Update()
    {
        if (findDistance)
        {
            SetDistance();
            SetPath();

            findDistance = false;
        }
    }

    void GenerateGrid()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftBottomLocation.x + scale * i, leftBottomLocation.y, leftBottomLocation.z + scale * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.GetComponent<GridStats>().x = i;
                obj.GetComponent<GridStats>().y = j;
                gridArray[i,j] = obj;
            }
        }
    }
    void SetDistance()
    {
        InitialSetup();
        int x = startX;
        int y = startY;
        int[] testArray = new int[rows * columns];
        for(int step = 1; step < rows * columns; step++)
        {
            foreach(GameObject obj in gridArray)
            {
                if(obj && obj.GetComponent<GridStats>().visited == step - 1)
                {
                    TestFourDirections(obj.GetComponent<GridStats>().x, obj.GetComponent<GridStats>().y, step);

                }
            }
        }

    }

    void InitialSetup()
    {
        foreach(GameObject obj in gridArray)
        {
            obj.GetComponent<GridStats>().visited = -1;
        }
        gridArray[startX,startY].GetComponent<GridStats>().visited = 0;
    }

    bool TestDirection(int x, int y, int step, int direction)
    {
        switch (direction)
        {
            case 4:
                if (x - 1 > -1 && gridArray[x - 1, y] && gridArray[x - 1, y].GetComponent<GridStats>().visited==step)
                    return true;
                else
                    return false;
            case 3:
                if (y - 1 > -1 && gridArray[x, y - 1] && gridArray[x, y - 1].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false;
            case 2:
                if (x + 1 < columns && gridArray[x + 1, y] && gridArray[x + 1, y].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false;
            case 1:
                if (y + 1 < rows && gridArray[x, y + 1] && gridArray[x, y + 1].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false;
        }
        return false; 

    }

    void SetPath()
    {
        int step;
        int x = endX;
        int y = endY;
        List<GameObject> tempList = new List<GameObject>();
        path.Clear();
        if (gridArray[endX, endY] && gridArray[endX, endY].GetComponent<GridStats>().visited > 0)
        {
            path.Add(gridArray[x, y]);
            step = gridArray[x, y].GetComponent<GridStats>().visited - 1;
        }
        else
        {
            print("Cant reach desired location");
            return;
        }
        for (int i = step; step > -1; step++)
        {
            if (TestDirection(x, y, step, 1))
                tempList.Add(gridArray[x, y + 1]);

            if (TestDirection(x, y, step, 2))
                tempList.Add(gridArray[x + 1, y]);

            if (TestDirection(x, y, step, 3))
                tempList.Add(gridArray[x, y - 1]);

            if (TestDirection(x, y, step, 4))
                tempList.Add(gridArray[x - 1, y]);

            GameObject tempObj = FindClosest(gridArray[endX, endY].transform, tempList);
            path.Add(tempObj);
            x = tempObj.GetComponent<GridStats>().x;
            y = tempObj.GetComponent<GridStats>().y;

            tempList.Clear();   
        }
        
    }
    void TestFourDirections(int x, int y, int step)
        {
        if(TestDirection(x,y,-1,1))
            SetVisited(x, y + 1, step);

        if (TestDirection(x, y, -1, 2))
            SetVisited(x + 1, y, step);

        if (TestDirection(x, y, -1, 3))
            SetVisited(x, y - 1, step);

        if (TestDirection(x, y, -1, 4))
            SetVisited(x - 1, y, step);

    }
    void SetVisited(int x, int y, int step)
    {
        if (gridArray[x,y])
            gridArray[x,y].GetComponent<GridStats>().visited = step;   
    }

    GameObject FindClosest(Transform targetLocation, List<GameObject> list)
    {
        float currentDistance = scale * rows * columns;
        int indexNumber = 0;
        for(int i = 0; i < list.Count; i++)
        {
            if(Vector3.Distance(targetLocation.position, list[i].transform.position) < currentDistance)
            {
                currentDistance = Vector3.Distance(targetLocation.position, list[i].transform.position);
                indexNumber = i;
            }
        }
        return list[indexNumber];
    }
    */
}
