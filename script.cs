using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class script : MonoBehaviour
{ public UnityEngine.UI.Text text1, text2, sonuc,timer;
    int sayi1, sayi2, sayi3, sayi4, islem1, islem2, islemSonucu1, islemSonucu2, tekSayi1, tekSayi2, score = 0;
    public float timeLeft = 30.0f;
    

    public void islemler()
    {
        sayi1 = Random.Range(1, 20);
        sayi2 = Random.Range(1, 20);
        sayi3 = Random.Range(1, 20);
        sayi4 = Random.Range(1, 20);
        tekSayi1 = Random.Range(1, 20);
        tekSayi2 = Random.Range(1, 20);
        islem1 = Random.Range(1, 6);
        islem2 = Random.Range(1, 6);

        switch (islem1)
        {
            case 1:
                text1.text = sayi1 + "+" + sayi2;
                islemSonucu1 = sayi1 + sayi2;
                break;
            case 2:
                text1.text = sayi1 + "-" + sayi2;
                islemSonucu1 = sayi1 - sayi2;
                break;
            case 3:
                text1.text = sayi1 + "*" + sayi2;
                islemSonucu1 = sayi1 * sayi2;
                break;
            case 4:
                text1.text = sayi1 + "/" + sayi2;
                islemSonucu1 = sayi1 / sayi2;
                break;
            case 5:
                text1.text = tekSayi1 + "";
                islemSonucu1 = tekSayi1;
                break;
        }

        switch (islem2)
        {
            case 1:
                text2.text = sayi3 + "+" + sayi4;
                islemSonucu2 = sayi3 + sayi4;
                break;
            case 2:
                text2.text = sayi3 + "-" + sayi4;
                islemSonucu2 = sayi3 - sayi4;
                break;
            case 3:
                text2.text = sayi3 + "*" + sayi4;
                islemSonucu2 = sayi3 * sayi4;
                break;
            case 4:
                text2.text = sayi3 + "/" + sayi4;
                islemSonucu2 = sayi3 / sayi4;
                break;
            case 5:
                text2.text = tekSayi2 + "";
                islemSonucu2 = tekSayi2;
                break;
        }

    }

    public void kontrol1()
    {
        if (islemSonucu1 > islemSonucu2)
        {
            Debug.Log(islemSonucu1);
            Debug.Log(islemSonucu2);
            score += 1;
            sonuc.text = "Score:" + score;
        }
        else if (islemSonucu1 < islemSonucu2)
        {
            Debug.Log(islemSonucu1);
            Debug.Log(islemSonucu2);
            score -= 1;
            sonuc.text = "Score:" + score;
        }


    }
    public void kontrol2()
    {
        if (islemSonucu1 > islemSonucu2)
        {
            score -= 1;
            sonuc.text = "Score:" + score;
        }
        else if (islemSonucu1 < islemSonucu2)
        {
            score += 1;
            sonuc.text = "Score:" + score;
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        islemler();
        StartCoroutine("Reset");


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            islemler();
        }
        
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            updateTimer(timeLeft);
        }


    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    IEnumerator Reset()
    {
        //Put your code before waiting here

        yield return new WaitForSeconds(1);

        //Put code after waiting here
        if (Input.GetMouseButtonDown(0))
        {
            islemler();
        }

        //You can put more yield return new WaitForSeconds(1); in one coroutine

        StartCoroutine("Reset");
    }


}
