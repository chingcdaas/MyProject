package unit03.BuildingSkill;

public class Unicorn extends MagicCreature
{ 
    public Unicorn(String name, int powerLevel)
    {
        super(name, powerLevel);
    }

    @Override
    public String performMagic()
    {
        return "Unicorn creats rainbow!";
    }

    @Override
    public String Speak() 
    {
        return "Unicorn said RAHHHHHH";
    }
}
