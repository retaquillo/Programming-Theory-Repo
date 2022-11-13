using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TeamManager : MonoBehaviour
{
    // UI elements: they must be public to be accessed from the Editor
    public GameObject titlePanel;
    public GameObject mainPanel;
    public GameObject dataIntroPanel;
    public Button hireButton;
    public Button introduceMembersButton;
    public Button letsWorkButton;

    public GameObject[] panels;
    public RawImage[] photos;
    public TextMeshProUGUI[] names;
    public TextMeshProUGUI[] ages;
    public TextMeshProUGUI[] responses;

    public RawImage teamMemberImage;
    public TMP_InputField teamMemberName;
    public TMP_InputField teamMemberAge;
    public TMP_Dropdown teamMemberRole;

    // List containing the members of the team
    List<Person> team = new List<Person>();
    public int maxTeamCount = 5;

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
        // Initialize the values of the UI elements that can have values from a previous edition
        teamMemberImage.texture = null;
        teamMemberName.text = "Name: ";
        teamMemberAge.text = "Age: ";
        teamMemberRole.value = 0;

        mainPanel.SetActive(false);
        dataIntroPanel.SetActive(true);
    }

    public void SelectImage(BaseEventData eventData)
    {
        RawImage gameObject;

        gameObject = eventData.selectedObject.GetComponent<RawImage>();
        teamMemberImage.texture = gameObject.texture;
    }

    public void Hire()
    {
        string name;
        int age;
        Texture texture;

        name = teamMemberName.text;
        age = int.Parse(teamMemberAge.text);
        texture = teamMemberImage.texture;

        switch (teamMemberRole.value)
        {
            case 0: // AudioArtist
                AudioArtist audioArtist = new AudioArtist();
                audioArtist.Name = name;
                audioArtist.Age = age;
                audioArtist.Photo = texture;
                team.Add(audioArtist);
                break;
            case 1: // Graph Artist
                GraphArtist graphArtist = new GraphArtist();
                graphArtist.Name = name;
                graphArtist.Age = age;
                graphArtist.Photo = texture;
                team.Add(graphArtist);
                break;
            case 2: // Programmer
                Programmer programmer = new Programmer();
                programmer.Name = name;
                programmer.Age = age;
                programmer.Photo = texture;
                team.Add(programmer);
                break;
            case 3: // Project Manager
                ProjectManager projectManager = new ProjectManager();
                projectManager.Name = name;
                projectManager.Age = age;
                projectManager.Photo = texture;
                team.Add(projectManager);
                break;
            case 4: // Tester
                Tester tester = new Tester();
                tester.Name = name;
                tester.Age = age;
                tester.Photo = texture;
                team.Add(tester);
                break;
        }

        dataIntroPanel.SetActive(false);
        mainPanel.SetActive(true);

        HideAllMembers();
        DisplayAllMembers();

        if (team.Count >= maxTeamCount)
        {
            hireButton.interactable = false;
        }
        introduceMembersButton.interactable = true;
        letsWorkButton.interactable = true;
    }

    public void IntroduceMembers()
    {
        int n;

        for (n = 0; n < team.Count; n++)
        {
            IntroduceMember(n);
        }
    }

    void IntroduceMember(int n)
    {
        responses[n].text = team[n].IntroduceYourself();
    }

    public void LetsWork()
    {
        int n;

        for (n = 0; n < team.Count; n++)
        {
            LetsWorkMember(n);
        }
    }

    void LetsWorkMember(int n)
    {
        responses[n].text = team[n].Work();
    }

    public void Fire (int n)
    {
        team.RemoveAt(n);

        HideAllMembers();
        DisplayAllMembers();

        hireButton.interactable = true;
        if (team.Count == 0)
        {
            introduceMembersButton.interactable = false;
            letsWorkButton.interactable = false;
        }
    }

    void HideAllMembers()
    {
        int n;

        for(n=0; n < maxTeamCount; n++)
        {
            panels[n].SetActive(false);
        }
    }

    void DisplayAllMembers()
    {
        int n;

        for (n = 0; n < team.Count; n++)
        {
            DisplayMember(n);
        }
    }

    void DisplayMember(int n)
    {
        panels[n].SetActive(true);
        photos[n].texture = team[n].Photo;
        names[n].text = team[n].Name;
        ages[n].text = team[n].Age.ToString();
        responses[n].text = "";
    }
}
