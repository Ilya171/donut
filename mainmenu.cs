using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{
    public Transform spawnPos;

    [SerializeField] GameObject spawn;

    [SerializeField] float money;
    public Text moneyText;
    [SerializeField] float Goldmoney = 0f;
    public Text GoldmoneyText;

    public float TotalMoney = 0f;
    public Text TotalMoneyText;
    public float TotalClickButton = 0f;
    public Text TotalClickButtonText;
    public float TotalAchievEnd = 0f;

    private float priceFirst = 20f;         // цены магазина
    public Text priceFirstText;
    private float priceSecond = 150f;
    public Text priceSecondText;
    public float priceThird = 700f;
    public Text priceTrirdText;
    public float priceFourth = 5000f;
    public Text priceFourthText;
    public float priceFifth = 25000f;
    public Text priceFifthText;
    public float price6 = 90000f;
    public Text price6Text;
    public float price7 = 400000f;
    public Text price7Text;
    public float price8 = 3000000f;
    public Text price8Text;
    public float price9 = 150000000f;
    public Text price9Text;
    public float price10 = 5000000000f;
    public Text price10Text;


    private float numFirst = 0f;     // количество купленных предметов в магазине
    public Text numFirstText;
    private int numSecond = 0;
    public Text numSecondText;
    private int numThird = 0;
    public Text numThirdText;
    private int numFourth = 0;
    public Text numFourthText;
    private int numFifth = 0;
    public Text numFifthText;
    private int num6 = 0;
    public Text num6Text;
    private int num7 = 0;
    public Text num7Text;
    private int num8 = 0;
    public Text num8Text;
    private int num9 = 0;
    public Text num9Text;
    private int num10 = 0;
    public Text num10Text;

    public Text numP0;          // прогресс в достижениях
    public Text numP1;
    public Text numP2;
    public Text numP3;
    public Text numP4;
    public Text numP5;
    public Text numP6;
    public Text numP7;




    private float timeMoney = 0f;
    public Text timeMoneyText;
    private int MoneyUp = 1;

    private bool CheckShop = true;
    private bool CheckUpgrate = true;
    private bool CheckAchiev = true;
    private bool CheckSkins = true;


    public GameObject shoppanel;
    public GameObject Upgratepanel;
    public GameObject Achievpanel;
    public GameObject znakShop;
    public GameObject znakAchiev;
    public GameObject statistPanel;

    public GameObject buttonShop;
    public GameObject buttonUpgrade;
    public GameObject buttonAchiev;
    public GameObject bottonSkins;
    public GameObject buttonStatist;
    public GameObject buttonProg;

    public GameObject ButtonofDonut;
    public GameObject TextOFMoney;
    public GameObject textTimeMoney;

    public GameObject BuyMegaClick;
    public GameObject BuyTurbo;

    public GameObject button1;       //кнопки покупки в магазине
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;


    public Color colorBlue = new Color(0, 0, 1, 1);
    public Color colorYellow = new Color(1, 0.92f, 0.016f, 1);

    public GameObject ProgPanel0;
    public GameObject ProgPanel1;
    public GameObject ProgPanel2;
    public GameObject ProgPanel3;
    public GameObject ProgPanel4;
    public GameObject ProgPanel5;
    public GameObject ProgPanel6;
    public GameObject ProgPanel7;


    public Image progr0; //шкала прогресса
    public Image progr1;
    public Image progr2;
    public Image progr3;
    public Image progr4;
    public Image progr5;
    public Image progr6;
    public Image progr7;

    public GameObject load1; // загрузка способностей
    public GameObject load2;

    public int priceofClickUpgrate = 0;
    public int priceofMEgaClickUpgrate = 100;
    public int priceofTurboUpgrate = 100;
    public int priceofDonutPAdUpgrate = 100;
    public int priceofDontSpeepUpgrate = 100;

    public float priceOfYourMastery = 1000f;
    public Text priceOfYourMasteryText;
    public Text numMasteryText;
    public int numMastery = 0;


    public float prodOf1st = 0.3f, prodOf2st = 3f, prodOf3st = 8f, prodOf4th = 18f, prodOf5th = 60f,
                 prodOf6th = 150f, prodOf7th = 500f, prodOf8th = 2000f, prodOf9th = 5000f, prodOf10th = 10000f;
    // производство пончиков в сек










    public bool OnClickHold = false;

    private int prize1 = 5;




    private void Start()
    {
        //  money = PlayerPrefs.GetInt("money");
        StartCoroutine(timeFarm());

    }
    public void buttonClick()
    {
        money += MoneyUp;
        TotalMoney += MoneyUp;
        Vector2 pos = spawnPos.position + new Vector3(Random.Range(-2.7f, 3), 0);
        Instantiate(spawn, pos, Quaternion.identity);
        TotalClickButton++;

    }




    public void OnClickShop()
    {
        if (CheckShop == true)
        {
            TextOFMoney.SetActive(false);
            textTimeMoney.SetActive(false);
            ButtonofDonut.SetActive(false);
            shoppanel.SetActive(true);
            CheckShop = false;
            buttonShop.SetActive(false);
            buttonUpgrade.SetActive(false);
            znakShop.SetActive(false);
            buttonAchiev.SetActive(false);
            bottonSkins.SetActive(false);
        }

    }
    public void OnClickUpgrate()
    {
        if (CheckUpgrate == true)
        {
            TextOFMoney.SetActive(false);
            textTimeMoney.SetActive(false);
            ButtonofDonut.SetActive(false);
            Upgratepanel.SetActive(true);
            CheckUpgrate = false;
            buttonShop.SetActive(false);
            buttonUpgrade.SetActive(false);
            buttonAchiev.SetActive(false);
            bottonSkins.SetActive(false);
        }

    }
    public void OnClickAchiev()
    {
        if (CheckAchiev == true)
        {
            if (m == true)
            {
                k++;
            }

            TextOFMoney.SetActive(false);
            textTimeMoney.SetActive(false);
            ButtonofDonut.SetActive(false);
            Achievpanel.SetActive(true);
            CheckAchiev = false;
            buttonShop.SetActive(false);
            buttonUpgrade.SetActive(false);
            buttonAchiev.SetActive(false);
            bottonSkins.SetActive(false);

            znakAchiev.SetActive(false);
        }

    }
    public void OnClickClose()
    {
        TextOFMoney.SetActive(true);
        textTimeMoney.SetActive(true);
        ButtonofDonut.SetActive(true);

        CheckUpgrate = true;
        CheckShop = true;
        CheckAchiev = true;
        CheckSkins = true;

        Upgratepanel.SetActive(false);
        shoppanel.SetActive(false);
        Achievpanel.SetActive(false);
        statistPanel.SetActive(false);


        buttonShop.SetActive(true);
        buttonUpgrade.SetActive(true);
        buttonAchiev.SetActive(true);
        bottonSkins.SetActive(true);

        znakShop.SetActive(false);

          m = false;



    }

    public void OnClickStatist()
    {
        statistPanel.SetActive(true);
    }
    public void OnClickProgress()
    {
        statistPanel.SetActive(false);
    }


    public void Color()           //znakShop here


    {
        if (money >= priceFirst)
        {
            button1.GetComponent<Image>().color = colorYellow;
            if (numFirst == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }

        }
        else
        {
            button1.GetComponent<Image>().color = colorBlue;
        }
        if (money >= priceSecond)
        {
            button2.GetComponent<Image>().color = colorYellow;
            if (numSecond == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button2.GetComponent<Image>().color = colorBlue;
        }
        if (money >= priceThird)
        {
            button3.GetComponent<Image>().color = colorYellow;
            if (numThird == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button3.GetComponent<Image>().color = colorBlue;
        }
        if (money >= priceFourth)
        {
            button4.GetComponent<Image>().color = colorYellow;
            if (numFourth == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button4.GetComponent<Image>().color = colorBlue;
        }
        if (money >= priceFifth)
        {
            button5.GetComponent<Image>().color = colorYellow;
            if (numFifth == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button5.GetComponent<Image>().color = colorBlue;
        }
        if (money >= price6)
        {
            button6.GetComponent<Image>().color = colorYellow;
            if (num6 == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button6.GetComponent<Image>().color = colorBlue;
        }
        if (money >= price7)
        {
            button7.GetComponent<Image>().color = colorYellow;
            if (num7 == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button7.GetComponent<Image>().color = colorBlue;
        }
        if (money >= price8)
        {
            button8.GetComponent<Image>().color = colorYellow;
            if (num8 == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button8.GetComponent<Image>().color = colorBlue;
        }
        if (money >= price9)
        {
            button9.GetComponent<Image>().color = colorYellow;
            if (num9 == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button9.GetComponent<Image>().color = colorBlue;
        }
        if (money >= price10)
        {
            button10.GetComponent<Image>().color = colorYellow;
            if (num10 == 0 && CheckShop == true)
            {
                znakShop.SetActive(true);

            }
        }
        else
        {
            button10.GetComponent<Image>().color = colorBlue;
        }

    }






    public int k = 0;                   // К и М две переменные помогаю с работой znakAchiev
    int km = 0;
    public bool m = false;
    public bool progress()
    {
        if (numFirst <= 1.1f)
        {
            progr0.fillAmount = numFirst;
            if (numFirst == 1 && CheckAchiev == true && k == 0&&km==0)
            {
                km++;
                m = true;
                return true;
            }
        }
        if ((numFirst / 20) <= 1.1f)
        {
            progr1.fillAmount = numFirst / 20;
            if (numFirst == 20 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;

            }
        }
        if ((numFirst / 50) <= 1.1f)
        {
            progr2.fillAmount = numFirst / 50;
            if (numFirst == 50 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;
            }
        }
        if ((numFirst / 100) <= 1.1f)
        {
            progr3.fillAmount = (numFirst / 100);
            if (numFirst == 100 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;

            }
        }
        if ((TotalMoney / 10000) <= 1.1f)
        {
            progr4.fillAmount = (TotalMoney / 10000);
            if (TotalMoney == 10000 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;
            }
        }
        if ((TotalAchievEnd / 10) <= 1.1f)
        {
            progr5.fillAmount = (TotalAchievEnd / 10);
            if (TotalAchievEnd == 10 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;
            }
        }
        if ((TotalClickButton / 1000) <= 1.1f)
        {
            progr6.fillAmount = (TotalClickButton / 1000);
            if (TotalClickButton == 1000 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;
            }
        }
        if ((Goldmoney / 50) <= 1.1f)
        {
            progr7.fillAmount = (Goldmoney / 50);
            if (Goldmoney == 50 && CheckAchiev == true && k == 0)
            {
                m = true;
                return true;
            }
        }
        return false;
    }          // znakAchiev here


    int prog0 = 1;
  
    public void OnClickProg0()
    {
        if (numFirst >= prog0)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            prog0 += 10;

        }
    }     // достижения
    public void OnClickProg1()
    {
        if (numFirst >= 20)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel1);

        }
    }
    public void OnClickProg2()
    {
        if (numFirst >= 50)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel2);

        }
    }
    public void OnClickProg3()
    {
        if (numFirst >= 100)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel3);

        }
    }
    public void OnClickProg4()
    {
        if (TotalMoney >= 10000)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel4);

        }
    }
    public void OnClickProg5()
    {
        if (TotalAchievEnd >= 10)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel5);

        }
    }
    public void OnClickProg6()
    {
        if (TotalClickButton >= 1000)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel6);

        }
    }
    public void OnClickProg7()
    {
        if (Goldmoney >= 50)
        {
            Goldmoney += prize1;
            TotalAchievEnd++;
            k = 0;
            m = false;
            Destroy(ProgPanel7);

        }
    }
   
    /////////////////////////////
   
    public void OnClickBuyFirst()
    {
        if (money >= priceFirst)
        {
            
            timeMoney +=prodOf1st;
            money -= priceFirst;
            numFirst++;
            priceFirst = (priceFirst * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);
                       

        }
    }      // магазин
    public void OnClickBuySecond()
    {
        if (money >= priceSecond)
        {
            timeMoney += prodOf2st;
            money -= priceSecond;
            numSecond++;
            priceSecond = (priceSecond*1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuyThird()
    {
        if (money >= priceThird)
        {
            timeMoney += prodOf3st;
            money -= priceThird;
            numThird++;
            priceThird = (priceThird*1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuyFourth()
    {
        if (money >= priceFourth)
        {
            timeMoney += prodOf4th;
            money -= priceFourth;
            numFourth++;
            priceFourth = (priceFourth*1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuyFifth()
    {
        if (money >= priceFifth)
        {
            timeMoney += prodOf5th;
            money -= priceFifth;
            numFifth++;
            priceFifth = (priceFifth * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuy6()
    {
        if (money >= price6)
        {
            timeMoney += prodOf6th;
            money -= price6;
            num6++;
            price6 = (price6 * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuy7()
    {
        if (money >= price7)
        {
            timeMoney += prodOf7th;
            money -= price7;
            num7++;
            price7 = (price7 * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuy8()
    {
        if (money >= price8)
        {
            timeMoney += prodOf8th;
            money -= price8;
            num8++;
            price8 =( price8 * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuy9()
    {
        if (money >= price9)
        {
            timeMoney += prodOf9th;
            money -= price9;
            num9++;
            price9 =( price9 * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }
    public void OnClickBuy10()
    {
        if (money >= price10)
        {
            timeMoney += prodOf10th;
            money -= price10;
            num10++;
            price10 = (price10 * 1.2f+1);
            // PlayerPrefs.SetFloat("money", money);

        }
    }

    ////////////////////////
    public bool isMegaClick = false;
    bool isTurbo = false;
    bool wasTurbo = false; 
    int TurboCan = 0;

    

  public void OnClickYourMastery()
    {
        if(money>=priceOfYourMastery)
        {
            money -= priceOfYourMastery;
            MoneyUp++;
            priceOfYourMastery *=1.2f ;
            numMastery++;
        }
    }
    public void OnClickUpgrateMegaClick()
    {
        if (isMegaClick == false)
        {


            if (Goldmoney >= priceofMEgaClickUpgrate)
            {
                Goldmoney -= priceofMEgaClickUpgrate;
                OnClickHold = true;
                isMegaClick = true;
                BuyMegaClick.SetActive(false);
                load1.SetActive(true);
                StartCoroutine(timeMegaClick());
            }
        }
    }
   
    public void OnClickUpgrateTurbo()
    {
        if (isTurbo == false)
        {
            if (Goldmoney >= priceofTurboUpgrate)
            {         
               isTurbo = true;
                wasTurbo = true;
               Goldmoney -= priceofTurboUpgrate;
                timeMoney *= 5;
                prodOf1st *= 5;
                prodOf2st *= 5;
                prodOf3st *= 5;
                prodOf4th *= 5;
                prodOf5th *= 5;
                prodOf6th *= 5;
                prodOf7th *= 5;
                prodOf8th *= 5;
                prodOf9th *= 5;
                prodOf10th *= 5;
                TurboCan = 1;
                BuyTurbo.SetActive(false);
                load2.SetActive(true);
                StartCoroutine(timeTurbo());
                
            }
        }
    }    // 740 and 766 строчки о работе с ТУРБО
    public void TurboStop()
    {
       
        
            timeMoney /= 5;
            prodOf1st /= 5;
            prodOf2st /= 5;
            prodOf3st /= 5;
            prodOf4th /= 5;
            prodOf5th /= 5;
            prodOf6th /= 5;
            prodOf7th /= 5;
            prodOf8th /= 5;
            prodOf9th /= 5;
            prodOf10th /= 5;
            TurboCan++;
        wasTurbo = false;
        
    }

    public void OnClickUpgrateDonutPad()  
    {
        if (Goldmoney >= priceofTurboUpgrate)
        {
            Goldmoney -= priceofTurboUpgrate;
            if(timeMoney==0)
            {
                money += 400f;
            }
            else
            {      
                if(isTurbo)
                {
                    money += timeMoney * 80;
                }
                else
                money += timeMoney * 400; // производство пончиков x400
            }
           
        }
    }






    public float dist1y = 293f;
    public float dist2y = 125f;
    public float dist1x = 343f;
    public float dist2x = 340f;

    
    IEnumerator timeFarm()
    {
        yield return new WaitForSeconds(1);
        money += timeMoney;
        TotalMoney += (int)timeMoney;

       
        StartCoroutine(timeFarm());
    }
    IEnumerator timeMegaClick()
    {
        yield return new WaitForSeconds(7200);
       
        isMegaClick = false;
        OnClickHold = false;
        BuyMegaClick.SetActive(true);
        load1.SetActive(false);
        if (isMegaClick==false)
        {
            StopCoroutine(timeMegaClick());
        }

       
    }
    IEnumerator timeTurbo()
    {
        yield return new WaitForSeconds(7200);

        isTurbo = false;
        TurboCan = 0;
        BuyTurbo.SetActive(true);
        load2.SetActive(false);
       if (isTurbo == false)
        {
            StopCoroutine(timeTurbo());
        }


    }

    void Update()
    {

        {
            moneyText.text = money.ToString("0");
            GoldmoneyText.text = Goldmoney.ToString("0");
            TotalMoneyText.text = "Произведено пончиков: " + TotalMoney.ToString("0");
            TotalClickButtonText.text = "Сделано кликов: "+ TotalClickButton.ToString();

            priceFirstText.text = priceFirst.ToString("0");
            priceSecondText.text = priceSecond.ToString("0");
            priceTrirdText.text = priceThird.ToString("0");
            priceFourthText.text = priceFourth.ToString("0");
            priceFifthText.text = priceFifth.ToString("0");
            price6Text.text = price6.ToString("0");
            price7Text.text = price7.ToString("0");
            price8Text.text = price8.ToString("0");
            price9Text.text = price9.ToString("0");
            price10Text.text = price10.ToString("0");
            priceOfYourMasteryText.text = priceOfYourMastery.ToString("0");

            numFirstText.text = "LV."+numFirst.ToString();
            numSecondText.text = "LV."+numSecond.ToString();
            numThirdText.text = "LV." + numThird.ToString();
            numFourthText.text = "LV." + numFourth.ToString();
            numFifthText.text = "LV." + numFifth.ToString();
            num6Text.text = "LV." + num6.ToString();
            num7Text.text = "LV." + num7.ToString();
            num8Text.text = "LV." + num8.ToString();
            num9Text.text = "LV." + num9.ToString();
            num10Text.text = "LV." + num10.ToString();
            numMasteryText.text = "LV." + numMastery.ToString();


            {


                if (numFirst <= 1)
                {
                    numP0.text = numFirst.ToString() + "/1";
                }
                else
                {
                    numP0.text =  "1/1";
                }
                if (numFirst <= 20)
                {
                    numP1.text = numFirst.ToString() + "/20";
                }
                else
                {
                    numP1.text =  "20/20";
                }
                if (numFirst <= 50)
                {
                    numP2.text = numFirst.ToString() + "/50";
                }
                else
                {
                    numP2.text = "50/50";
                }
                if (numFirst <= 100)
                {
                    numP3.text = numFirst.ToString() + "/100";
                }
                else
                {
                    numP3.text = "100/100";
                }
                if (TotalMoney <= 10000)
                {
                    numP4.text = TotalMoney.ToString() + "/10000";
                }
                else
                {
                    numP4.text = "10000/10000";
                }
                if (TotalAchievEnd <= 10)
                {
                    numP5.text = TotalAchievEnd.ToString() + "/10";
                }
                else
                {
                    numP5.text = "10/10";
                }
                if (TotalClickButton <= 1000)
                {
                    numP6.text = TotalClickButton.ToString() + "/1000";
                }
                else
                {
                    numP6.text = "1000/1000";
                }
                if (Goldmoney <= 50)
                {
                    numP7.text = Goldmoney.ToString() + "/50";
                }
                else
                {
                    numP7.text = "50/50";
                }
            } // цифры в прогрессе достижения



            timeMoneyText.text = timeMoney.ToString("0.0" + " пон/сек");
        }
        Color();

        if(progress())
        {
            znakAchiev.SetActive(true);
        }
        int yPosition = (int)Input.mousePosition.y;
        int xPosition = (int)Input.mousePosition.x;
        if (Input.GetMouseButton(0) && OnClickHold && yPosition > (Screen.height / 2 - dist1y) && yPosition < (Screen.height / 2 + dist2y) && xPosition > (Screen.width / 2 - dist1x) && xPosition < (Screen.width / 2 + dist2x)) //способность мега клик
        {
            money +=(float) MoneyUp/70;
            TotalMoney += MoneyUp;
        }
       
        if (isTurbo==false && TurboCan==0 &&wasTurbo)
        { 
            TurboStop();
        }
    }
}
