using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPush : MonoBehaviour
{
    [SerializeField] GameObject dd;
    DropdownManager ddManager;

    Units unit;

    // Start is called before the first frame update
    void Start()
    {
        ddManager = dd.GetComponent<DropdownManager>();

        ddManager.OnUnitsSelected += UpdateSkillButton;


    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateSkillButton(Units seleUnit)
    {
        //イベントごとに変更するようにする
        unit = seleUnit;
    }

    public void OnSkillButtan()
    {
        unit.Skill();
    }

}
