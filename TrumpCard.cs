using System;

class TrumpCard
{
    //랜덤숫자 배열
    int[] number = new int[52];
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

    void suffle_deck()
    {
        Random rand = new Random();
        r = rand.Next(0, 521)
        }

}