using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCtrl : MonoBehaviour
{
    public Animation ComBatSGAni;
    public Light flashLight;
    public AudioClip flashSound; //�Ҹ�����
    public AudioSource A_source; // ����� �ҽ� 
    void Start() // ���ӽ����� ȣ��Ǵ� ���� 
    {
        
    }
    void Update() //���� ������ ��� ȣ�� �Ǵ� ����
    {
        GunCtrl();
        FlashLightOnOff();

    }

    private void FlashLightOnOff()
    {
        // Ű���忡�� FŰ�� �����ٸ� 
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
            A_source.PlayOneShot(flashSound, 1.0f);
            //�Ҹ����� ,  �Ҹ�����
        }
    }

    private void GunCtrl()
    {
        //���� ����ƮŰ�� WŰ�� ���ÿ� �����ٸ� 
        if (Input.GetKey(KeyCode.LeftShift) &&
            Input.GetKey(KeyCode.W))
            ComBatSGAni.Play("running"); //�ִϸ��̼� ����
                                         //���� ����Ʈ Ű�� ����ٸ� 
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            ComBatSGAni.Play("runStop");
        //GetKey() :������ ����
        //GetKeyDown() : �����ٸ� �Ѿ� �߻�� 
        //GetKeyUp() :���� �� ����ٸ� 
    }
}
