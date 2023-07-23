using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject UI, L1, L2, L21, L211, L2111E, L2112, L21121E, L212E, L22, L222E, L221, L2211E, TitleScreen;
    public int health, stamina;
    public TextMeshProUGUI healthText, staminaText;

    // Start is called before the first frame update
    void Start()
    {
        //if you happen to read this, im sorry. i wish i was more motivated.
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        staminaText.text = stamina.ToString();
    }

    public void StartGameBtn()
    {
        TitleScreen.SetActive(false);
        UI.SetActive(true);
        L1.SetActive(true);
    }

    public void btnL2()
    {
        L1.SetActive(false);
        L2.SetActive(true);
        --stamina;
    }

    public void btnL21()
    {
        L2.SetActive(false);
        L21.SetActive(true);
        stamina -= 2;
    }

    public void btnL211()
    {
        L21.SetActive(false);
        L211.SetActive(true);
        --stamina;
    }

    public void btnL2111e()
    {
        L211.SetActive(false);
        L2111E.SetActive(true);
        UI.SetActive(false);
    }

    public void btnL2112()
    {
        L211.SetActive(false);
        L2112.SetActive(true);
        --stamina;
    }

    public void btnL21121e()
    {
        L2112.SetActive(false);
        L21121E.SetActive(true);
        UI.SetActive(false);
    }

    public void btnL212e()
    {
        L21.SetActive(false);
        L212E.SetActive(true);
        UI.SetActive(false);
    }

    public void btnL22()
    {
        L2.SetActive(false);
        L22.SetActive(true);
        --stamina;
        health -= 3;
    }

    public void btnL222e()
    {
        L22.SetActive(false);
        L222E.SetActive(true);
        UI.SetActive(false);
    }

    public void btnL221()
    {
        L22.SetActive(false);
        L221.SetActive(true);
        ++health;
    }

    public void btnL2211e()
    {
        L221.SetActive(false);
        L2211E.SetActive(true);
        UI.SetActive(false);
    }

}
