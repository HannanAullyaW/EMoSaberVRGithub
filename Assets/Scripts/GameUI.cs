using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainMenuPanel;
    public GameObject PengaturanPanel;
    public GameObject KeluarPanel;


    // Use this for initialization
    void Start()
    {
        MainMenuPanel.SetActive(true);
        PengaturanPanel.SetActive(false);
        KeluarPanel.SetActive(false);

    }

    public void StartGameClick()
    {
        Application.LoadLevel(1);

    }

    //public void LoadScene(string scenename){
    //SceneManager.LoadScene(scenename);
    //}
    public void PengaturanClicked()
    {
        PengaturanPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        KeluarPanel.SetActive(false);
    }

    public void KeluarClicked()
    {
        KeluarPanel.SetActive(true);
        PengaturanPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
    }

    public void NoClicked()
    {
        MainMenuPanel.SetActive(true);
        PengaturanPanel.SetActive(false);
        KeluarPanel.SetActive(false);
    }

    public void YesGameClick()
    {
        Application.Quit();
    }


    public void BackClicked()
    {
        MainMenuPanel.SetActive(true);
        PengaturanPanel.SetActive(false);
        KeluarPanel.SetActive(false);

    }

}
