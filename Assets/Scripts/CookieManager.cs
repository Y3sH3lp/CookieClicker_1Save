using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class CookieManager : MonoBehaviour
{
    public static CookieManager instance;

     public GameObject MainGameCanvas;
    [SerializeField] private GameObject _upgradeCanvas;
    [SerializeField] private TextMeshProUGUI _cookieCountText;
    [SerializeField] private TextMeshProUGUI _cookiePerSecondText;
    [SerializeField] private GameObject _cookieObj;
    public GameObject CookieTextPopup;
    [SerializeField] private GameObject _background;

    [Space]
    [SerializeField] private GameObject _upgradeUIToSpawn;
    [SerializeField] private Transform _upgradeUiParent;
    public GameObject CookiePerSecondObjToSpawn;
    

    public double CurrentCookieCount { get; set; }
    public double CurrentCookiePerSecond { get; set; }

    //Upgrades
    public double CookiesPerClickUpgrade { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    #region UI Updates

    private void UpdateCookieUi()
    {
        
    }
}
