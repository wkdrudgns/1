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
    public GameObject Setting;//얘만 옵션 배경
    public GameObject Bgm;
    public GameObject Bgs;//여기까지 버튼
    void Start()
    {
        Setting.SetActive(false);//옵션 
    }
    void Update()
    {
   
    }
    public void Quits()//게임 끄기
    {
        Application.Quit();
    }
    public void GStart()//게임 시작
    {
        SceneManager.LoadScene("character");
    }
    public void Options()//옵션
    {
        Setting.SetActive(true);
        Bgm.SetActive(true);
        Bgs.SetActive(true);
        Return.SetActive(true);
    }
    public void returns()//게임으로 돌아가기
    {
        Setting.SetActive(false);
        Bgm.SetActive(false);
        Bgs.SetActive(false);
        Return.SetActive(false);
    }
    public void BGS()//옵션 에서 배경음악 끄기 또는 키는거 쓸예정
    {
    
    }
    public void BGM()//옵션 에서 효과음 끄기 또는 키는거 쓸예정
    {
       
    }
   
}
