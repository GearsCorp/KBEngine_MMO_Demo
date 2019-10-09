using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KBEngine;

public class LoginPanel : ComponentObject
{
    private AccountView _accountView;
    public LoginPanel()
    {
        gameObject = GameObject.Find("Canvas/LoginPanel");
        transForm.Find("LoginButton").GetComponent<Button>().onClick.AddListener(() =>
        {
            LoginIn(transForm.Find("UsernameInputField").GetComponent<InputField>().text, transForm.Find("PasswordInputField").GetComponent<InputField>().text);
        });
        transForm.Find("test01").GetComponent<Button>().onClick.AddListener(() => { LoginIn("test01", "test01"); });
        transForm.Find("test02").GetComponent<Button>().onClick.AddListener(() => { LoginIn("test02", "test02"); });
        transForm.Find("test03").GetComponent<Button>().onClick.AddListener(() => { LoginIn("test03", "test03"); });


        // User Event
        KBEngine.Event.registerOut("OnLoginSuccess", onLoginSuccess);
    }

    public void Update()
    {
        
    }

    private void LoginIn(string AccountStr, string PasswordStr)
    {
        KBEngine.Event.fireIn(EventInTypes.login, AccountStr, PasswordStr, new byte[] { });
    }

    public void onLoginSuccess()
    {
        gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("AvatarSelectPanel").gameObject.SetActive(true);
        _accountView = new AccountView();
    }
}
