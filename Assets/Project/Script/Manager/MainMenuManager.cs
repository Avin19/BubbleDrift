using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button playBtn;

    void OnEnable()
    {
        playBtn?.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
