using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnTextCtrl : MonoBehaviour
{
    public TextMeshProUGUI TurnUI;

    [SerializeField] GameObject GameDirector;
    TurnAdmin TurnAdmin;

    // Start is called before the first frame update
    void Start()
    {
        TurnAdmin = GameDirector.GetComponent<TurnAdmin>();
        // Turnの状態が変化したときに呼び出すメソッドを登録
        TurnAdmin.OnTurnChanged += UpdateTurnText;
        // 初期状態でテキストを更新
        UpdateTurnText();
    }

    // UIのテキストを更新するメソッド
    void UpdateTurnText()
    {
        if (TurnAdmin.IsRedTurn)
        {
            TurnUI.text = "Red";
        }
        else
        {
            TurnUI.text = "Blue";
        }
    }

    // TurnAdminからのイベントを受け取ってテキストを更新
    void OnTurnChanged()
    {
        UpdateTurnText();
    }

    // 破棄時にイベントリスナーを解除
    private void OnDestroy()
    {
        TurnAdmin.OnTurnChanged -= UpdateTurnText;
    }
}
