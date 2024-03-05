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
        // Turn�̏�Ԃ��ω������Ƃ��ɌĂяo�����\�b�h��o�^
        TurnAdmin.OnTurnChanged += UpdateTurnText;
        // ������ԂŃe�L�X�g���X�V
        UpdateTurnText();
    }

    // UI�̃e�L�X�g���X�V���郁�\�b�h
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

    // TurnAdmin����̃C�x���g���󂯎���ăe�L�X�g���X�V
    void OnTurnChanged()
    {
        UpdateTurnText();
    }

    // �j�����ɃC�x���g���X�i�[������
    private void OnDestroy()
    {
        TurnAdmin.OnTurnChanged -= UpdateTurnText;
    }
}
