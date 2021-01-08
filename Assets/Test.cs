using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔力（発展課題）

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法用の関数（発展課題）
    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPがたりないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{
    


    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す（発展課題）
        lastboss.Magic();
        //10回利用後のテスト
        int count = 10;//繰り返し回数指定
        for(int i = 1; i <= count; i++)
        {
            Debug.Log("連続魔法" + i + "回目。");
            lastboss.Magic();
        }


        //レッスン4の課題作成
        //条件１（要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください）
        int[] kadai = new int[5];
        kadai[0] = 0;
        kadai[1] = 10;
        kadai[2] = 20;
        kadai[3] = 30;
        kadai[4] = 40;

        //条件２（for文を使い、配列の各要素の値を順番に表示してください）
        Debug.Log("課題：順番");
        for (int i = 0; i < kadai.Length; i++)
        {
            Debug.Log(kadai[i]);
        }

        //条件３（for文を使い、配列の各要素の値を逆順に表示してください）
        Debug.Log("課題：逆順");
        for (int i = 0; i < kadai.Length; i++)
        {
            int j = kadai.Length - 1;
            j -= i;
            Debug.Log(kadai[j]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}