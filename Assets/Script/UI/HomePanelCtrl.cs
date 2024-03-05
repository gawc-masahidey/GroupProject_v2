using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HomePanelCtrl : MonoBehaviour
{

    public GameObject HomePanel; // パネルを指定します
    public GameObject UnitAdmin;
    

    // Start is called before the first frame update
    void Start()
    {

        //HomePanel = GameObject.Find("PlayerHomePanel");
        if (HomePanel == null)
        {
            Debug.LogError("PlayerHomePanelが見つかりませんでした。");
        }

        //UnitAdmin = GameObject.Find("UnitController");
        if (UnitAdmin == null)
        {
            Debug.LogError("UnitControllerが見つかりませんでした。");
        }
    }

    // Update is called once per frame
    private void Update()
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
