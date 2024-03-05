using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HomePanelCtrl : MonoBehaviour
{

    public GameObject HomePanel; // �p�l�����w�肵�܂�
    public GameObject UnitAdmin;
    

    // Start is called before the first frame update
    void Start()
    {

        //HomePanel = GameObject.Find("PlayerHomePanel");
        if (HomePanel == null)
        {
            Debug.LogError("PlayerHomePanel��������܂���ł����B");
        }

        //UnitAdmin = GameObject.Find("UnitController");
        if (UnitAdmin == null)
        {
            Debug.LogError("UnitController��������܂���ł����B");
        }
    }

    // Update is called once per frame
    private void Update()
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
