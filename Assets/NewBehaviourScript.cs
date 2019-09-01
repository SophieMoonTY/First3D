﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    string title = "전설의";
    string playerName = "나검사";
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    int level = 5;
    bool isFullLevel = false;

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
        playerName = "똥쟁이";
        Debug.Log(" 용사의 이름은 again ?");
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
        Debug.Log("사막뱀의 레벨은?");
        Debug.Log(monsterLevel[2]);
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
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 && mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        ///4.키워드
        //int float = 1;
        //string name = List;

        //5.조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요. ");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋습니다. ");
        }
        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }
        switch (monsters[0])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현");
                break;
            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
        }

        //6.반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다." + health);
            else
                Debug.Log("사망하였습니다.");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }
        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("븡대로 치료중 ......." + health);
        }
        for (int index = 0; index < monsters.Length; index++)
        {
            //Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }
        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        //7.함수(메소드)
        Heal();

        for (int idx = 0; idx < monsters.Length; idx++)
        {
            Debug.Log("용사는 " + monsters[idx] + " 에게 " + Battle(monsterLevel[idx]));
        }

        //8. 클래스
        player player = new player();
        player.id = 0;
        player.name = "나법사";
        player.title = "나현명";
        player.strength = 2.4f;
        player.weapon = "나무지팡이";
        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다");
    }

    void Heal()
    {
        health += 10;
        Debug.Log("힘을 받았습니다." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)

            result = "이겼습니다.";
        else
            result = "졌습니다";

        return result;
    }
}
 