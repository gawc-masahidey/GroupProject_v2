using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    [SerializeField] GameObject GameDirector;
    TurnAdmin TurnAdmin;
    Units unit;
    GridObject gObject;

    public event Action<Units> OnUnitsSelected;
    public event Action<GridObject> OnGridObjectSelected;

    void Start()
    {
        InitializeDropdown();
        UpdateDropdownOptions(); // ドロップダウンの内容を最初に更新する
        dropdown.onValueChanged.AddListener(DropdownValueChanged);
        DropdownValueChanged(dropdown.value);
    }

    void InitializeDropdown()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        TurnAdmin = GameDirector.GetComponent<TurnAdmin>();
        TurnAdmin.OnTurnChanged += UpdateDropdownOptions;
    }

    void UpdateDropdownOptions()
    {
        dropdown.ClearOptions();
        string[] objectTags = (TurnAdmin != null && TurnAdmin.GetTurn()) ? new string[] { "Player1" } : new string[] { "Player2" };
        List<string> objectNames = new List<string>();
        foreach (string tag in objectTags)
        {
            GameObject[] sceneObjects = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject obj in sceneObjects)
            {
                objectNames.Add(obj.name);
            }
        }
        dropdown.AddOptions(objectNames);
    }

    void DropdownValueChanged(int value)
    {
        unit = null;
        string selectedObjectName = dropdown.options[value].text;
        GameObject selectedObject = GameObject.Find(selectedObjectName);
        if (selectedObject != null)
        {
            unit = selectedObject.GetComponentInChildren<Units>();
            gObject = selectedObject.GetComponent<GridObject>();
            OnGridObjectSelected?.Invoke(gObject);
            if (gObject != null)
            {
                unit.SetNowPos(gObject);
                // Unitsクラスのメソッドを使ってGridObjectからVector2Intを格納
                OnUnitsSelected?.Invoke(unit);
            }
        }
    }
}
