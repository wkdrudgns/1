using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public GameObject GameStart;
    public GameObject Quit;
    public GameObject Option;
    public GameObject Return;
    public GameObject Setting;//�길 �ɼ� ���
    public GameObject Bgm;
    public GameObject Bgs;//������� ��ư
    void Start()
    {
        Setting.SetActive(false);//�ɼ� 
    }
    void Update()
    {
   
    }
    public void Quits()//���� ����
    {
        Application.Quit();
    }
    public void GStart()//���� ����
    {
        SceneManager.LoadScene("character");
    }
    public void Options()//�ɼ�
    {
        Setting.SetActive(true);
        Bgm.SetActive(true);
        Bgs.SetActive(true);
        Return.SetActive(true);
    }
    public void returns()//�������� ���ư���
    {
        Setting.SetActive(false);
        Bgm.SetActive(false);
        Bgs.SetActive(false);
        Return.SetActive(false);
    }
    public void BGS()//�ɼ� ���� ������� ���� �Ǵ� Ű�°� ������
    {
    
    }
    public void BGM()//�ɼ� ���� ȿ���� ���� �Ǵ� Ű�°� ������
    {
       
    }
   
}
