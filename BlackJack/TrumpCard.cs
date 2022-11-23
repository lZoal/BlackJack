using System;
using System.Collections.Generic;
using System.Drawing;
public class Pair<T, U>
{
    public Pair()
    {
    }

    public Pair(T first, U second)
    {
        this.First = first;
        this.Second = second;
    }

    public T First { get; set; }
    public U Second { get; set; }
};
// 트럼프카드 52장
// ( 1 ~ 13 ) * 4
// A(1) 2 ~ 10 J(11) Q(12) K(13)
// 0~12 -> Spade, 13~25 Diamond, 26~38 Heart, 39~51 Clover

/*
    랜덤번호(0~51) 실제번호(1~13)
    숫자 : 13 다이아	-> 1
    숫자 : 3  클로버->4 
*/
class TrumpCard
{
    //랜덤숫자 배열
    Pair<int, Bitmap>[] deck = new Pair<int, Bitmap>[52];
    // 중복체크
    bool[] swit = new bool[52];
    int r, w = 0;

    void init_swit()
    {
        for (int i = 0; i < swit.Length; i++)
        {
            //중복상태 초기화
            swit[i] = false;
        }

    }
    //덱 셔플
    void suffle_deck()
    {
        w=0,r = 0;
        while(w<52)
        {

            Random rand = new Random();
            r = rand.Next(0, 52);
            String path = "./Img" + r + ".png";
            Bitmap img = new Bitmap(path);
            if (swit[r] == false)
            {
                swit[r] = true;
                deck[w].First = r;
                deck[w].Second = img;
                w++;  

            }
        }


}