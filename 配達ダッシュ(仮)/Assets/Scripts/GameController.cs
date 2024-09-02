using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //! ���̃I�u�W�F�N�g��2�ȏ㐶�����Ȃ�
    [SerializeField] static GameController instance = null;
    //! �X�R�A
    [SerializeField] int score = 0;

    //! �n�C�X�R�A�L�^(����10�ʂ܂�)
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
