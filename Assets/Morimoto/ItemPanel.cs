using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    public GameObject btn;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject parent;

    int weekCount = 50;//今入れているのは仮。clickCountをとってきて、何周目かを判別する
    //int weekCount = PlayerPrefs.GetInt("ClickCount"); //これで何周目かをとってこれるはず…

    // シーンのロード時に自動で実行される
    void Start()
    {
        if(weekCount <= 30){
            for(int i= 1; i <= 3; i++){
            // ボタン生成
            InstantiateUIBtn(parent, "MyButton" + i, i * 200f - 600, 200f);
            }
        }else{
            for(int i= 2; i <= 3; i++){
            // ボタン生成
            InstantiateUIBtn(parent, "MyButton" + i, i * 200f - 800, 200f);
            }
        }
    }

    // ボタン生成メソッド
    public void InstantiateUIBtn(GameObject parent, string name, float pos_x, float pos_y)
    {
        if(name.Equals("MyButton1")){
             GameObject ui_btn = Instantiate(this.btn, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        // 空のオブジェクトを親に指定
        ui_btn.transform.SetParent(this.parent.transform, false);
        ui_btn.name = name;

        // クリックイベントを付与
        ui_btn.GetComponent<Button>().onClick.AddListener(() => BtnOnClick(ui_btn));
        }
        else if(name.Equals("MyButton2")){
             GameObject ui_btn = Instantiate(this.btn2, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        // 空のオブジェクトを親に指定
        ui_btn.transform.SetParent(this.parent.transform, false);
        ui_btn.name = name;

        // クリックイベントを付与
        ui_btn.GetComponent<Button>().onClick.AddListener(() => BtnOnClick(ui_btn));
        }
        else if(name.Equals("MyButton3")){
             GameObject ui_btn = Instantiate(this.btn3, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        // 空のオブジェクトを親に指定
        ui_btn.transform.SetParent(this.parent.transform, false);
        ui_btn.name = name;

        // クリックイベントを付与
        ui_btn.GetComponent<Button>().onClick.AddListener(() => BtnOnClick(ui_btn));
        }
    }

    // クリックイベント内容
    void BtnOnClick(GameObject btn) {
        if(btn.name.Equals("MyButton1")){
            Debug.Log("校庭へ行く");
            Debug.Log("今" + weekCount + "周目");
        }
        else if(btn.name.Equals("MyButton2")){
            Debug.Log("家に帰る");
            Debug.Log("今" + weekCount + "周目");
        }else if(btn.name.Equals("MyButton3")){
            Debug.Log("ゲームセンターに行く");
            Debug.Log("今" + weekCount + "周目");
        }
    }
}
