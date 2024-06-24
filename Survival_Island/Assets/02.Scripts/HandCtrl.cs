using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCtrl : MonoBehaviour
{
    public Animation ComBatSGAni;
    public Light flashLight;
    public AudioClip flashSound; //소리파일
    public AudioSource A_source; // 오디오 소스 
    void Start() // 게임시작전 호출되는 공간 
    {
        
    }
    void Update() //게임 시작후 계속 호출 되는 공간
    {
        GunCtrl();
        FlashLightOnOff();

    }

    private void FlashLightOnOff()
    {
        // 키보드에서 F키를 눌렀다면 
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
            A_source.PlayOneShot(flashSound, 1.0f);
            //소리파일 ,  소리볼륨
        }
    }

    private void GunCtrl()
    {
        //왼쪽 쉬프트키와 W키를 동시에 눌렀다면 
        if (Input.GetKey(KeyCode.LeftShift) &&
            Input.GetKey(KeyCode.W))
            ComBatSGAni.Play("running"); //애니메이션 실행
                                         //왼쪽 쉬프트 키를 띄었다면 
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            ComBatSGAni.Play("runStop");
        //GetKey() :누르는 동안
        //GetKeyDown() : 눌럿다면 총알 발사시 
        //GetKeyUp() :누른 후 띄었다면 
    }
}
