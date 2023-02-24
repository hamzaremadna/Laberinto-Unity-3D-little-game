using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class PlayerController : MonoBehaviour {

    public TextMeshProUGUI coin;
    public TextMeshProUGUI trophe;
    public TextMeshProUGUI diamond;
	public PauseMenu over;
	private Rigidbody rb;
    public static int cntcoin;
        public static int cntrophe;
    public static int cntdiamond;
    			public AudioSource coinsound;
    			public AudioSource trophysound;
    			public AudioSource diamondsound;
                    Gyroscope m_Gyro;


	void Start() 
	{
        Time.timeScale = 0;
        		rb = GetComponent<Rigidbody>();
                         if(SystemInfo.deviceType != DeviceType.Desktop)
         {
            m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
         }              
                
  
	}


    void FixedUpdate()
    {
         if(SystemInfo.deviceType == DeviceType.Desktop)
         {
        float posH = Input.GetAxis("Horizontal");
        float posV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(posH, 0.0f, posV);

        rb.AddForce(movimiento * 10);}else{

           float posH = m_Gyro.rotationRate.y;
        float posV = -m_Gyro.rotationRate.x;

                     
             Vector3 movimiento = new Vector3 (posH, 0.0f, posV);
                     
             rb.AddForce(movimiento * 10);
        }

    }

    
    void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("coin"))
            {
                other.gameObject.SetActive(false);
                coinsound.Play();
                cntcoin = cntcoin + 1;
                coin.text = cntcoin.ToString();
            }
               if (other.gameObject.CompareTag("trophe"))
            {
                other.gameObject.SetActive(false);
                                trophysound.Play();
                cntrophe = cntrophe + 1;
                trophe.text = cntrophe.ToString();
            }  
             if (other.gameObject.CompareTag("diamond"))
            {
                other.gameObject.SetActive(false);
                                diamondsound.Play();

                cntdiamond = cntdiamond + 1;
                diamond.text = cntdiamond.ToString();
            }
           if (other.gameObject.CompareTag("Finish"))
            {
               over.Win();
            }

    }



    private void OnTriggerExit(Collider other)
    {
		if (other.gameObject.CompareTag("tablero"))
		{
					over.Over();
		}
	}

	void QuitGame()
	{
		#if UNITY_EDITOR
		    UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_WEBPLAYER
		    Application.OpenURL(webplayerQuitURL);
		#else
		    Application.Quit();
		#endif
	}

}