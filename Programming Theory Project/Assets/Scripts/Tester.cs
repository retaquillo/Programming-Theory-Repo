using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : Person    // INHERITANCE
{
    public override string Work()   // POLYMORPHISM
    {
        return ("I have found some tricky bugs.");
    }

    public override string IntroduceYourself()  // POLYMORPHISM
    {
        string presentation;

        presentation = base.IntroduceYourself() + " My role is Q/A technician.";

        return (presentation);
    }
}

