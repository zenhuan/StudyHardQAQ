using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //變量文本
        //變量是具有一定大小的"容器" 可以存放各類型的數據(整數、小數、文本、bool)

        //使用方式- <開放性(默認private)> <類型(int float...)> = <初始值>
        //整數
        int int01 = 0;
        //小數
        float float01 = 0.4f;
        //文字
        string stringnoeko = "meow~";
        //是否
        bool firstbool = true;

        int pass = 60;
        int score = 60;

        Newclass dog = new Newclass();
        dog.a = 10;

        int[]a3 = new int [6];

        a3[0] = 1;
        
       


        //條件語句- 可以直覺的翻譯為 如果(if) xxx(bool) 則 {執行某件事情} 不然就(else) {執行另一件事情} 
        //使用方式- if (bool) {執行代碼} else {}
        if ( score >= pass )
        {
            print("mission pass");
        }
        else
        {
            print("mission fail");
        }

        //循環語句(while)- 可以直覺的翻譯為 當(while) 符合某件事情 (bool) 則不斷執行以下事項{執行的事情}
        //使用方式-  while(bool) {執行代碼}
        int aaaa = 0;
        while (aaaa<5 )
        {
            aaaa = aaaa + 1;
            print("peko!");
        }

        //循環語句(for)- 可以直覺的翻譯為 當(for) 循環變量的初始值(例如int i = n) ; 循環持續的條件(bool) 循環條件如果為(true)結束後執行的代碼 {則做這件事情!}
        //使用方式 for(a;b;c;) {做這件事情}   -> a=初始值 b=持續條件 c=結束後執行! 
        for (int i = 0; i < 10; i = i + 1) 
        {
            print("hahahaha!");
        }

        //函數- 可以認為是包含了一些代碼的變量{主要是方框號中執行的事情}
        //好習慣-函數的首字母要大寫
        //使用方式- 數據類型 名稱 (參數) {調用後幹的事情}
        int Aow(int a , int b)
        {
            int c = a+b;
            return c;
        }


        //試試看調用函數吧! 
        print(Aow(4,2));
        //重要觀念- =是賦值並非 ==
        int upup = Aow(4, 2);

        //數組
        //定義一"個"數字如下
        int a = 0;
        //定義一"組"數字如下 解釋:可以想像a2內有五個裝數字的槽 (不一定是int 可能是任何類型的string / 函數...等)
        int[] a2 = new int [5];
        //使用
        a2[0] = 1;
        a2[4] = 5;

        //試著將數組裡面的數字通通改成1!
        for (int i = 0; i < 5;  i=i+1 )
        {
            a2[i] = 1;
        }

    }

    //不帶回任何東西的函數
    //使用方式 void 名稱 () {}
    void Bow ()
    {

    }



    }







  



public class Newclass
{
    public int a;
}

//不帶任何
