using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BattlePush : MonoBehaviour
{
    [SerializeField] GameObject dd;
    DropdownManager ddManager;

    Units unit;

    // Start is called before the first frame update
    void Start()
    {
        ddManager = dd.GetComponent<DropdownManager>();

        ddManager.OnUnitsSelected += UpdateBattleButton;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateBattleButton(Units seleUnit) 
    {
        //イベントごとに変更するようにする
        unit = seleUnit;
    }

    public void OnBattleButtan()
    {
        unit.Attack();
    }

}
