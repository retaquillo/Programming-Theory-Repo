using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Programmer : Person    // INHERITANCE
{
    public override string Work()   // POLYMORPHISM
    {
        return ("Let's code some software.");
    }

    public override string IntroduceYourself()  // POLYMORPHISM
    {
        string presentation;

        presentation= base.IntroduceYourself() + " My role is programmer.";

        return (presentation);
    }
}
