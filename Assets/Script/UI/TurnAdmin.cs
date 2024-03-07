using System;
using UnityEngine;

public class TurnAdmin : MonoBehaviour
{
    private bool turn;
    public bool IsRedTurn { get { return turn; } }
    public event Action OnTurnChanged; // Turnの状態が変化したときに呼び出すイベント

    void Start()
    {
        turn = true;
    }

    void Update()
    {

    }

    // turn フィールドのゲッター
    public bool GetTurn()
    {
        return turn;
    }

    // turn フィールドのセッター
    public void SetTurn(bool value)
    {
        if (turn != value)
        {
            turn = value;
            // Turnの状態が変化したことを通知
            OnTurnChanged?.Invoke();
        }
    }

    public void ToggleTurn()
    {
        SetTurn(!turn); // Turnの値を反転させる

        // Player1タグを持つオブジェクトを取得し、Unitsコンポーネントを取得する
        GameObject[] player1Objects = GameObject.FindGameObjectsWithTag("Player1");
        foreach (GameObject obj in player1Objects)
        {
            Units unitsComponent = obj.GetComponent<Units>();
            if (unitsComponent != null)
            {
                // ここでUnitsコンポーネントに対する処理を行う
                unitsComponent.unitTurnStart();
            }
        }

        // Player2タグを持つオブジェクトを取得し、Unitsコンポーネントを取得する
        GameObject[] player2Objects = GameObject.FindGameObjectsWithTag("Player2");
        foreach (GameObject obj in player2Objects)
        {
            Units unitsComponent = obj.GetComponent<Units>();
            if (unitsComponent != null)
            {
                // ここでUnitsコンポーネントに対する処理を行う
                unitsComponent.unitTurnStart();
            }
        }
    }
}
