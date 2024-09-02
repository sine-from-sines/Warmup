using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //! ���̃I�u�W�F�N�g��2�ȏ㐶�����Ȃ�
    public static GameController instance = null;
    //! �X�R�A
    public int score = 0;
    //! �n�C�X�R�A�L�^
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
