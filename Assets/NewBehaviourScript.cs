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
        level = (int)(2.4);
        Debug.Log(" 변환 후 level " + level);
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
        // Debug.Log(items[1]);

        //3.연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        // strengh = level * 3.1f;

        Debug.Log("  exp " + exp + " level : " + level);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);
        Debug.Log("  5 / 3 : " + (5.0 / 3));

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

    }
}
 