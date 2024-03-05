using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlUnitTurn : MonoBehaviour
{
    TurnAdmin TAdmin;
    Units unitComponent;

    // �v���C���[1�ƃv���C���[2�̃^�O
    private const string Player1Tag = "Player1";
    private const string Player2Tag = "Player2";

    int TurnEndUnit { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        TAdmin = GetComponent<TurnAdmin>();
        TAdmin.OnTurnChanged += ResetEndUnitCount;

        // Player1��Player2�^�O������GameObject���擾���AUnits�R���|�[�l���g���擾����
        GameObject[] player1Objects = GameObject.FindGameObjectsWithTag(Player1Tag);
        foreach (GameObject obj in player1Objects)
        {
            unitComponent = obj.GetComponent<Units>();
            if (unitComponent != null)
            {
                // Units�R���|�[�l���g�̃C�x���g��EndUnitCount()���\�b�h��o�^
                unitComponent.EndUnit += EndUnitCount;
            }
        }

        GameObject[] player2Objects = GameObject.FindGameObjectsWithTag(Player2Tag);
        foreach (GameObject obj in player2Objects)
        {
            unitComponent = obj.GetComponent<Units>();
            if (unitComponent != null)
            {
                // Units�R���|�[�l���g�̃C�x���g��EndUnitCount()���\�b�h��o�^
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
        // EndUnitCount()���\�b�h�̎���
        TurnEndUnit++;
        if (TurnEndUnit == 3)
        {
            TAdmin.ToggleTurn();
        }
    }

    public void ResetEndUnitCount()
    {
        // ResetEndUnitCount()���\�b�h�̎���
        TurnEndUnit = 0;
    }
}

