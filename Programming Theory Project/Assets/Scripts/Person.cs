using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person
{
    private string m_Name = "Name not set";  // backing field
    public string Name  // ENCAPSULATION
    {
        get { return m_Name; }
        set
        {
            m_Name = value;
        }
    }

    private int m_Age = -1;  // backing field
    public int Age      // ENCAPSULATION
    {
        get { return m_Age; }
        set
        {
            if (value < 16)
            {
                Debug.Log("Our team members must be 16 years old at least...");
            }
            else if (value > 118)
            {
                Debug.Log("The oldest living person is 118 years old...");
            }
            else
            {
                m_Age = value;
            }
        }
    }

    private Texture m_Photo = null;
    public Texture Photo  // ENCAPSULATION
    {
        get { return m_Photo; }
        set
        {
            m_Photo = value;
        }
    }

    public Person()
    {
        this.m_Name = "Name not set";
        this.m_Age = -1;
        this.m_Photo = null;
    }

    public abstract string Work();   // ABSTRACTION

    public virtual string IntroduceYourself()   // ABSTRACTION
    {
        string presentation;
        presentation = "My name is " + m_Name + " and I'm " + m_Age + " years old.";
        return (presentation);
    }
}
