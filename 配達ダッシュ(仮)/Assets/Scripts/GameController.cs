using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //! このオブジェクトを2つ以上生成しない
    static GameController instance = null;
    //! スコア
    [SerializeField] int score = 0;
    //! 1mごとに加算されるスコア量
    [SerializeField] const int scorePerMeters = 10;
    //! 速度初期値
    [SerializeField] const float speed = 1.0f;
    //! 速度、一定距離ごとの加速度
    [SerializeField] const float speedAccel = 0.1f;
    //! 速度、加速する頻度
    [SerializeField] const float speedAccelFreq = 10.0f;
    //! 速度最大値
    [SerializeField] const float speedMax = 10.0f;

    //! ハイスコア記録(仮で10位まで)
    [SerializeField] int[] scoreRanking = new int[10];

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log("Game Started!");
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
