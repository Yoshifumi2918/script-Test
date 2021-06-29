using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 発展課題 Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出そう


    public class Boss

{
    //int型の変数mpを宣言し、初期化

    private int mp = 53;

    //魔法攻撃関数

    public void Magic(int dec)
    {
        //mpが5以上の場合、5減らし、文章を表示

        if (mp >= 5)
        {
            this.mp -= dec;

            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");


         //mpが足りない場合の文章を表示

        } else if (mp < 5)
        {

            Debug.Log("MPが足りないため魔法が使えない。");

        }


    }
}


public class Test : MonoBehaviour
{




    // Use this for initialization
    void Start()
    {

        //課題1　配列を初期化する

        int[] array = { 10, 20, 30, 40, 50 };

        //課題2　for文を使用し、配列の各要素の値を順番に表示する

        for(int i = 0; i < array.Length; i++ )
        {
            Debug.Log(array[i]);

        }
       
        //課題3　for文を使用し、配列の各要素の値を逆順に表示する

        for(int a = array.Length -1; 0 <= a; a--)
        {
            Debug.Log(array[a]);
        }


        //Bossクラスの変数を宣言してインスタンスを代入

        Boss MagicMan = new Boss ();

        //Magic関数を呼び出して、魔法を使用

        MagicMan.Magic(5);

        //Magic関数を10回使用した際の確認

        int n = 10;

        for (int i = 0; i < n; i++)
        {

            MagicMan.Magic(5);

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}





