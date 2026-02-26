package unit03.BuildingSkill;

public class Flamewing extends MagicCreature
{
    public Flamewing(String name, int powerLevel)
    {
        super(name, powerLevel);
    }

    @Override
    public String performMagic()
    {
        return "Burst into healing flames";
    }

    @Override
    public String Speak() 
    {
        return "I am a big chicken!";
    }
}

