using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUseBt : MonoBehaviour
{
    //DDown
    [SerializeField] GameObject DD;
    DropdownManager ddManag;

    [SerializeField] GameObject BattleBt;
    [SerializeField] GameObject MoveBt;
    [SerializeField] GameObject SkillBt;
    //[SerializeField] GameObject TacBt;
    //[SerializeField] GameObject TicBt;

    // 外部スクリプトから条件を取得するための参照
    Units unit;
    

    // Start is called before the first frame update
    void Start()
    {
        ddManag = DD.GetComponent<DropdownManager>();
        ddManag.OnUnitsSelected += UpdateBtState;
        // ボタンの使用可否を更新
        UpdateButtonAvailability();
    }

    // 条件に基づいてボタンの使用可否を更新するメソッド
    void UpdateButtonAvailability()
    {
        // 条件を取得してボタンの使用可否を判断
        bool canUseBattleButton = unit.enableAttack;
        bool canUseMoveButton = unit.enableMove;
        bool canUseSkillButton = unit.enableSkill;

        // ボタンの使用可否を設定
        BattleBt.SetActive(canUseBattleButton);
        MoveBt.SetActive(canUseMoveButton);
        SkillBt.SetActive(canUseSkillButton);
        
    }

    void UpdateBtState(Units SelctedUnit) 
    {
        unit = SelctedUnit;
        UpdateButtonAvailability();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

