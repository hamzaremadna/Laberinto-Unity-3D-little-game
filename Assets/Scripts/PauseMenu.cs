using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
public GameObject PauseMenuUI;
public GameObject Game;
public GameObject GameOver;
public GameObject Play;
public GameObject Winpanel;


    public void Pause()
    {

        PauseMenuUI.SetActive(true);
        Game.SetActive(false);
        	Time.timeScale = 0;

    }

      public void Over()
    {

        GameOver.SetActive(true);
                Game.SetActive(false);
                        	Time.timeScale = 0;


    }
          public void Win()
    {

        Winpanel.SetActive(true);
                Game.SetActive(false);
                        	Time.timeScale = 0;


    }
     public void Playvoid()
    {

        Game.SetActive(true);
                Play.SetActive(false);
                        	Time.timeScale = 1;


    }
    public void Continue(){
              GameOver.SetActive(false);
                Game.SetActive(true);
                	Time.timeScale = 1;
    }
      public void Resume()
    {
        PauseMenuUI.SetActive(false);
                Game.SetActive(true);
                	Time.timeScale = 1;
    }
   public void Exit()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("MainMenu");
    }

   public void chapter2()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("Stage2");
    }
    public void chapter3()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("Stage3");
    }
        public void chapter4()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("Stage4");
    }
            public void chapter5()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("Stage5");
    }
  public void Again()
    {    
                	Time.timeScale = 1;
      SceneManager.LoadScene("Stage1");
    }
      public void Again2()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage2");
    }
          public void Again3()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage3");
    }
          public void Again4()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage4");
    }
              public void Again5()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage5");
    }
}
