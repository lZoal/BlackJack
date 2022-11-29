using System;
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
// 0~12 -> Clover, 13~25 Diamond, 26~38 Heart, 39~51 Spade

/*
    랜덤번호(0~51) 실제번호(1~13)
    숫자 : 13 다이아	-> 1
    숫자 : 3  클로버->4 
*/
public class TrumpCard
{

    //랜덤숫자 배열
    public Pair<int, String>[] deck = new Pair<int, String>[52];
    // 중복체크
    bool[] swit = new bool[52];
    int r, w = 0;
    public TrumpCard()
    {
        init_swit();
        suffle_deck();
    }
    public void init_swit()
    {
        for (int i = 0; i < swit.Length; i++)
        {
            //중복상태 초기화
            swit[i] = false;
        }

    }
    //덱 셔플
    public void suffle_deck()
    {
        w = 0;
        r = 0;
        Random rand = new Random();
        while (w < 52)
        {
            r = rand.Next(0, 52);

            if (swit[r] == false)
            {
                swit[r] = true;
                String path = "./Img/" + r + ".png";
                r = r % 13 >= 10 ? 10 : r % 13 + 1;
                Pair<int, String> tmp = new Pair<int, String>(r, path);
                deck[w++] = tmp;

            }
        }


    }

}