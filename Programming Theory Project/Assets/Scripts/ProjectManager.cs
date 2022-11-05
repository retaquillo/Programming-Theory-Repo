using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : Person    // INHERITANCE
{
    public override string Work()   // POLYMORPHISM
    {
        return ("Please read the product definition I put in the dashboard.");
    }

    public override string IntroduceYourself()  // POLYMORPHISM
    {
        string presentation;

        presentation = base.IntroduceYourself() + " My role is project manager.";

        return (presentation);
    }
}
