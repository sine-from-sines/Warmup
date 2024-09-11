using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //! ���̃I�u�W�F�N�g��2�ȏ㐶�����Ȃ�
    static GameController instance = null;
    //! �X�R�A
    [SerializeField] int score = 0;
    //! 1m���Ƃɉ��Z�����X�R�A��
    [SerializeField] const int scorePerMeters = 10;
    //! ���x�����l
    [SerializeField] const float speed = 1.0f;
    //! ���x�A��苗�����Ƃ̉����x
    [SerializeField] const float speedAccel = 0.1f;
    //! ���x�A��������p�x
    [SerializeField] const float speedAccelFreq = 10.0f;
    //! ���x�ő�l
    [SerializeField] const float speedMax = 10.0f;

    //! �n�C�X�R�A�L�^(����10�ʂ܂�)
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
