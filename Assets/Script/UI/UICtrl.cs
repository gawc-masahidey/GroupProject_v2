using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : MonoBehaviour
{
    public GameObject HomePanel; // �p�l�����w�肵�܂�
    public GameObject UnitAdmin;

    // Start is called before the first frame update
    void Start()
    {
        //HomePanel = GameObject.Find("PlayerHomePanel");
        //UnitAdmin = GameObject.Find("UnitController");
        
        ShowHomePanel();
        HideUnitAdminPanel();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �ʂ̕��@�F�p�l����\�����܂�
    public void ShowHomePanel()
    {
        HomePanel.SetActive(true);
    }

    // �ʂ̕��@�F�p�l�����\���ɂ��܂�
    public void HideHomePanel()
    {
        HomePanel.SetActive(false);
    }

    public void ShowUnitAdminPanel()
    {
        UnitAdmin.SetActive(true);
    }

    public void HideUnitAdminPanel()
    {
        UnitAdmin.SetActive(false);
    }

}
