using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && this.transform.position.y == -1f)
        {
            StartCoroutine(Jump());
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && this.transform.position.y == -1f)
        {
            StartCoroutine(Slide());
        }

    }

    IEnumerator Jump()
    {
        float Acsel = 0.03f;
        while (true)
        {
            Vector2 Position = transform.position;

            Position.y += Acsel;
            transform.position = Position;

            Acsel -= 0.0002f;

            if (transform.position.y <= -1)
            {
                break;
            }

            yield return null;


        }

        this.transform.position = new Vector2(0f, -1f);
        yield return null;
    }

    IEnumerator Slide()
    {
        int WaitFrame = 200;
        int DownFrame = 100;



        for (int i = 0; i < DownFrame; i++)
        {
            Vector3 Position = transform.position;
            Vector3 Scale = transform.localScale;

            Position.y -= 0.5f / DownFrame;
            Scale.y -= 0.2f / DownFrame;
            this.transform.position = Position;
            this.transform.localScale = Scale;
            yield return null;
        }


        for (int i = 0; i < WaitFrame; i++)
        {
            yield return null;
        }


        this.transform.position = new Vector2(0f, -1f);
        this.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        yield return null;
    }
}