using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bossクラス
public class Boss
{
  
    //Magic関数
    public void Magic(int mp)
    {
        
        Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

        //MPが足りないとき
        if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
   
}

public class ScriptTest : MonoBehaviour
{
    //変数mpの初期化
    private int mp = 53;
    // Start is called before the first frame update
    void Start()
    {
        //配列の初期化
        int[] array = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();
        for (int i = 0; i < 10; i++)
        {
            //Magic関数を呼び出す
            boss.Magic(mp -= 5);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
