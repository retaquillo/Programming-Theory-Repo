using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject mainPanel;
    public GameObject dataIntroPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseTitlePanel()
    {
        titlePanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void CloseDataIntroPanel()
    {
        dataIntroPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void OpenDataIntroPanel()
    {
        mainPanel.SetActive(false);
        dataIntroPanel.SetActive(true);
    }
}
