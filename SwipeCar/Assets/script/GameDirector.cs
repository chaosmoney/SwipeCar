using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject carGo;
    GameObject flagGo;
    GameObject distanceGo;
    bool state = true;

    // Start is called before the first frame update
    void Start()
    {
        //�ڵ���
        this.carGo = GameObject.Find("car");
        //���
        this.flagGo = GameObject.Find("flag");
        this.distanceGo = GameObject.Find("Distance");

        Debug.LogFormat("{0}", carGo);
        Debug.LogFormat("{0}", flagGo);
        Debug.LogFormat("{0}", distanceGo);

        //�׽�Ʈ
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //�������Ӹ��� �ڵ����� ����� �Ÿ��� ����ؼ� UI�� ����ؾ� ��
        float distanceX = this.flagGo.transform.position.x - this.carGo.transform.position.x;


        Text text = distanceGo.GetComponent<Text>();
        if (state == true)
        {
            text.text = string.Format("��ǥ ���������� �Ÿ� {0}", distanceX);
            if (distanceX < 0)
            {
                this.state = false;
                CarSwipe carSwipe = this.carGo.GetComponent<CarSwipe>();
                carSwipe.PlayLoseSound();
            }
        }
        else
        {
            text.text = string.Format("���� �����Ǿ����ϴ�.");
            this.carGo.GetComponent<CarSwipe>();
        }
    }
}
