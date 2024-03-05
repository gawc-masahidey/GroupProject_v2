using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownManager : MonoBehaviour
{
    public TMP_Dropdown dropdown; // TextMeshProのDropdownに変更

    [SerializeField] GameObject GameDirector;
    TurnAdmin TurnAdmin;

    public event Action<Units> OnUnitsSelected; // Unitsが選択されたときのイベント
    Units unit;
    public int getIdNum;


    // Start is called before the first frame update
    void Start()
    {
        // Dropdown インスタンスの初期化
        dropdown = GetComponent<TMP_Dropdown>(); // TextMeshProのDropdownに変更
        TurnAdmin = GameDirector.GetComponent<TurnAdmin>();

        // TurnAdmin のイベントを購読
        TurnAdmin.OnTurnChanged += UpdateDropdownOptions;

        if (dropdown == null)
        {
            Debug.LogError("Dropdown component not found");
            return;
        }

        // 初回のドロップダウンの初期化
        UpdateDropdownOptions();

        // ドロップダウンの選択が変更されたときに呼ばれるリスナーを設定
        dropdown.onValueChanged.AddListener(DropdownValueChanged);

        // 初回の選択肢に対応するUnitsコンポーネントを取得する
        DropdownValueChanged(dropdown.value);

    }

    // TurnAdmin のイベントで呼ばれるメソッド
    void UpdateDropdownOptions()
    {
        dropdown.ClearOptions();

        GameObject[] sceneObjects;
        // シーン上のタグのオブジェクトを取得
        if (TurnAdmin != null)
        {
            if (TurnAdmin.GetTurn() == true)
            {
                sceneObjects = GameObject.FindGameObjectsWithTag("Player1");
            }
            else
            {
                sceneObjects = GameObject.FindGameObjectsWithTag("Player2");
            }

            // オブジェクト名のリストを作成
            List<TMP_Dropdown.OptionData> objectNames = new List<TMP_Dropdown.OptionData>(); // OptionDataに変更

            foreach (GameObject obj in sceneObjects)
            {
                // オブジェクト名をリストに追加
                objectNames.Add(new TMP_Dropdown.OptionData(obj.name)); // OptionDataに変更
            }

            // ドロップダウンのオプションとしてリストを設定
            dropdown.AddOptions(objectNames);
        }
        else
        {
            Debug.LogError("TurnAdmin component not found");
        }
    }

    // ドロップダウンの選択が変更された時に呼ばれるメソッド
    void DropdownValueChanged(int value)
    {
        //unit初期化
        unit = null;
        // 選択されたオブジェクト名を取得
        string selectedObjectName = dropdown.options[value].text;

        // ここで選択されたオブジェクトに対する処理を行う
        Debug.Log("Selected Object: " + selectedObjectName);

        // 選択されたオブジェクトのコンポーネントを取得
        GameObject selectedObject = GameObject.Find(selectedObjectName);
        if (selectedObject != null)
        {
            
            unit = selectedObject.GetComponentInChildren<Units>(); // 適切なコンポーネントに変更する必要があります
            if (unit != null)
            {
                // コンポーネントが選択されたイベントを発生させる
                OnUnitsSelected?.Invoke(unit);
            }
            else
            {
                Debug.LogError("Component not found on selected object: " + selectedObjectName);
            }
        }
        else
        {
            Debug.LogError("Selected object not found: " + selectedObjectName);
        }

        getIdNum = unit.GetIdentifyNum();
        

    }
    
}
