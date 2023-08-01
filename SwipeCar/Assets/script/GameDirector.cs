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
        //자동차
        this.carGo = GameObject.Find("car");
        //깃발
        this.flagGo = GameObject.Find("flag");
        this.distanceGo = GameObject.Find("Distance");

        Debug.LogFormat("{0}", carGo);
        Debug.LogFormat("{0}", flagGo);
        Debug.LogFormat("{0}", distanceGo);

        //테스트
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //매프레임마다 자동차와 깃발의 거리를 계산해서 UI에 출력해야 함
        float distanceX = this.flagGo.transform.position.x - this.carGo.transform.position.x;


        Text text = distanceGo.GetComponent<Text>();
        if (state == true)
        {
            text.text = string.Format("목표 지점까지의 거리 {0}", distanceX);
            if (distanceX < 0)
            {
                this.state = false;
                CarSwipe carSwipe = this.carGo.GetComponent<CarSwipe>();
                carSwipe.PlayLoseSound();
            }
        }
        else
        {
            text.text = string.Format("게임 오버되었습니다.");
            this.carGo.GetComponent<CarSwipe>();
        }
    }
}
