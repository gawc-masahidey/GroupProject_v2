using System;
using UnityEngine;

public class TurnAdmin : MonoBehaviour
{
    private bool turn;
    public bool IsRedTurn { get { return turn; } }
    public event Action OnTurnChanged; // Turn�̏�Ԃ��ω������Ƃ��ɌĂяo���C�x���g

    void Start()
    {
        turn = true;
    }

    void Update()
    {

    }

    // turn �t�B�[���h�̃Q�b�^�[
    public bool GetTurn()
    {
        return turn;
    }

    // turn �t�B�[���h�̃Z�b�^�[
    public void SetTurn(bool value)
    {
        if (turn != value)
        {
            turn = value;
            // Turn�̏�Ԃ��ω��������Ƃ�ʒm
            OnTurnChanged?.Invoke();
        }
    }

    public void ToggleTurn()
    {
        SetTurn(!turn); // Turn�̒l�𔽓]������

        // Player1�^�O�����I�u�W�F�N�g���擾���AUnits�R���|�[�l���g���擾����
        GameObject[] player1Objects = GameObject.FindGameObjectsWithTag("Player1");
        foreach (GameObject obj in player1Objects)
        {
            Units unitsComponent = obj.GetComponent<Units>();
            if (unitsComponent != null)
            {
                // ������Units�R���|�[�l���g�ɑ΂��鏈�����s��
                unitsComponent.unitTurnStart();
            }
        }

        // Player2�^�O�����I�u�W�F�N�g���擾���AUnits�R���|�[�l���g���擾����
        GameObject[] player2Objects = GameObject.FindGameObjectsWithTag("Player2");
        foreach (GameObject obj in player2Objects)
        {
            Units unitsComponent = obj.GetComponent<Units>();
            if (unitsComponent != null)
            {
                // ������Units�R���|�[�l���g�ɑ΂��鏈�����s��
                unitsComponent.unitTurnStart();
            }
        }
    }
}
