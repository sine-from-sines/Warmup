using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //! このオブジェクトを2つ以上生成しない
    [SerializeField] static GameController instance = null;
    //! スコア
    [SerializeField] int score = 0;

    //! ハイスコア記録(仮で10位まで)
    [SerializeField] int[] scoreRanking = new int[10];

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
