using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light StairLight;
    public AudioSource source;
    public AudioClip clip;
    
    void Start()
    {
        
    }
    //is Trigger 했을 때 통과 하면서 충돌 감지
    // 하는 함수 콜백 함수라고 함 스스로 호출 하기때문
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            StairLight.enabled = true;
            //충돌체의 태그검사를 한후 맞으면 라이트 온
            source.PlayOneShot(clip,1.0f);
        }
    }
    // 콜라이더 범위에 들어왔다가 빠져 나갔을 때 
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            StairLight.enabled = false;
            source.PlayOneShot(clip ,1.0f);
        }

    }
    void Update()
    {
        
    }
}
