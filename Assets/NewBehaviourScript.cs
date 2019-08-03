using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");

        //1.변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "Gini";
        bool isFullLevel = false;

        Debug.Log(" 용사의 이름은 ?");
        Debug.Log(playerName);
        Debug.Log(" 용사의 레벨은 ?");
        Debug.Log(level);
        Debug.Log(" 용사의 힘은 ?");
        Debug.Log(strength);
        Debug.Log(" 용사는 만랩인가 ? ================== \n\n");
        Debug.Log(isFullLevel);

        //2.그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        Debug.Log(monsterLevel[0]);

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);


        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("생명물약30");

        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3.연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strenght = level * 3.1f;

        int nextExp = 300 - (exp % 300);
    }
}
