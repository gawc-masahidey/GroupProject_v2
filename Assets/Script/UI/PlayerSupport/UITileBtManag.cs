using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITileBtManag : MonoBehaviour
{
    [SerializeField] GameObject DD;
    DropdownManager ddManag;

    [SerializeField] GameObject GameDire;
    GridMap gmap;

    public GameObject AttackBtPrefab;
    public GameObject MoveBtPrefab;
    public GameObject SkillBtPrefab;
    public Transform panel;

    //public event Action<Units> OnPushAttackBt;
    //public event Action<Units> OnPushSkillBt;
    /*
    // Start is called before the first frame update
    void Start()
    {
        ddManag = DD.GetComponent<DropdownManager>();
        ddManag.OnUnitsSelected += PlaceMoveButtons;
        ddManag.OnUnitsSelected += PlaceAttackButtons;
        ddManag.OnUnitsSelected += PlaceSkillButtons;

        gmap = GameDire.GetComponent<GridMap>();
    }*/
    /*
    // アタックボタンの配置
    public void PlaceAttackButtons(Units unit)
    {
        // ユニットからアタックレンジリストを取得
        List<Vector2> attackRange = unit.attackRange;

        // アタックレンジリスト内の位置に攻撃可能なボタンを配置
        foreach (Vector2 position in attackRange)
        {
            // ノードがグリッドの範囲内にあるか確認
            if (gmap.CheckBoundary((int)position.x, (int)position.y))
            {
                // 攻撃可能な位置に対応するワールド座標を取得
                Vector3 worldPosition = gmap.GetWorldPosition((int)position.x, (int)position.y);

                // 攻撃可能なボタンを生成して配置
                GameObject button = Instantiate(AttackBtPrefab, panel);
                button.transform.position = worldPosition;

                
            }
        }
    }*/
    /*
    // スキルボタンの配置
    public void PlaceSkillButtons(Units unit)
    {
        // ユニットからスキルレンジリストを取得
        List<Vector2> skillRange = unit.skillRange;

        //スキルレンジが同等の場合
        if (IsSkillRangeSameAsAttackRange(unit))
        {
            //アタックボタンが押された時にOnSkillButtonClick(Units unit)を呼び出す
        }

        // スキルレンジとアタックレンジが同じでない場合のみ配置
        if (!IsSkillRangeSameAsAttackRange(unit))
        {
            // スキルレンジリスト内の位置にスキルボタンを配置
            foreach (Vector2 position in skillRange)
            {
                int x = (int)position.x;
                int y = (int)position.y;

                // ノードがグリッドの範囲内にあるか確認
                if (gmap.CheckBoundary(x, y))
                {

                    // スキル可能な位置に対応するワールド座標を取得
                    Vector3 worldPosition = gmap.GetWorldPosition(x, y);

                    // スキルボタンを生成して配置
                    GameObject button = Instantiate(SkillBtPrefab, panel);
                    button.transform.position = worldPosition;

                    // ボタンにスキルの処理を追加するなどの処理を行う
                    

                }
            }
        }
    }
    /*
    // スキルレンジがアタックレンジと同じかどうかを判定するメソッド
    private bool IsSkillRangeSameAsAttackRange(Units unit)
    {
        List<Vector2> skillRange = unit.skillRange;
        List<Vector2> attackRange = unit.attackRange;

        // スキルレンジとアタックレンジが同じであるかどうかを判定
        return skillRange.Count == attackRange.Count && new HashSet<Vector2>(skillRange).SetEquals(attackRange);
    }
    *//*
    // 移動ボタンの配置
    public void PlaceMoveButtons(Units unit)
    {
        // ユニットから移動可能範囲を取得
        List<Vector2> moveRange = unit.moveRange;

        // 移動範囲内の位置に移動可能なボタンを配置
        foreach (Vector2 position in moveRange)
        {
            int x = (int)position.x;
            int y = (int)position.y;

            // ノードがグリッドの範囲内にあるか確認
            if (gmap.CheckBoundary(x, y))
            {
                // ノードが通行可能かどうかを確認
                if (gmap.grid[x, y].passable)
                {
                    // 移動可能な場合は、その位置に移動ボタンを配置
                    Vector3 worldPosition = gmap.GetWorldPosition(x, y);
                    GameObject button = Instantiate(MoveBtPrefab, panel);
                    button.transform.position = worldPosition;
                }
            }
        }
    }*/
    /*
    // 攻撃の処理
    // 攻撃の処理
    private void OnAttackButtonClick(Units unit)
    {
        // ボタンがクリックされたときの攻撃処理を記述
        // ボタンのノード情報を取得し、そのノード上にUnitsがいるか判別
        // いるなら、イベントを発生させ、そのノード上のUnitsを取得する

        // ボタンが配置されたノードの位置を取得
        Vector2 buttonPosition = GetAttackButtonPosition(unit);

        // ノード上にUnitsが存在するかチェック
        if (IsUnitOnNode(buttonPosition))
        {
            // ノード上のUnitsを取得
            Units unitsOnNode = GetUnitsOnNode(buttonPosition);

            // OnAttackButtonClickイベントを発火し、Unitsを渡す
            if (unitsOnNode != null)
            {
                // ノード上にUnitsが存在する場合、イベントを発生
                OnPushAttackBt?.Invoke(unitsOnNode);
}
        }
    }*/
    /*
    // ボタンが配置されたノードの位置を取得するメソッド
    private Vector2 GetAttackButtonPosition(Units unit)
    {
        // ユニットから攻撃レンジリストを取得
        List<Vector2> attackRange = unit.attackRange;

        // ボタンが配置された位置を取得する
        foreach (Vector2 position in attackRange)
        {
            if (gmap.CheckBoundary((int)position.x, (int)position.y))
            {
                // ボタンの位置を返す
                return position;
            }
        }

        // ボタンが配置されていない場合は、デフォルトの位置を返す
        return Vector2.zero;
    }*/

    // ノード上にUnitsが存在するかどうかをチェックするメソッド
    private bool IsUnitOnNode(Vector2 position)
    {
        // ノード上にUnitsが存在するかをチェック
        // ここで必要に応じてノードの状態を確認してください
        // 例えば、gmap.grid[(int)position.x, (int)position.y]が空でないことを確認するなど
        return true; // 仮の返り値、実際の条件に合わせて修正してください
    }

    /*// ノード上のUnitsを取得するメソッド
    private Units GetUnitsOnNode(Vector2 position)
    {
        // ノード上のUnitsを取得する処理
        // 例えば、gmap.grid[(int)position.x, (int)position.y]からUnitsを取得するなど 
        //} else {return null;} // 仮の返り値、実際の条件に合わせて修正してください
    }
    /*
    // スキルの処理
    private void OnSkillButtonClick(Units unit)
    {
        // ボタンがクリックされたときのスキル処理を記述
        // ボタンのノード情報を取得し、そのノード上にUnitsがいるか判別
        // いるなら、イベントを発生させ、そのノード上のUnitsを取得する

        // ボタンが配置されたノードの位置を取得
        Vector2 buttonPosition = GetSkillButtonPosition(unit);

        // ノード上にUnitsが存在するかチェック
        if (IsUnitOnNode(buttonPosition))
        {
            // ノード上のUnitsを取得
            Units unitsOnNode = GetUnitsOnNode(buttonPosition);

            // OnSkillButtonClickイベントを発火し、Unitsを渡す
            if (unitsOnNode != null)
            {
                // ノード上にUnitsが存在する場合、イベントを発生
                
                OnPushSkillBt?.Invoke(unitsOnNode);
}
        }
    }
    */
    /*
    private Vector2 GetSkillButtonPosition(Units unit)
    {
        // ユニットから攻撃レンジリストを取得
        List<Vector2> attackRange = unit.skillRange;

        // ボタンが配置された位置を取得する
        foreach (Vector2 position in attackRange)
        {
            if (gmap.CheckBoundary((int)position.x, (int)position.y))
            {
                // ボタンの位置を返す
                return position;
            }
        }



    }*/
}
