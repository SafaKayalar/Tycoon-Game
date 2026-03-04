using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BuySystem : MonoBehaviour
{
    [SerializeField] public GameObject magaza;
    [SerializeField] public CanvasGroup magazaCanvasGroup;

    void Start()
    {
        magazaCanvasGroup = GameObject.Find("BuySystem").GetComponent<CanvasGroup>();
        magaza.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenShop()
    {
        magaza.SetActive(true);
    }
    public void CloseShop()
    {
        magaza.SetActive(false);
    }




}
