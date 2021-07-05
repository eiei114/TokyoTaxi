using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobGenerator : MonoBehaviour
{
    [SerializeField] private GameObject mobprefab;
    [SerializeField] private float interval;
    //時間間隔の最小値
    public float minTime = 2f;
    //時間間隔の最大値
    public float maxTime = 5f;
    private float time = 0f;

   
    void Start()
    {
        interval = GetRandomTime();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if(time > interval)
        {
            //enemyをインスタンス化する(生成する)
            GameObject enemy = Instantiate(mobprefab);
            //生成した敵の座標を決定する(現状X=0,Y=10,Z=20の位置に出力)
            enemy.transform.position = new Vector3(0,10,20);
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
            //次に発生する時間間隔を決定する
            interval = GetRandomTime();
        }
    }
    
    public float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
}
