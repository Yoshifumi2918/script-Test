using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���W�ۑ� Boss�N���X�ɁA�ϐ�mp��Magic�֐����쐬����Start�֐�����Ăяo����


    public class Boss

{
    //int�^�̕ϐ�mp��錾���A������

    private int mp = 53;

    //���@�U���֐�

    public void Magic(int dec)
    {
        //mp��5�ȏ�̏ꍇ�A5���炵�A���͂�\��

        if (mp >= 5)
        {
            this.mp -= dec;

            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");


         //mp������Ȃ��ꍇ�̕��͂�\��

        } else if (mp < 5)
        {

            Debug.Log("MP������Ȃ����ߖ��@���g���Ȃ��B");

        }


    }
}


public class Test : MonoBehaviour
{




    // Use this for initialization
    void Start()
    {

        //�ۑ�1�@�z�������������

        int[] array = { 10, 20, 30, 40, 50 };

        //�ۑ�2�@for�����g�p���A�z��̊e�v�f�̒l�����Ԃɕ\������

        for(int i = 0; i < array.Length; i++ )
        {
            Debug.Log(array[i]);

        }
       
        //�ۑ�3�@for�����g�p���A�z��̊e�v�f�̒l���t���ɕ\������

        for(int a = array.Length -1; 0 <= a; a--)
        {
            Debug.Log(array[a]);
        }


        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����

        Boss MagicMan = new Boss ();

        //Magic�֐����Ăяo���āA���@���g�p

        MagicMan.Magic(5);

        //Magic�֐���10��g�p�����ۂ̊m�F

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





