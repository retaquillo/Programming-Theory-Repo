using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    private string m_Name = "Name not set";  // backing field
    public string Name { get; private set; }    // ENCAPSULATION

    private int m_Age = -1;  // backing field
    public int Age      // ENCAPSULATION
    {
        get { return m_Age; }
        private set
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

    public abstract string Work();   // ABSTRACTION

    public virtual string IntroduceYourself()   // ABSTRACTION
    {
        string presentation;
        presentation = "My name is " + m_Name + " and I'm " + m_Age + " years old.";
        return (presentation);
    }
}
