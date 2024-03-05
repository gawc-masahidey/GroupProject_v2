using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownManager : MonoBehaviour
{
    public TMP_Dropdown dropdown; // TextMeshPro��Dropdown�ɕύX

    [SerializeField] GameObject GameDirector;
    TurnAdmin TurnAdmin;

    public event Action<Units> OnUnitsSelected; // Units���I�����ꂽ�Ƃ��̃C�x���g
    Units unit;
    public int getIdNum;


    // Start is called before the first frame update
    void Start()
    {
        // Dropdown �C���X�^���X�̏�����
        dropdown = GetComponent<TMP_Dropdown>(); // TextMeshPro��Dropdown�ɕύX
        TurnAdmin = GameDirector.GetComponent<TurnAdmin>();

        // TurnAdmin �̃C�x���g���w��
        TurnAdmin.OnTurnChanged += UpdateDropdownOptions;

        if (dropdown == null)
        {
            Debug.LogError("Dropdown component not found");
            return;
        }

        // ����̃h���b�v�_�E���̏�����
        UpdateDropdownOptions();

        // �h���b�v�_�E���̑I�����ύX���ꂽ�Ƃ��ɌĂ΂�郊�X�i�[��ݒ�
        dropdown.onValueChanged.AddListener(DropdownValueChanged);

        // ����̑I�����ɑΉ�����Units�R���|�[�l���g���擾����
        DropdownValueChanged(dropdown.value);

    }

    // TurnAdmin �̃C�x���g�ŌĂ΂�郁�\�b�h
    void UpdateDropdownOptions()
    {
        dropdown.ClearOptions();

        GameObject[] sceneObjects;
        // �V�[����̃^�O�̃I�u�W�F�N�g���擾
        if (TurnAdmin != null)
        {
            if (TurnAdmin.GetTurn() == true)
            {
                sceneObjects = GameObject.FindGameObjectsWithTag("Player1");
            }
            else
            {
                sceneObjects = GameObject.FindGameObjectsWithTag("Player2");
            }

            // �I�u�W�F�N�g���̃��X�g���쐬
            List<TMP_Dropdown.OptionData> objectNames = new List<TMP_Dropdown.OptionData>(); // OptionData�ɕύX

            foreach (GameObject obj in sceneObjects)
            {
                // �I�u�W�F�N�g�������X�g�ɒǉ�
                objectNames.Add(new TMP_Dropdown.OptionData(obj.name)); // OptionData�ɕύX
            }

            // �h���b�v�_�E���̃I�v�V�����Ƃ��ă��X�g��ݒ�
            dropdown.AddOptions(objectNames);
        }
        else
        {
            Debug.LogError("TurnAdmin component not found");
        }
    }

    // �h���b�v�_�E���̑I�����ύX���ꂽ���ɌĂ΂�郁�\�b�h
    void DropdownValueChanged(int value)
    {
        //unit������
        unit = null;
        // �I�����ꂽ�I�u�W�F�N�g�����擾
        string selectedObjectName = dropdown.options[value].text;

        // �����őI�����ꂽ�I�u�W�F�N�g�ɑ΂��鏈�����s��
        Debug.Log("Selected Object: " + selectedObjectName);

        // �I�����ꂽ�I�u�W�F�N�g�̃R���|�[�l���g���擾
        GameObject selectedObject = GameObject.Find(selectedObjectName);
        if (selectedObject != null)
        {
            
            unit = selectedObject.GetComponentInChildren<Units>(); // �K�؂ȃR���|�[�l���g�ɕύX����K�v������܂�
            if (unit != null)
            {
                // �R���|�[�l���g���I�����ꂽ�C�x���g�𔭐�������
                OnUnitsSelected?.Invoke(unit);
            }
            else
            {
                Debug.LogError("Component not found on selected object: " + selectedObjectName);
            }
        }
        else
        {
            Debug.LogError("Selected object not found: " + selectedObjectName);
        }

        getIdNum = unit.GetIdentifyNum();
        

    }
    
}
