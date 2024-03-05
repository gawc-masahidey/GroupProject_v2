using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : MonoBehaviour
{
    public GameObject HomePanel; // パネルを指定します
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

    // 別の方法：パネルを表示します
    public void ShowHomePanel()
    {
        HomePanel.SetActive(true);
    }

    // 別の方法：パネルを非表示にします
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
