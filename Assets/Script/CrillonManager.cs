using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrillonManager : MonoBehaviour {

    public GameObject MenuButton;
    public GameObject ButtonList;
    public GameObject Info;
    public GameObject Album;
    public GameObject Location;
    public GameObject StartWord;
    public GameObject LastWord;
    public GameObject BusMainButton;
    public GameObject BusSubButton;

    public Image AlbumImage;
    public Image LocaImage;

    public Sprite[] mySprite;
    public Sprite[] LocaSprite;

    int AlbumNum = 0;

    // Use this for initialization
    void Start () {
        ButtonList.SetActive(false);
        Info.SetActive(false);
        Album.SetActive(false);
        Location.SetActive(false);
        BusSubButton.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MenuButtonClick()
    {
        MenuButton.SetActive(false);
        ButtonList.SetActive(true);
    }

    public void InfoClick()
    {
        Info.SetActive(true);
        Album.SetActive(false);
        Location.SetActive(false);
    }

    public void AlbumClick()
    {
        Info.SetActive(false);
        Album.SetActive(true);
        Location.SetActive(false);
        StartWord.SetActive(false);
        LastWord.SetActive(false);
        AlbumImage.sprite = mySprite[AlbumNum];
    }

    public void NextClick()
    {
        AlbumNum++;
        if(AlbumNum >= mySprite.Length)
        {
            LastWord.SetActive(true);
            AlbumNum = 2;
        }

        if (AlbumNum < mySprite.Length)
        { 
            Debug.Log(AlbumNum);
            AlbumImage.sprite = mySprite[AlbumNum];
        }
    }

    public void PrevClick()
    {
        AlbumNum--;
        if (AlbumNum < 0)
        {
            StartWord.SetActive(true);
            AlbumNum = 0;
        }

        if (AlbumNum >= 0)
        {
            Debug.Log(AlbumNum);
            AlbumImage.sprite = mySprite[AlbumNum];
        }
    }

    public void WarningClick()
    {
        StartWord.SetActive(false);
        LastWord.SetActive(false);
    }

    public void LocationClick()
    {
        Location.SetActive(true);
        Info.SetActive(false);
        Album.SetActive(false);
        BusMainButton.SetActive(true);
        BusSubButton.SetActive(false);
        LocaImage.sprite = LocaSprite[0];
    }

    public void MapClick()
    {
        BusMainButton.SetActive(true);
        LocaImage.sprite = LocaSprite[0];
        BusSubButton.SetActive(false);
    }

    public void BusClick()
    {
        BusMainButton.SetActive(false);
        BusSubButton.SetActive(true);
    }

    public void BusSubClick1()
    {
        LocaImage.sprite = LocaSprite[1];
    }

    public void BusSubClick2()
    {
        LocaImage.sprite = LocaSprite[2];
    }

    public void BusSubClick3()
    {
        LocaImage.sprite = LocaSprite[3];
    }

    public void TrainClick()
    {
        LocaImage.sprite = LocaSprite[4];
        BusMainButton.SetActive(true);
        BusSubButton.SetActive(false);
    }

    public void CloseButtonClick()
    {
        MenuButton.SetActive(true);
        ButtonList.SetActive(false);
        Info.SetActive(false);
        Album.SetActive(false);
        Location.SetActive(false);
    }
}
