using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //׃���ı�
        //׃���Ǿ���һ����С��"����" ���Դ�Ÿ���͵Ĕ���(������С�����ı���bool)

        //ʹ�÷�ʽ- <�_����(Ĭ�Jprivate)> <���(int float...)> = <��ʼֵ>
        //����
        int int01 = 0;
        //С��
        float float01 = 0.4f;
        //����
        string stringnoeko = "meow~";
        //�Ƿ�
        bool firstbool = true;

        int pass = 60;
        int score = 60;

        Newclass dog = new Newclass();
        dog.a = 10;

        int[]a3 = new int [6];

        a3[0] = 1;
        
       


        //�l���Z��- ����ֱ�X�ķ��g�� ���(if) xxx(bool) �t {����ĳ������} ��Ȼ��(else) {������һ������} 
        //ʹ�÷�ʽ- if (bool) {���д��a} else {}
        if ( score >= pass )
        {
            print("mission pass");
        }
        else
        {
            print("mission fail");
        }

        //ѭ�h�Z��(while)- ����ֱ�X�ķ��g�� ��(while) ����ĳ������ (bool) �t���������������{���е�����}
        //ʹ�÷�ʽ-  while(bool) {���д��a}
        int aaaa = 0;
        while (aaaa<5 )
        {
            aaaa = aaaa + 1;
            print("peko!");
        }

        //ѭ�h�Z��(for)- ����ֱ�X�ķ��g�� ��(for) ѭ�h׃���ĳ�ʼֵ(����int i = n) ; ѭ�h���m�ėl��(bool) ѭ�h�l�������(true)�Y������еĴ��a {�t���@������!}
        //ʹ�÷�ʽ for(a;b;c;) {���@������}   -> a=��ʼֵ b=���m�l�� c=�Y�������! 
        for (int i = 0; i < 10; i = i + 1) 
        {
            print("hahahaha!");
        }

        //����- �����J���ǰ�����һЩ���a��׃��{��Ҫ�Ƿ���̖�Ј��е�����}
        //�����T-����������ĸҪ��
        //ʹ�÷�ʽ- ������� ���Q (����) {�{����ֵ�����}
        int Aow(int a , int b)
        {
            int c = a+b;
            return c;
        }


        //ԇԇ���{�ú�����! 
        print(Aow(4,2));
        //��Ҫ�^��- =���xֵ�K�� ==
        int upup = Aow(4, 2);

        //���M
        //���xһ"��"��������
        int a = 0;
        //���xһ"�M"�������� ���:��������a2�����傀�b���ֵĲ� (��һ����int �������κ���͵�string / ����...��)
        int[] a2 = new int [5];
        //ʹ��
        a2[0] = 1;
        a2[4] = 5;

        //ԇ�������M�e��Ĕ���ͨͨ�ĳ�1!
        for (int i = 0; i < 5;  i=i+1 )
        {
            a2[i] = 1;
        }

    }

    //�������κΖ|���ĺ���
    //ʹ�÷�ʽ void ���Q () {}
    void Bow ()
    {

    }



    }







  



public class Newclass
{
    public int a;
}

//�����κ�
