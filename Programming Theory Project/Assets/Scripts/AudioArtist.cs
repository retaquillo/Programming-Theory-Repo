using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioArtist : Person    // INHERITANCE
{
    public override string Work()   // POLYMORPHISM
    {
        return ("I'll make some astonishing sound effects.");
    }

    public override string IntroduceYourself()  // POLYMORPHISM
    {
        string presentation;

        presentation = base.IntroduceYourself() + " My role is audio artist.";

        return (presentation);
    }
}
