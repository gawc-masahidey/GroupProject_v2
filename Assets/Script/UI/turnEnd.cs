using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class turnEnd : MonoBehaviour
{
    [SerializeField] GameObject GameDirector;
    TurnAdmin TurnAdmin;
    // Start is called before the first frame update
    void Start()
    {
        TurnAdmin = GameDirector.GetComponent<TurnAdmin>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickTurnEnd()
    {
        TurnAdmin.ToggleTurn();
        //cameraCtrl
        //サイドに合わせて反転するコードの追加
    }

}
