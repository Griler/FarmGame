using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Login;
using InfoUser;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoginForm : MonoBehaviour
{
    [SerializeField] private GameObject username;
    [SerializeField] private GameObject password;
    [SerializeField] private Button btnLogin;

    private string userName = "";
    private string passWord = "";

    private void Awake()
    {
        btnLogin.onClick.AddListener(clickLogin);
    }

    void clickLogin()
    {
        userName = username.GetComponent<TMP_InputField>().text;
        passWord = password.GetComponent<TMP_InputField>().text;
        userName = "thienloc123";
        passWord = "12345";
        if (userName != "" || passWord != "")
        {
            StartCoroutine(CallLogin(userName, passWord));
        }
    }

    public IEnumerator CallLogin(string userName, string passWord)
    {
        User user = new User(userName, passWord);
        var json = user.SaveToString();
        string url = "localhost:3000/api/auth/login";
        var bytes = Encoding.UTF8.GetBytes(json);
        using (UnityWebRequest www = UnityWebRequest.Post(url, json, "application/json"))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError(www.error);
            }
            else
            {
                var jsonResult = Encoding.Default.GetString(www.downloadHandler.data);
                UserInfo userInfo = new UserInfo();
                userInfo = userInfo.fromToJson(jsonResult);
                Debug.Log("Form upload complete! " + userInfo.token);
            }
        }
    }
}