using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGUI : MonoBehaviour
{
    IUserAction userAction;
    public string gameMessage ;
    public int time;
    GUIStyle style, bigstyle;
    // Start is called before the first frame update
    void Start()
    {
        // 定义游戏时间
        time = 120;
        userAction = SSDirector.GetInstance().CurrentSceneController as IUserAction;
        // 定义时间文本颜色
        style = new GUIStyle();
        style.normal.textColor = Color.blue;
        style.fontSize = 30;
        // 定义游戏名称文本颜色
        bigstyle = new GUIStyle();
        bigstyle.normal.textColor = Color.white;
        bigstyle.fontSize = 50;  
    }

    // Update is called once per frame
    void OnGUI() {
        userAction.Check();
        GUI.Label(new Rect(160, Screen.height * 0.1f, 50, 200), "牧师与魔鬼", bigstyle);
        GUI.Label(new Rect(250, 100, 50, 200), gameMessage, style);
        GUI.Label(new Rect(0,0,100,50), "剩余时间: " + time, style);
    }
}
