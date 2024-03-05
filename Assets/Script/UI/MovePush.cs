using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePush : MonoBehaviour
{
    [SerializeField] GameObject dd;
    DropdownManager ddManager;

    Units unit;

    // Start is called before the first frame update
    void Start()
    {
        ddManager = dd.GetComponent<DropdownManager>();

        ddManager.OnUnitsSelected += UpdateMoveButton;


    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateMoveButton(Units seleUnit)
    {
        //イベントごとに変更するようにする
        unit = seleUnit;
    }

    public void OnMoveButtan()
    {
        unit.Move();
    }

}

