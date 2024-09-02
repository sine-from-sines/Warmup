using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //! このオブジェクトを2つ以上生成しない
    public static GameController instance = null;
    //! スコア
    public int score = 0;
    //! ハイスコア記録
    public int[] scoreRanking = new int[10];

    // Start is called before the first frame update
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
