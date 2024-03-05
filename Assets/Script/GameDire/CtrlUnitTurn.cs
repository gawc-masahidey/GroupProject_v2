using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlUnitTurn : MonoBehaviour
{
    TurnAdmin TAdmin;
    Units unitComponent;

    // プレイヤー1とプレイヤー2のタグ
    private const string Player1Tag = "Player1";
    private const string Player2Tag = "Player2";

    int TurnEndUnit { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        TAdmin = GetComponent<TurnAdmin>();
        TAdmin.OnTurnChanged += ResetEndUnitCount;

        // Player1とPlayer2タグを持つGameObjectを取得し、Unitsコンポーネントを取得する
        GameObject[] player1Objects = GameObject.FindGameObjectsWithTag(Player1Tag);
        foreach (GameObject obj in player1Objects)
        {
            unitComponent = obj.GetComponent<Units>();
            if (unitComponent != null)
            {
                // UnitsコンポーネントのイベントにEndUnitCount()メソッドを登録
                unitComponent.EndUnit += EndUnitCount;
            }
        }

        GameObject[] player2Objects = GameObject.FindGameObjectsWithTag(Player2Tag);
        foreach (GameObject obj in player2Objects)
        {
            unitComponent = obj.GetComponent<Units>();
            if (unitComponent != null)
            {
                // UnitsコンポーネントのイベントにEndUnitCount()メソッドを登録
                unitComponent.EndUnit += EndUnitCount;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndUnitCount()
    {
        // EndUnitCount()メソッドの実装
        TurnEndUnit++;
        if (TurnEndUnit == 3)
        {
            TAdmin.ToggleTurn();
        }
    }

    public void ResetEndUnitCount()
    {
        // ResetEndUnitCount()メソッドの実装
        TurnEndUnit = 0;
    }
}

