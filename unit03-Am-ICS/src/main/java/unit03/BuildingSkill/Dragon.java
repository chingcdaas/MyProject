package unit03.BuildingSkill;

public class Dragon extends MagicCreature
{
    public Dragon(String name, int powerLevel)
    {
        super(name, powerLevel);
    }
    
    @Override
    public String performMagic()
    {
        return "Dragon breathes fire";
    }

    @Override
    public String Speak() 
    {
        return "Dragon said BARK BARK";
    }
}
