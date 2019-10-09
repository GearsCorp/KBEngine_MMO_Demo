using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountView : ComponentObject
{
    private Transform _selectPanel;
    private Transform _createPanel;

    public AccountView()
    {
        _selectPanel = GameObject.Find("Canvas").transform.Find("AvatarSelectPanel");
        _createPanel = GameObject.Find("Canvas").transform.Find("AvatarCreatePanel");
        _selectPanel.Find("CreateAvatarButtion").GetComponent<Button>().onClick.AddListener(() =>
        {
            _selectPanel.gameObject.SetActive(false);_createPanel.gameObject.SetActive(true);
        });
        _createPanel.Find("CreateAvatarButtion").GetComponent<Button>().onClick.AddListener(() =>
        {
            
        });

    }
}
