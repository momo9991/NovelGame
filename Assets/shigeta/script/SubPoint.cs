using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPoint : MonoBehaviour
{
    // 別のメソッドでも動くフィールド関数を宣言
    private double point;
    private double add;
    private double crrect;
    private int counter;

    public SubPoint() {
        // フィールド関数の初期化
        point = 0;
        add = 0;
        crrect = 1;
        counter = 0;
    }

    // 授業のパラメータ計算
    public void classCalc(int att) {

        // 授業態度による点数の判定
        if (att == 0) {
            add = add + 5;
        }
        else if (att == 1) {
            add = add + 3;
        }
        else if (att == 2) {
            add = add + 1;
        }

        // 点数の追加及び上限制御
        if (point < 100) {
            point = point + (add * crrect);

            if (point > 100) {
                point = 100;
            }
        }

        // 補正値の管理
        if (counter >= 1) {
            crrectCount();
        }
    }

    // 補正値とカウンターの変更
    public void crrectCount () {
        counter += 1;
        crrect = crrect * 1.2;

        // 初期化
        if (counter >= 4 || counter <= 0) {
            counter = 0;
            crrect = crrect / 1.2;
        }
    }


}
