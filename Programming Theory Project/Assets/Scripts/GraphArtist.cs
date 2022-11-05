using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphArtist : Person    // INHERITANCE
{
    public override string Work()   // POLYMORPHISM
    {
        return ("Let's make some nice graphics.");
    }

    public override string IntroduceYourself()  // POLYMORPHISM
    {
        string presentation;

        presentation = base.IntroduceYourself() + " My role is graphic artist.";

        return (presentation);
    }
}
